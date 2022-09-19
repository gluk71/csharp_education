 //Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
        static void Main(string[] args)
        {
            void showNumm(int m, int n)
            {
                if (n > m)
                {
                    showNumm(m, n - 1);
                }

                if (m > n)
                {
                    showNumm(n,m);
                }

                Console.Write(n + "\t");
            }

            Console.Write("Input initial value: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input final value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            showNumm(a, b);
            Console.ReadLine();
