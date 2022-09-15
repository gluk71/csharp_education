            //Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            int rows;
            int cols;
            int temp;

            int[,] Create2DRandomArray()
            {
                Console.Write("Input numbers of rows: ");
                rows = Convert.ToInt32(Console.ReadLine());    //m
                Console.Write("Input numbers of columns: ");
                cols = Convert.ToInt32(Console.ReadLine());    //n
                Console.Write("Input min possible value: ");
                int minVal = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input min possible value: ");
                int maxVal = Convert.ToInt32(Console.ReadLine());
                int[,] newArray = new int[rows, cols];
                Random random = new Random();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
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
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j]);
                        Console.Write("\t");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }

            void sortArrays(int[] array)    //тут делаем сортировку и вывод построчно 
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    } 
                }
                for (int j=0;j < array.Length; j++)
                {
                    Console.Write(array[j] + "\t");
                }
                Console.WriteLine();
            }

            int[] outVal(int[,] array)
            {
                int[] tmparray = new int[array.GetLength(1)];
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        tmparray[i] = array[j,i];
                    }
                    sortArrays(tmparray);
                }
                return tmparray;
                Console.ReadLine();
            }

            int[,] arr2D = Create2DRandomArray();
            Print2DArray(arr2D);
            int [] tmparrays = outVal(arr2D);
