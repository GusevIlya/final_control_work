string[] GetArray(string message)
{
    Console.Write(message);
    string array = Console.ReadLine()!;
    string[] elements = array.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    return elements;
}
string[] Array3Chars(string[] array)
{
    int size = 0;
    foreach (string s in array)
    {
        if (s.Length <= 3)
        {
            size++;
        }
    }
    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}
void PrintArray(string message, string[] array)
{
    Console.Write(message);
    string newArray = string.Join(", ", array);
    Console.Write(newArray);
}

string[] text = GetArray("Введите элементы массива через пробел: ");
string[] newText = Array3Chars(text);
if (newText.Length == 0)
{
    Console.Write("Элементы, содержащие 3 и менее символов не найдены...");
}
else PrintArray("Новый массив: ", newText);