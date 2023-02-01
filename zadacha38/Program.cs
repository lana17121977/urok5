// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double [] numbers)
{
    for (int i=0; i<numbers.Length; i++)
        numbers[i] = Convert.ToDouble(new Random().Next(10,100))/10;
}

void PrintArray(double [] numbers)
{

    Console.Write("[ ");
    for (int i=0; i<numbers.Length; i++)
        Console.Write($" {numbers [i]} ");
    Console.Write($"]");
    Console.WriteLine(); 
}

double [] numbers = new double[5];
FillArray(numbers);
PrintArray(numbers);

    
double min = numbers[0];    
double max = min;
      
for (int i=0; i<numbers.Length; i++)
{    
    if (numbers[i] > max)
    {
        max = numbers[i];  
    }       
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
    
}
 
Console.WriteLine($"Максимальное значение {max} , минимальное значение {min} ");
Console.WriteLine($"разница между максимальным и минимальным значением элементов массива равна {max - min}");


