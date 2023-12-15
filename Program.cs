string[] arrayInput(int n)
{
    string[] arr = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void newArrayCreate(string[] arr, int n)
{
    string[] newarr = new string[n];
    int j = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[i].Length <= 3)
        {
            newarr[j] = arr[i];
            j++;
        }
    }
    printArray(newarr, j);
}

void printArray(string[] array, int m)
{
    Console.Write("[" + string.Join(", ", array.Take(m).Select(element => $"“{element}”")) + "]");
}

int count;
string str;
do
{
    Console.Write("Вводим массив с клавиатуры? (Y - да / N - нет): ");
    str = Console.ReadLine();
}
while (str != "Y" && str != "N");
if (str == "Y")
{
    do
    {
        Console.Write("Введите число элементов массива: ");
        str = Console.ReadLine();
    }
    while (!int.TryParse(str, out count) || count <= 0);
    string[] array = arrayInput(count);
    printArray(array, count);
    Console.Write(" → ");
    newArrayCreate(array, count);
}
else
{
    string[] array = new string[] { "Hello", "2", "world", ":-)" };
    count = array.Length;
    printArray(array, count);
    Console.Write(" → ");
    newArrayCreate(array, count);
}
