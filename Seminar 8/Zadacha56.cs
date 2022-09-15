            //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            int j;
            int[,] Create2DRandomArray()
            {
                Console.Write("Input numbers of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Input numbers of columns: ");
                int cols = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input min possible value: ");
                int minVal = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input max possible value: ");
                int maxVal = Convert.ToInt32(Console.ReadLine());
                int[,] newArray = new int[rows, cols];
                Random random = new Random();
                for (int i = 0; i < rows; i++)
                {
                    for (j = 0; j < cols; j++)
                    {
                        newArray[i, j] = random.Next(minVal, maxVal);
                    }
                }
                return newArray;
            }

            void Print2DArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j]);
                        Console.Write("\t");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }

            void NumOfString(int[,] array)
            {
                int str = 1;
                int value = 0;
                for (j = 0; j < array.GetLength(0); j++)
                {
                    int summ = 0;
                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        summ = summ + array[j, i];
                    }

                    if (summ < value)
                    {
                        Console.WriteLine($"строка - {j + 1}");
                    }
                    value = summ;
                }
            }

            int[,] arr2D = Create2DRandomArray();
            Print2DArray(arr2D);
            NumOfString(arr2D);
