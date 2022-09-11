System.Console.Write("Напишите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Напишите любую степень: ");
int degree = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < degree; i++)
{
    result = number * result;
}
System.Console.WriteLine(result);