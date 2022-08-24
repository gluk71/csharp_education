void OutTwoDigit(int num)
{
    string number;                                          //
    number = Convert.ToString(num);                         //число в строку
    //if(number.Length < 3)
    //Console.WriteLine("Число слишком короткое!");             

    char[] arr = number.ToCharArray();                      //создаем массив нужного размера 
    Console.Write("Выводим второй символ - ");
    Console.WriteLine(arr[1]);                              //не забываем о том что в массиве индекс с 0
}

int enternum; 
Console.WriteLine("Enter 3digit number");
enternum = Convert.ToInt32(Console.ReadLine());

OutTwoDigit(enternum);
