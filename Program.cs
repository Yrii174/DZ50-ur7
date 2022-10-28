/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.WriteLine("введите индекс строки: "); 
int strin = int.Parse(Console.ReadLine()); 
Console.WriteLine("введите индекс столбца: "); 
int colon = int.Parse(Console.ReadLine());
int m=6;
int n=10;    

int[,] CreatArray(int m, int n) 
{     int[,] array1 = new int[m, n];     
if (strin < array1.GetLength(0) && colon < array1.GetLength(1)) 
    {Console.WriteLine($"позиция элемента ({strin} , {colon}) входит в границы массива");}
    else Console.WriteLine($"{strin}{colon} индекс выходит за пределы массива");
Random rnd = new Random();     
for (int i = 0; i < array1.GetLength(0); i++)     
    {        for (int j = 0; j < array1.GetLength(1); j++)         
             {      array1[i, j] = rnd.Next(1, 10);         
             }     
    }     return array1; 
}
void PrintArray(int[,] array) 
{     for (int i = 0; i < array.GetLength(0); i++)     
        {         for (int j = 0; j < array.GetLength(1); j++)         
{            Console.Write($"{array[i,j]} ");         
}        Console.WriteLine();     
        }       
System.Console.WriteLine($"значение элемента составляет: {array[(strin=strin-1), (colon=colon-1)]}");
} 
PrintArray(CreatArray(m, n));
