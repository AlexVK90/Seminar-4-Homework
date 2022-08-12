//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
//3, 5 -> 243 (3⁵)

//2, 4 -> 16

int Degree(int a, int b)

{
    int count = 0;
    int num = 1;
    

    while(count < b )
    {
         num = num * a;
    count++;
    }

return num;
}



Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {a} в степени {b} = { Degree(a,b) }");



//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int Sum(int num)
{
    int result = 0;
    while(num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    
    }
    return result;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа { number } = { Sum(number)}");






//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] CreateArray(int size)
{
   
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
       Console.Write($"введите {i+1} число массива из 8 цифр:  ");
       newArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

int [] array = CreateArray(8);
ShowArray(array);






