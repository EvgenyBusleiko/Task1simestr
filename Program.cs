// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string [] CreateArray (int size)
{
    string [] array =new string [size];
    for (int i = 0; i < size; i++)
        {
        Console.Write($"Введите {i} элемент массива строк: ");
        array [i] = Console.ReadLine();
    
        }
    return array;
}

void PrintArray (string [] array)
{   
     Console.Write ("[");
    for (int i = 0; i < array.GetLength(0) ; i++)
        {
        if (i<array.GetLength(0)-1) Console.Write ($"{array [i]}, ");
        else Console.WriteLine ($"{array [i]}]");
    
        }
}

string [] ChangeArray (string [] array)
{
    int count=0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
        
        if (array [i].Length<3) count++;
    
        }
    int newCount=0;
    string [] newArray =new string [count];
    for (int i = 0; i < array.GetLength(0); i++)
        {
        
        if (array [i].Length<3) 
            {
                newArray[newCount]=array[i];
                newCount++;
            }
        }

    return newArray;
}



int Check (string textToPrint)
{
    int checkImput=-1;
    do
    {   
        Console.Write($"Введите {textToPrint}: ");
        checkImput = Convert.ToInt32(Console.ReadLine());
        if (checkImput<0) Console.WriteLine("Ошибка: Число должно быть положительным! Если хотите выйти введите, пожалуйста '0'");
        else if (checkImput==0) return checkImput=0;
    
    }
    while (checkImput<0);
    return checkImput;

}

Console.WriteLine("Программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.");

int qual=Check ("количество строк массива");

string [] stringArray=CreateArray(qual);

Console.WriteLine("Исходный массив");

PrintArray (stringArray);

string [] finalArray=ChangeArray (stringArray);

Console.WriteLine ();

Console.WriteLine("Переработанный массив");

if (finalArray.Length==0) Console.Write("В исходном массиве все элементы больше или равны трем знакам, поэтому переработанный массив пуст");
else PrintArray (finalArray);

