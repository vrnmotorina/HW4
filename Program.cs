//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/* Console.WriteLine ("Введите число a");
int a = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите число b");
int b = int.Parse (Console.ReadLine());

int res= 1;

for(int i=1; i<=b; i++)
{
        res=res * a;
}

Console.WriteLine (res);
 */

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/* void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index<lenght)
    {
        collection[index]=new Random().Next();
        index ++;
    }
}

void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + ",");
        position ++;
    }
}
int[]array = new int[8];
FillArray(array);
Console.Write ("[");
PrintArray(array);
Console.Write ("]"); */

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/* Console.WriteLine ("Введите число");
int a = int.Parse (Console.ReadLine());

int sum=0;
while (a > 0)
{
    int d = a % 10;
    a = a / 10;
    sum += d;
}
Console.Write(sum);
 */
