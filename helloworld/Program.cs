// Задача : Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

void PrintArray(string[] coll)
{
    // Принимает в аргументе массив и печатает его в консоль.

    Console.Write("массив: ");
    for (int i = 0; i < coll.Length; i++)
    {
        Console.Write(coll[i]+ ", ");
    }
    Console.WriteLine("");
}

string[] LengthFilterV1(string[] inputArray, int maxlen)
{
    // Принимает в аргументе массив строковых элементов и
    // int maxlen ограничение по длинне элементов (включая значение)
    // возвращает новый массив с элементами соответствующими условию
    int lenoutput = 0;
    for (int i = 0; i < inputArray.Length; i++) {if (inputArray[i].Length <= maxlen)lenoutput++;}
    
    int index = 0;
    string[] outputArray = new string[lenoutput];
    
    for (int j = 0; j < inputArray.Length; j++)
    {
        if(inputArray[j].Length <= maxlen) {outputArray[index] = inputArray[j]; index++;}
    }
    return outputArray;
}

bool flag = true;
while (flag == true)

{
    Console.WriteLine();
    Console.WriteLine("Для выхода введите quit\nВведите 1 для использования тестового массива,\nлибо введите" + 
    "элементы собственного массива через запятую и пробел: ");
    string[] userArray;
    string userinput = Console.ReadLine()!;
    if (userinput == "1") 
    {
        userArray = new string[] {"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science"};
        Console.Write("Тестовый: ");
        PrintArray(userArray);
        Console.Write("Итогововый ");
        PrintArray(LengthFilterV1(userArray, 3));
    }
    else if (userinput == "quit") flag = false;
    else 
    {
        userArray = userinput.Trim().Split(", ");
        Console.Write("Итогововый ");
        PrintArray(LengthFilterV1(userArray, 3));
    } 
    Console.WriteLine();
}