// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];

void FillArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        System.Console.Write($"Введите элемент массива № {i+1}: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
}

void PrintArray(int[] massiv)
{
    Console.Write("[");
    for (int i = 0; i < massiv.Length; i++)
    {
        if (i == massiv.Length - 1)
        {
          Console.Write(massiv[i]);
        }
        else {
            Console.Write(massiv[i]);
            Console.Write(", ");  
        }
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);
