//Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.
           

            int[,] create2Darray(int row,int col,int min,int max)
            {
                int[,] newArray = new int[row, col];
                Random random = new Random();
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        newArray[i, j] = random.Next(min, max);
                    }
                }
                return newArray;
            }

            int[,] outResultArray(int[,] a1, int[,] a2)
            {
                if(a1.GetLength(1) != a2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");

                int[,] arrResult = new int[a1.GetLength(0), a2.GetLength(1)];

                for (int i = 0; i < a1.GetLength(0); i++)
                {
                    for (int j = 0; j < a2.GetLength(1); j++)
                    {
                        for (int k = 0; k < a2.GetLength(0); k++)
                        {
                            arrResult[i, j] += a1[i, k] * a2[k, j];
                        }
                    }
                }
                Console.WriteLine("multiplication result:");
                Print2DArray(arrResult);
                return arrResult;
            }

            void Print2DArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(string.Format("{0:F1}", array[i, j]));
                        Console.Write("\t");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Enter data for first array:.....");
            Console.Write("Input numbers of rows in first array: ");
            int rows1 = Convert.ToInt32(Console.ReadLine());    //m
            Console.Write("Input numbers of columns in first array: ");
            int cols1 = Convert.ToInt32(Console.ReadLine());    //n
            Console.Write("Input min possible value: ");
            int minVal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input max possible value: ");
            int maxVal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter data for two array:.....");
            Console.Write("Input numbers of rows in first array: ");
            int rows2 = Convert.ToInt32(Console.ReadLine());    //m
            Console.Write("Input numbers of columns in first array: ");
            int cols2 = Convert.ToInt32(Console.ReadLine());    //n
            Console.Write("Input min possible value: ");
            int minVal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input max possible value: ");
            int maxVal2 = Convert.ToInt32(Console.ReadLine());

            int[,] newArray1 = create2Darray(rows1, cols1, minVal1, maxVal1);
            Print2DArray(newArray1);

            int[,] newArray2 = create2Darray(rows2, cols2, minVal2, maxVal2);
            Print2DArray(newArray2);

            outResultArray(newArray1,newArray2);
