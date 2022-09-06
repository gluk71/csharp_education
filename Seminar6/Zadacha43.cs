 double[] array = new double[2];

            double[] printCoordinate(double a, double b, double c, double d)     //создаем массив и записваем рассчитанные кординыты в массив и возвращаем массив 
            {
                //double[] array = new double[1];
                array[0] = (b - a) / (c - d);
                array[1] = c * array[0] + a;
                return array;
            }

            //вводим необходиммые параметры для расчета
            Console.Write("Вводим значение b1:...");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Вводим значение b2:...");
            int b2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Вводим значение k1:...");
            int k1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Вводим значение k2:...");
            int k2 = Convert.ToInt32(Console.ReadLine());

            printCoordinate(b1, b2, k1, k2);
            Console.Write($"Координаты (x,y): {array[0].ToString()}, {array[1].ToString()} ");

            Console.ReadLine();
