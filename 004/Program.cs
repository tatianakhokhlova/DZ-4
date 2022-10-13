// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int Length = 12;
int[] array = new int[Length];
for(int i = 0; i < 12; i++)
     array[i] = new Random().Next(0,9);
Console.Write("Ваш массив: ");
for(int i = 0; i < 12; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();
int sum1 = 0;
int sum2 = 0;
for(int i = 0; i < 12; i++)
{
    if(array[i]>0)
       sum1 = sum1 + array[i];
}
     Console.Write($" Сумма всех положительных элементов массива {sum1} ");
     Console.WriteLine();
for(int i = 0; i < 12; i++)
{
    if(array[i]<0) 
       sum2 = sum2 + array[i];
}
     Console.Write($" Сумма всех отрицательных элементов массива {sum2} ");
     Console.WriteLine();










