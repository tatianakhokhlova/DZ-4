// задать массив из 8 элементов и вывести его на экран

int Length = 8;
int[] array = new int[Length];
for(int i = 0; i < 8; i++)
     array[i] = new Random().Next(0,2);
Console.Write("Ваш массив: ");
for(int i = 0; i < 8; i++)
    Console.Write($"{array[i]} ");