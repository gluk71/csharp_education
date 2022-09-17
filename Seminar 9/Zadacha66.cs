void showNumm(int m, int n)
            {

                if (n > m)
                {
                    showNumm(m, n - 1);
                }
                Console.Write(n + "\t");
            }

            Console.Write("Input initial value: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input final value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            showNumm(a,b);
            Console.ReadLine();
