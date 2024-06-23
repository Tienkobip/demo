
using System;

class Program
{
    const int MaxHang = 50;
    const int MaxCot = 50;

    static void ThuatToanLoang(int[,] a, int hang, int cot)
    {
        int[] x = { 0, 0, 1, -1 };
        int[] y = { 1, -1, 0, 0 };
        /*
        * - 2 mảng x và y có tác dụng:
        * + Tại vị trí đầu tiên cuả 2 mảng x và y là "0" và "1" kiểm tra phần tử sau phần tử
        đang xét.
        * + Tại vị trí 2 cuả 2 mảng x và y là "0" và "-1" kiểm tra phần tử trước phần tử
        đang xét.
        * + Tại vị trí 3 cuả 2 mảng x và y là "1" và "0" kiểm tra phần tử trên phần tử
        đang xét.
        * + Tại vị trí 4 cuả 2 mảng x và y là "1" và "0" kiểm tra phần tử dưới phần tử
        đang xét.

        => Mảng x tương ứng với hàng, mảng y tương ứng với cột
        */

        for (int i = 0; i < hang; i++)
        {
            for (int j = 0; j < cot; j++)
            {
                bool Check = true;

                for (int k = 0; k < 4; k++)
                {
                    if (i + x[k] >= 0 && i + x[k] < hang && j + y[k] >= 0 && j + y[k] < cot &&
                        a[i, j] <= a[i + x[k], j + y[k]])
                    {
                        Check = false;
                        break;
                    }
                }

                if (Check)
                {
                    Console.Write(a[i, j] + " ");
                }
            }
        }
    }

    static void Main()
    {
        int hang, cot;
        hang = int.Parse(Console.ReadLine());
        cot = int.Parse(Console.ReadLine());

        int[,] a = 
        {
            {2, 23, 5, -3},
            {8, 9, 7, 5},
            {5, 13, 11, 4}
        };

        // for (int i = 0; i < hang; i++)
        // {
        //     for (int j = 0; j < cot; j++)
        //     {
        //         a[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }

        ThuatToanLoang(a, hang, cot);
        Console.WriteLine("Hello world");
    }
}
