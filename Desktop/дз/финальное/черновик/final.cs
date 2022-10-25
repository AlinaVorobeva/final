// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3-м символам.


string[] array ;

Console.WriteLine("Введите массив строк через запятую: ");
string stroka = Console.ReadLine();
array = stroka.Split(' ');

string[] array1 = new string[array.Length];
int count = 0;

void FinalArray(string[] array, string[] array1)
{
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array1[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FinalArray(array, array1);
PrintArray(array1);

