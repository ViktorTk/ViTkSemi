Console.Clear();
Console.WriteLine("Введите целое число");
int N= int.Parse(Console.ReadLine());
int B=-N;
while (B<=N)
{
    Console.Write($"{B} ");
    B++;

}