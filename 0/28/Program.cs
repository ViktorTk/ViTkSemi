//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

/*   мое решение
int GetPr(int n)
{
    int pr = 1;
    for (int i = 1; i <= n; i++)
        pr *= i;
    return pr;
}



Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
//GetPr(n);
int result = GetPr(n);
Console.WriteLine($"Произведение от 1 до {n} равно {result}");
*/

// Решение правильное

Console.Clear();
 Console.Write("Введите число: ");
 int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");
// int num1 = 2;
// Console.WriteLine($"Произведение цифр = {GetMultiply(num1)}");
// int num2 = 3;
// Console.WriteLine($"Произведение цифр = {GetMultiply(num2)}");
// int num3 = 4;
// Console.WriteLine($"Произведение цифр = {GetMultiply(num3)}");

long GetMultiply(long n){ // n=3
    long result = 1;
    long i = 2;
    if( n < 0){
        i = n;
        n = -1;
    }
    for (; i <= n; i++){ // i <= n; 2 <= 3
        result *= i; // result
    }
    return result;
}

