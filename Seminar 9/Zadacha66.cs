int showSumm(int m, int n)
        {

            if (m > n)
                return 0;
            else
            {
                return m + showSumm(m + 1, n);
            }
        }

        Console.Write("Input initial value: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input final value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write(showSumm(a, b));

            Console.ReadLine();
