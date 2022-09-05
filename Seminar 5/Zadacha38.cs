// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
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

            int range = 0;
            int outMaxMinDiff(int[] array)
            {
                //придумал такой вариант в качестве самого простого 
                int minimum = array[0];    //нинимальное значение
                int maximum = minimum;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] <= minimum)
                    {
                        minimum =  array[i];
                    }
                    else if(array[i] > maximum)
                    {
                        maximum = array[i];
                    }
                }
                Console.WriteLine($"Minimum - {minimum}");
                Console.WriteLine($"Maximum - {maximum}");
                return range = maximum - minimum;
            }

            //чуть позже появился второй вариант - через сортировку
            int ShowRange(int[] array) {
                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                           array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
                return range = array[array.Length -1] - array[0];
            }

            Console.Write("Input size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());    //запрашиваем размер массива 
            Console.Write("Input minimal number of array: ");
            int min = Convert.ToInt32(Console.ReadLine());    //запрашиваем размер массива 
            Console.Write("Input maximal number of array: ");
            int max = Convert.ToInt32(Console.ReadLine());    //запрашиваем размер массива 

            Console.Write("Create new array: ");
            int[] newArray = createRAndomArray(size, min, max);         //заполняем 3х значными числами
            printArray(newArray);                             //печатаем массив 
            Console.WriteLine("=============");
            Console.WriteLine($"Разность между максимальным и минимальным элементом массива = {outMaxMinDiff(newArray)}");
            Console.WriteLine("========= Вариант с сортировкой ===========");
            Console.WriteLine("Sorted array");
            Console.WriteLine($"Разность между максимальным и минимальным элементом массива = {ShowRange(newArray)}");
            Console.ReadLine();
