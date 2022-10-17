// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Write("Введите размер массива: ");
int Length = int.Parse(Console.ReadLine()?? "0");
double[] array = new double[Length];
for(int i = 0; i < Length; i++)
     array[i] = new Random().Next(1,10);
Console.WriteLine("Ваш массив: ");

for(int i = 0; i < Length; i++)

    Console.Write($"{array[i]} ");
    Console.WriteLine();

double max = array[0];
double min = array[0];
double P = 0;
for(int i = 1; i<Length; i++)
{
    if(array[i]>max)
    {
        max=array[i];
    }
    if(array[i]<min)
    {
        min=array[i];
    }
    P=max-min;
}
    Console.WriteLine($"{max} максимальное число в массиве, {min} минимальное число в массиве ");
    Console.WriteLine($"разница {max} - {min} = {P} ");