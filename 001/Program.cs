// задать массив из 8 элементов и вывести его на экран

int[] arr = {1, 2, 3, 3, 2, 5, 6, 9};
void PrintArray(int[] array)

{
    int count = array.Length;
    for(int i = 0; i<count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArray(arr);
