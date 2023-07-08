void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(23,350);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine(collection[index]);
        index++;
    }
}

int [] array = new int [15]; //создай новый массив из 10 элементов. каждый элемент = 0
FillArray(array);
PrintArray(array);


