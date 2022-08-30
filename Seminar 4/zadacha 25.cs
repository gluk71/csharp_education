int resultat=0;
int StepenNumber(int a, int b)       //a основание, b показатель
{
   int i;                           //для работы цикла   
   resultat = a;
   for (i = 1; i < b; i++)
   {
        resultat = resultat * a;
   }
   return resultat;
}

Console.WriteLine("Введите основание степени");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("Введите показатель  степени");
int d = int.Parse(Console.ReadLine());

StepenNumber(c,d);
Console.WriteLine(resultat);
