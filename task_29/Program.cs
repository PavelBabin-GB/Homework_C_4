// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Введите числа: ");
int[] GetNewArrey()
{
    int[] arrey = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arrey[i] = int.Parse(Console.ReadLine());
    }
    return arrey;
}
void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count)
  {
    Console.Write(coll[index]);
    index++;
    if (index < count)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 
PrintArry(GetNewArrey());