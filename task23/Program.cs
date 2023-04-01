/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    tableCube(number);
}
else
    Console.WriteLine($"Введено некорректное число");

void tableCube(int num)
{
    int i = 1;
    while (i <= num)
    {
        double Cube = Math.Pow(i,3);

        Console.WriteLine($"{i,3} ->  {i * i * i,3}");
        i++;
    }

}

/* Line();

int Read(string argument)
{
int number;
System.Console.WriteLine($"inpup {argument}: ");
while((!int.TryParse(Console.ReadLine(), out number)) || number < 0)
{
System.Console.WriteLine("Not a number");
}
return number;
}

void Line()
{
int N = Read("N");
for(int i = 1; i <= N; i++)
{
double Cube = Math.Pow(i,3);
System.Console.Write($" {Cube};");
}
} */