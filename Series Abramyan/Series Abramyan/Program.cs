using System;

namespace Series_Abramyan
{
    class Seriess
    {
        static void Series1()
        {
            int n = 0;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                n = int.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine(sum);
        }

        static void Series3()
        {
            int n = 0;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                n = int.Parse(Console.ReadLine());
                sum += n;
            }
            sum /= 10;
            Console.WriteLine(sum);
        }

        static void Series5()
        {
            float d;
            int n = 0;
            n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                d = float.Parse(Console.ReadLine());
                d = (int)d;
                Console.WriteLine(d);
                sum += (int)d;

            }
            Console.WriteLine(sum);
        }
        static void Series7()
        {
            double d;
            int n = 0;
            n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                d = float.Parse(Console.ReadLine());
                d = Math.Round(d);
                Console.WriteLine(d);
                sum += (int)d;

            }
            Console.WriteLine(sum);
        }
        static void Series9()
        {
            int n = 0, k = 0, f = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                f = int.Parse(Console.ReadLine());
                if (f % 2 != 0)
                {
                    Console.WriteLine(f);
                    k++;

                }


            }
            Console.WriteLine(k);
        }
        static void Series11()
        {
            int n = 0, k = 0, f = 0;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                f = int.Parse(Console.ReadLine());
                Console.WriteLine(f < k ? "Правда" : "Ложь");
            }

        }
        static void Series13()
        {
            int n = 0, k = 0, f = 1;
            int sum = 0;
            while (f > 0)
            {

                f = int.Parse(Console.ReadLine());

                if (f % 2 == 0)
                    sum = sum + f;
            }
            Console.WriteLine(sum);
        }
        static void Series15()
        {
            int n = 0, k = int.Parse(Console.ReadLine());
            int f = 0;
            int sum = 0;
            n = int.Parse(Console.ReadLine());

            while (f > 0)
            {
                n++;
                f = int.Parse(Console.ReadLine());
                if (f > k)
                    Console.WriteLine(f + "номер числа");

            }
            Console.WriteLine(sum);
        }
        static void Series17()
        {
            double b = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int f;
            bool check = false;

            for (int i = 0; i < n; i++)
            {
                f = int.Parse(Console.ReadLine());
                Console.WriteLine(f);
                if (b < f && !check)
                {
                    Console.WriteLine(b);
                    check = true;
                }
            }
        }
        static void Series19()
        {

            int n = int.Parse(Console.ReadLine());
            int f, fonleft = int.Parse(Console.ReadLine());
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                f = int.Parse(Console.ReadLine());
                if (fonleft > f)
                {
                    Console.WriteLine(f);
                    k++;
                }
                fonleft = f;
            }
            Console.WriteLine(k);
        }

        static void Series21()
        {

            int n = int.Parse(Console.ReadLine());
            int f, fprev = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n - 1; i++)
            {
                f = int.Parse(Console.ReadLine());
                Console.WriteLine(fprev < f ? "Правда" : "Ложь");

            }
        }
        static void Series24()
        {

            int n = int.Parse(Console.ReadLine());
            int f, fplus = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                f = int.Parse(Console.ReadLine());
                fplus += f;
                if (f == 0)
                {
                    sum = +fplus;
                    fplus = 0;
                }
            }

        }
        static void Series25()
        {

            int n = int.Parse(Console.ReadLine());
            int f, fplus = 0;
            int sum = 0;
            bool check = false;
            for (int i = 1; i <= n; i++)
            {
                f = int.Parse(Console.ReadLine());
                fplus += f;
                if (f == 0 && !check)
                {
                    sum = +fplus;
                    check = true;
                    fplus = 0;
                }
            }
        }
        static void Series27()
        {

            int n = int.Parse(Console.ReadLine());
            double f;

            for (int i = 1; i <= n; i++)
            {
                f = double.Parse(Console.ReadLine());
                f -= 1;
                for (int a = 0; a < f - 1; a++)
                {
                    f *= f;

                }
                Console.WriteLine(f);
                f += 1;
                for (int d = 0; d < f; d++)
                {
                    f *= f;
                }
            }
        }
        static void Series29()
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int f;
            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                for (int d = 0; d < n; d++)
                {
                    f = int.Parse(Console.ReadLine());
                    sum += f;
                }
                Console.WriteLine(sum);
                sum = 0;
            }

        }
        static void Series31()
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int f;
            int inc = 0;

            for (int i = 0; i < k; i++)
            {
                for (int d = 0; d < n; d++)
                {
                    f = int.Parse(Console.ReadLine());
                    if (f == 2)
                        inc++;
                }

            }
            Console.WriteLine(inc);
        }
        static void Series33()
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int f;
            int inc = 0;


            for (int i = 0; i < k; i++)
            {
                for (int d = 0; d < n; d++)
                {
                    f = int.Parse(Console.ReadLine());
                    if (f == 2)
                        inc = d;
                }
                inc = 0;
            }
            Console.WriteLine(inc);
        }
        static void Series35()
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int f = 1;
            int inc = 0;
            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                while (f != 0)
                {
                    f = int.Parse(Console.ReadLine());
                    inc++;
                }

                Console.WriteLine(inc);
                sum += inc;
                inc = 0;
            }
        }
        static void Series36()
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int f = 1, fprev = int.Parse(Console.ReadLine());
            int inc = 0;
            int sum = 0;
            bool check = false;

            for (int i = 0; i < k; i++)
            {
                while (f != 0)
                {
                    f = int.Parse(Console.ReadLine());

                    if (fprev < f && !check)
                    {
                        sum = 1;
                        fprev = f;
                    }
                    else
                    {
                        sum = 0;
                        check = true;
                    }
                }
                if (sum == 1)
                    inc++;
                sum = 0;
                check = false;
            }
        }
        static void Series39()
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int f = 1, fprev = 0, fnext = 0;

            int inc = 0;
            int sum = 0;
            bool check = false;

            for (int i = 0; i < k; i++)
            {
                while (f != 0)
                {
                    fprev = int.Parse(Console.ReadLine());
                    f = int.Parse(Console.ReadLine());
                    fnext = int.Parse(Console.ReadLine());
                    if (f < fprev && f < fnext || f > fprev && f > fnext)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Series39();
        }
    }
}
