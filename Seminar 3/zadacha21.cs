//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            //Решение - Корень квадратный из ((x1-x2)^2+(y1-y2)^2+(z1-z2)^2)

            double LenghtLine(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
            {
                double dx = X1 - X2;
                double dy = Y1 - Y2;
                double dz = Z1 - Z2;

                double lenght = Math.Pow(dx*dx+dy*dy+dz*dz,0.5);
                Console.WriteLine(lenght);
                return lenght;

            }


            Console.WriteLine("Введите координаты======");
            Console.WriteLine("Введите X координаты 1 точки");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y координаты 1 точки");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y координаты 1 точки");
            double z1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите X координаты 2 точки");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y координаты 2 точки");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Z координаты 2 точки");
            double z2 = Convert.ToDouble(Console.ReadLine());

            LenghtLine(x1, y1, z1, x2 , y2, z2);
