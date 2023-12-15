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


int count;
string str;
do
{
    Console.Write("Вводим массив с клавиатуры? (Y - да / N - нет): ");
    str = Console.ReadLine();
    Console.WriteLine(str);
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
}
else
{
    string[] array = new string[] { "Hello", "2", "world", ":-)" };
}