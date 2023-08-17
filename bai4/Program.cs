using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ban hay nhap bai tap:");
                int baitap = int.Parse(Console.ReadLine());
                switch (baitap)
                {
                    case 1:
                        Baitap1();
                        break;
                    case 2:
                        Baitap2();
                        break;
                    case 3:
                        Baitap3();
                        break;
                    case 4:
                        Baitap4();
                        break;
                    case 5:
                        Baitap5();
                        break;
                    case 6:
                        Baitap6();
                        break;
                    case 7:
                        Baitap7();
                        break;
                    case 8:
                        Baitap8();
                        break;
                    case 9:
                        Baitap9();
                        break;
                    case 10:
                        Baitap10();
                        break;
                    default:
                        Console.WriteLine("Bai tap ko ton tai");
                        break;
                } 
            bool stop = DungChuongTrinh();
            if (stop) break;
            }
            Console.ReadKey();
        }
        public static bool DungChuongTrinh()
        {
            Console.WriteLine();
            Console.WriteLine("Ban co muon dung chuong trinh?");
            Console.WriteLine("Phim bat ky de tiep tuc!");
            Console.WriteLine("Nhan phiem delete De thoat chuong trinh");
            ConsoleKeyInfo str = Console.ReadKey();
            if (str.Key == ConsoleKey.Delete) return true;
            Console.Clear();
            return false; 
            
        }

        public static void Baitap10()
        {
            //Bai 10
            int n = NhapSoNguyen();
            int f1 = 0;
            int f2 = 1;
            int f3 = 0;
            switch (n)
            {
                case 1:
                    Console.WriteLine(f1);
                    break;
                case 2:
                    Console.Write(f1 + " " + f2);
                    break;
                default:
                    Console.Write(f1 + " " + f2);
                    for (int k = 3; k <= n; k++)
                    {
                        f3 = f2 + f1;
                        f1 = f2;
                        f2 = f3;

                        Console.Write(" " + f3);
                    }
                    break;
            }

        }

        public static void Baitap9()
        {
            //Bai 9 
            int n = NhapSoNguyen();
            string sao = "";
            Console.WriteLine("Hinh tam giac");
            for (int i = 1; i <= n; i++)
            {
                sao = sao + "*";
                Console.WriteLine(sao);
            }
            //Tam giac nguoc
            Console.WriteLine("Hinh tam gac nguoc");
            string tgiacnguoc = "";
            for (int j = n; j >= 0; j--)
            {
                for (int i = 1; i <= j; i++)
                {
                    tgiacnguoc = tgiacnguoc + "*";
                }
                Console.WriteLine(tgiacnguoc);
                tgiacnguoc = "";
            }
        }

        public static void Baitap8()
        {
            //Bai8 
            int n = NhapSoNguyen();
            for (int i = 1; i <= n; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
        }

        public static void Baitap7()
        {
            //Bai 7
            int n = NhapSoNguyen();
            int sum6 = 0;
            for (int i = 1; i <= n; i = i + 2)
            {
                sum6 += i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"Tong cac so le tu 1 toi {n}: {sum6}");
        }

        public static void Baitap6()
        {
            //Bai 6
            //Cach 1
            int n = NhapSoNguyen();
            long sum3 = 0;

            for (int i = 1; i <= n; i++)
            {
                sum3 = (long)Math.Pow(i, i) + sum3;
                Console.WriteLine("+" + (long)Math.Pow(i, i));

            }
            Console.WriteLine(" = " + sum3);

            ////cach 2
            //int n = NhapSoNguyen();
            //long sum4 = 1;
            //long sum5 = 0;
            //for (int j = 1; j <= n; j++)
            //{

            //    for (int i = 1; i <= j; i++)
            //    {
            //        sum4 = j * sum4;
            //    }
            //    Console.Write("+" + sum4);
            //    sum5 = sum4 + sum5;
            //    sum4 = 1;
            //}
            //Console.Write(" = " + sum5);


        }

        public static void Baitap5()
        {
            //Bai 5

            int n = NhapSoNguyen();
            switch (n)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Thang {n} co 30 ngay");
                    break;
                case 2:
                    Console.WriteLine($"Thang {n} co 28 hoac 29 ngay");
                    break;
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Thang {n} co 31 ngay");
                    break;
                default:
                    Console.WriteLine("Thang ko ton tai");
                    break;
            }
        }

        public static void Baitap4()
        {
            //Bai 4
           int n = NhapSoNguyen();
            string str1 = "ko la so chinh phuong";
            if (Math.Sqrt(n) % 1 == 0)
            {
                str1 = "la so chinh phuong";
            }
            Console.WriteLine("So {0} {1}", n,str1);
        }

        public static void Baitap3()
        {
            //Bai 3
            int n = NhapSoNguyen();
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum +=i;
            }
            Console.WriteLine("Tong cac so hang tu 1 toi {0}: {1}",n,sum);
        }

        public static void Baitap2()
        {
            //Bai 2
            int n = NhapSoNguyen();
            Console.WriteLine("Bang cuu chuong");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j}= {i * j}");
                }
            }
        }

        public static void Baitap1()
        {
            //Bai 1
            int n = NhapSoNguyen();
            string str = "ko chia het";
            if (n % 3 == 0)
            {
                str = "chia het";
            }
            Console.WriteLine("so nguyen N {0} cho 3", str);
        }

        public static int NhapSoNguyen()
        {
            Console.WriteLine("Nhap so Nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
    }
}
