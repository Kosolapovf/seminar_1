Console.Clear();
Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
//деление и вывод остатка, i будет выводить остаток
int i = N % 10;
Console.Write(i);