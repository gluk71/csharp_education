//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void IndexOfint(int[] DayOfWeek,int value)
{
        int i = Array.IndexOf(DayOfWeek,value);
        //Console.WriteLine(i);
        if (i<=4)
        {
            Console.WriteLine($"{value} нет");
        }
        else
        {
            Console.WriteLine($"{value} ДА");
        }
}

Console.WriteLine("Enter number day of week.....");      //вводим строку а не число

var number = Console.ReadLine();
     if(number is null){
            return;
     }
//                            0  1  2  3  4  5  6
int[] DayOfWeek = new int[] { 1, 2, 3, 4, 5, 6, 7 };

IndexOfint(DayOfWeek, Convert.ToInt32(number));
