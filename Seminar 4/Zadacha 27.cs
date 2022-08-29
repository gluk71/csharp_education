//самое простое решение что можно предложить 
Console.WriteLine("Enter number:");
int a = int.Parse(Console.ReadLine());
            int s = 0;
            while (a > 0)
            {
                s = s + a % 10;
                a = a / 10;

            }
 Console.WriteLine(s);  //

//решение можно  переписать и так
int s = 0;

int outSumma(int num)
{
    while (num > 0)
       {
        s = s + num % 10;
        num = num / 10;
       }
     return s;
 }

  Console.WriteLine("Enter number:");
  int numer = int.Parse(Console.ReadLine());
  outSumma(numer);

  Console.WriteLine(s);
