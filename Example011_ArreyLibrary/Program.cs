void FillArrey(int[] collection) // если метод ничего не возвращает, вот он называется vpid  методом
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1;
        index++;
    }
}

void PrintArrey(int[] col)
{

    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int[] arrey = new int[10]; //конструкция new int[10]; означает дословно "Создай новый массив в котором будет 10 элементов" 

FillArrey(arrey);
PrintArrey(arrey);
