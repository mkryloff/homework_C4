int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 1000);
}
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + "; ");
}