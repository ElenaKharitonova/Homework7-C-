// Задача 1: 
// Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// void PrintNumberMN(int m, int n)
// {
//     if (n < m)
//     {
//       return;
//     }
//     Console.Write(m + " ");
//     PrintNumberMN(m + 1, n);
// }

// Console.Write("Input the left border of the interval: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the right border of the interval: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Natural numbers in the range MN: ");
// PrintNumberMN(m, n);

// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// bool ValidateNumber(int n, int m) 
// {
//      if (m < 0 || n < 0)
//      {
//           Console.WriteLine("One of the numbers is negative");
//           Console.WriteLine("Input non-negative numbers");
//           return false;
//      }
//      return true;
// }

// int AkkermanRecursion (int m, int n)
// {
//     if (m == 0) 
//         {
//             return n + 1;
//         }
//     if (m > 0 && n == 0) 
//     {
//         return AkkermanRecursion(m - 1, 1);
//     }
//     if (m > 0 && n > 0) 
//     {
//         return AkkermanRecursion(m - 1, AkkermanRecursion(m, n - 1));
//     }
//     return AkkermanRecursion(m, n);
// }

// Console.WriteLine("Input two non-negative numbers");
// Console.Write("Input first number (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number (n): ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (ValidateNumber(n, m))
// {
// Console.WriteLine($"Function Akkerman for {m} и {n} = {AkkermanRecursion(m, n)}");
// }

// Задача 3: 
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}


static int[] ArrayReversRecursivo(int[] array, int start, int finish)
{
    if (start >= finish)
    {
        return array;
    }

    int temp = array[start];
    array[start] = array[finish];
    array[finish] = temp;

    return ArrayReversRecursivo(array, start + 1, finish - 1);
}

static int[] arrayRevers(int[] array)
{
    return ArrayReversRecursivo(array, 0, array.Length - 1);
}

int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
Console.Write("The source array: ");
PrintArray(array);
Console.Write("Reverse array: ");
PrintArray(arrayRevers(array));
