int[] createRAndomArray(int sizearray)
            {
                int[] arr = new int[sizearray];
                Random rnd = new Random();
                for (int i = 0; i < sizearray; i++) { 
                arr[i] = rnd.Next(100, 999);        //способ предлоденный на семинаре не работал почему тo
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
            int printEvenNumber(int[] array)
            {
                for (int i = 0; i < array.Length; i++) {
                    if (array[i] % 2 == 0) {
                        //Console.WriteLine(array[i]);
                        c++;
                    }

                }
                return c;
            }

            Console.Write("Input size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());    //запрашиваем размер массива 
            Console.Write("Create new array: ");
            int[] newArray = createRAndomArray(size);         //заполняем 3х значными числами
            printArray(newArray);                             //печатаем массив 
            Console.WriteLine("=============");
            Console.WriteLine($"Колмчество четных чисел  - {printEvenNumber(newArray)}");

            Console.ReadLine();
