// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


void FillArray(int [] array)
{
    for (int i=0; i<array.Length; i++)
        array[i] = new Random().Next(99,1000);
}

void PrintArray(int [] array)
{

    Console.Write("[ ");
    for (int i=0; i<array.Length; i++)
        Console.Write($"{array [i]} ");
    Console.Write($"]"); 
}

void FindSums(int [] array)
{
    int sum =0;
       
    for (int i=0; i<array.Length; i++)
                    
       if (array[i] % 2 == 0) sum+=1;
       else sum+=0;
       
Console.WriteLine($" количество четных чисел в массиве равно {sum}");
}

int [] array = new int[7];
FillArray(array);
PrintArray(array);
FindSums(array);
