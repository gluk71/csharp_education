        void Out3Digit(char[] theArray)
        {
            Console.Write("Выводим третий символ - ");
            Console.WriteLine(theArray[2]);
        }

        Console.WriteLine("Enter number.....");      //вводим строку а не число
        var number = Console.ReadLine();
        if(number is null){
            return;
        }

        if(number.Length < 3){
            Console.WriteLine("Число очень маленькое!");
            return;
        }

        char[] theArray = number.ToCharArray();      //конвертируем число в массив 

        Out3Digit(theArray);
