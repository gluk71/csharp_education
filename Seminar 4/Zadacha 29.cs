            void printArray(string[] Array)
            {
                Console.WriteLine("\n Вывод массива");

                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine(Array[i]);
                }
            }

            string[] myArray = new string[8];   // по заданию 8 эелементов в массиве и так как числа при  вводе с консоли это строки то не конвертим в int

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}:\t");
                myArray[i] = Console.ReadLine();
            }

            printArray(myArray);
            Console.ReadLine();
