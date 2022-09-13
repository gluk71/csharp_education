nt[,] Create2DRandomArray()
            {
                Console.Write("Input numbers of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());    //m
                Console.Write("Input numbers of columns: ");
                int cols = Convert.ToInt32(Console.ReadLine());    //n
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

            int[] outVal(int[,] array)
            {
                int j;
                int[] nums = new int[array.GetLength(1)];

                for (j = 0; j < array.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        sum += array[i, j];
                        nums[j] = sum / array.GetLength(1); ;
                    }
                }

                foreach (int i in nums)
                {
                    Console.Write(i + "\t");
                }
                Console.ReadLine();
                return nums;
            }

            Console.WriteLine();

            int[,] arr2D = Create2DRandomArray();
            Print2DArray(arr2D);
            outVal(arr2D);
