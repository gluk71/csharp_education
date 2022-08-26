
            //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            int outCubNumber(double a)
            {
                double b;
                for (b = 1; b <= a; b++)
                {
                    int z = Convert.ToInt32(Math.Pow(b, 3));
                    Console.WriteLine(z);
                }
                return 1;
            }

            double n = Convert.ToDouble(Console.ReadLine());

            outCubNumber(n);
