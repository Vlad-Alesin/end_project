/* написать прогу, кот из имеющегося массива 
формирует массив из строк, длина которых <=3 символам.
первовнач массив ввести с клавы 

пример ["23","aaa","s","asdas","1232"]

*/

//заполнение массива из строки
string[] ReadArray(string message)
{
    Console.WriteLine(message);
    string mes = Console.ReadLine();
    mes = mes.Replace(" ", "");
    string[] StartArray = mes.Split(',');   
    return StartArray; 
}

//создание нового массива, проверка на кол-во символов
string[] NewArray(string[] array)
{
    int j = 0;
    for (int i= 0; i< array.GetLength(0); i++)
    {
        string trans = array[i];
        if (trans.Length <=3) 
        {
            j++;
        }
    } 
    string[] result = new string[j];
    j = 0;
    for (int i= 0; i< array.GetLength(0); i++)
    {
        string trans = array[i];
        if (trans.Length <=3) 
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

// вывод готового массива
void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i<= array.Length-2) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

string[] arrayz = ReadArray("Введите символы через запятую");
string[] arrayRez = NewArray(arrayz); 
PrintArray(arrayRez);

