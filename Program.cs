Console.Clear();
Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = -1 * N;
while (i <= N)
{
    //форматирование строк
    Console.Write($"{i} ");
    i ++;
}