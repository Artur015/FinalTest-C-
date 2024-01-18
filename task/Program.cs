// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


string InputMessage(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string[] ArrayOne() // метод заполнения первоначального массива строками посредством введения пользователем данных с клавиатуры, возвращает одномерный массив строк
{
    int size = Convert.ToInt32(InputMessage("Какое количество строк планируете ввести? "));
    string[] elements = new string[size];

    for (int i = 0; i < size; i++)
    {
        elements[i] = InputMessage($"Введите {i+1}-ю строку и нажмите Enter: ");
    }

    return elements;
}

int FindSizeOfNewArray(string[] array, int limitLength) // метод нахождения количества элементов (строк) первоначального массива, имеющих длину не более 3-х символов 
{
    int sizeNewMassiv = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < limitLength)
        {
            sizeNewMassiv++;
        }
    }
    return sizeNewMassiv;
}

string[] ArrayTwo(string[] array, int size, int limitLength)
{
    string[] newMassiv = new string[size];

    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length < limitLength)
        {
            newMassiv[i] = array[j];
            i++;
        }
            
    }
    return newMassiv;
}

void PrintArray(string[] array) // метод для вывода массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i ++)
    { 
        if(i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}]");
        }
    
    }
}

string[] massiv = ArrayOne();
int maxLength = 4; // количество символов элемента не должно превышать в рассматриваемой задаче
int sizeOfNewMassiv = FindSizeOfNewArray(massiv, maxLength); // размер нового массива
if (sizeOfNewMassiv == 0)
{
    Console.WriteLine();
    Console.WriteLine("Введённые строки содержат более трёх символов.");
}
if (sizeOfNewMassiv != 0)
{
    string[] newMassiv = ArrayTwo(massiv, sizeOfNewMassiv, maxLength); // заполняем новый массив строками, которые содержат не более трёх элементов
    Console.WriteLine();
    PrintArray(newMassiv);
}