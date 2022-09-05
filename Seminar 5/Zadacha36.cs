            //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
            int[] createRAndomArray(int sizearray, int minValue, int maxValue)
            {
                int[] arr = new int[sizearray];
                Random rnd = new Random();

                for (int i = 0; i < sizearray; i++)
                {
                    arr[i] = rnd.Next(minValue, maxValue);        //способ предлоденный на семинаре не работал почему тo
                }
                return arr;
            }

            void printArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i] + " ");

                Console.WriteLine();
            }

            int c = 0;
            int printOddSum(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        c = c + array[i];
                    }

                }
                return c;
            }

            Console.Write("Input size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());    //запрашиваем размер массива 
            Console.Write("Input minimal value of array: ");
            int min = Convert.ToInt32(Console.ReadLine());    //запрашиваем размер массива 
            Console.Write("Input maximal value of array: ");
            int max = Convert.ToInt32(Console.ReadLine());    //запрашиваем размер массива 

            Console.Write("Create new array: ");
            int[] newArray = createRAndomArray(size,min,max);         //заполняем 3х значными числами
            printArray(newArray);                             //печатаем массив 
            Console.WriteLine("=============");
            Console.WriteLine($"Сумма чисел = {printOddSum(newArray)}");

            Console.ReadLine();
