// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int [] array)
{
    for (int i=0; i<array.Length; i++)
        array[i] = new Random().Next(0,100);
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
       
    for (int i=0; i<array.Length; i=i+2)
                    
       if (array[i] > 0) sum+=array[i];
       else sum+=0;
       
Console.WriteLine($" сумма элементов, стоящих на нечётных позициях {sum}");
}
int [] array = new int[5];
FillArray(array);
PrintArray(array);
FindSums(array);