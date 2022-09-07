 int[] createRAndomArray(int sizearray)
            {
                int[] arr = new int[sizearray];
                
                for (int i = 0; i < sizearray; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());       
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
            int printNumber(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        c++;
                    }

                }
                return c;
            }

            Console.Write("Input size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());   
            Console.Write("Create new array: ");
            int[] newArray = createRAndomArray(size);         
            //printArray(newArray);                              

            Console.WriteLine($"Колмчество четных чисел  - {printNumber(newArray)}");

            Console.ReadLine();
