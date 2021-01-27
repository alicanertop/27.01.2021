using System;

namespace _27._01._2021
{

    static class Exam
    {

        public static int PrimeMı(int sayı, bool artıyorMu)
        {
            while (true)
            {
                bool asalMı = true;
                if (artıyorMu)
                {
                    sayı = sayı + 1;
                }
                else
                {
                    sayı = sayı - 1;
                }

                int sayınınKoku = (int)Math.Sqrt(sayı);

                for (int i = 2; i <= sayınınKoku; i++)
                {
                    if (sayı % i == 0)
                    {
                        asalMı = false;
                        break;
                    }
                }
                if (asalMı)
                    return sayı;
            }
        }

        public static void QuestionOne()
        {
            Console.Write("Sayı Giriniz: ");
            string girilenSayıString = Console.ReadLine();

            int girilenSayı = Convert.ToInt32((girilenSayıString));
            double girilenSayıKaresi = Math.Pow(girilenSayı, 2);
            int sonHanesi = Convert.ToInt32(girilenSayıKaresi % Math.Pow(10, girilenSayıString.Length));


            if (sonHanesi == girilenSayı)
            {
                Console.WriteLine("Girdiginiz sayi OTOMORF bir sayidir");
            }
            else
            {
                Console.WriteLine("Girdiginiz sayi OTOMORF bir sayi degildir.");
            }
        }


        public static void QuestionTwo()
        {
            int sayımız = Convert.ToInt32(Console.ReadLine());

            int ufakEnYakınAsalBüyük = PrimeMı(sayımız, true);
            int ufakEnYakınAsalKüçük = PrimeMı(sayımız, false);

            bool araAsalMı = (ufakEnYakınAsalKüçük + ufakEnYakınAsalBüyük) / 2 == sayımız;

            Console.WriteLine(araAsalMı);
        }

        public static bool p(int n)
        {

            for (int i = 3; i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return n % 2 == 0 ? false : true;
        }

        public static void QuestionThree()
        {

            int[] sayılar = { 5, 10, 15, 13, 15, 22, 42, 21, 99, 4 };

            int n = sayılar.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (sayılar[j] > sayılar[j + 1])
                    {
                        int temp = sayılar[j];
                        sayılar[j] = sayılar[j + 1];
                        sayılar[j + 1] = temp;
                    }


            foreach (var item in sayılar)
            {
                Console.WriteLine(item);
            }
        }

        public static void QuestionFour()
        {

            int[] dizi = new int[10];
            int i;
            Console.Write("\n\nBir dizi yaz ve  elemanını  değiştir:\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("\nKaç elemanlı  bir dizi  yazmak istiyorsunuz?\n");
            int dizisayısı = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dizisayısı + "Adet eleman giriniz:");
            for (i = 0; i < dizisayısı; i++)
            {
                Console.Write("element - {0} : ", i);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nDizideki elemanlar şunlardır: ");
            for (i = 0; i < dizisayısı; i++)
            {
                Console.Write("{0}  ", dizi[i]);
            }
            Console.Write("\n");
            Console.Write("\n Dizi içinden değiştirmek istediğiniz sayının sırasını giriniz\n");
            int sırasayısı = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sırasayısı + ". Elamanı hangi sayı ile değiştirmek istediğinizi  giriniz");
            int değişken = Convert.ToInt32(Console.ReadLine());
            sırasayısı--;
            dizi[sırasayısı] = değişken;
            Console.Write("\nDizideki elemanlar şunlardır: ");
            for (i = 0; i < dizisayısı; i++)
            {
                Console.Write("{0}  ", dizi[i]);
            }
        }

        public static void QuestionFive()
        {

            int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int row = 3, col = 3;

            int i, j;
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    if (i > j)
                    {
                        Console.Write("0" + " ");
                    }
                    else
                        Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }



    }


    class Program
    {


        static void Main(string[] args)
        {

            Exam.QuestionTwo();
            Console.ReadKey();
        }
    }
}
