bool IsPalindrome(int number)
            {
                if (number < 0)
                {
                    throw new ArgumentException($"{number} is less than zero!");
                }
                int numberTemp = number;
                int value;

                int numberRevers = 0;

                while (numberTemp > 0)
                {
                    value = numberTemp % 10;               
                    numberRevers = numberRevers * 10 + value;
                    numberTemp /= 10;
                }

                if (numberRevers == number)
                {
                    Console.WriteLine("True");
                    return true;
                }
                else
                {
                    Console.WriteLine("False");
                    return false;
                }

            }

            Console.WriteLine("Enter number.....");      //вводим строку а не число
            int a = Convert.ToInt32(Console.ReadLine());
            IsPalindrome(a);
           
