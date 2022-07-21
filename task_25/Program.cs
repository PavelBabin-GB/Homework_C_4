// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
int result = 1;
int EnterDegree(int alocal, int bLocal)
{
    for (int i = 1; i <= bLocal; i++) 
    {
        result = result * alocal;
    }    
    return result;
}
Console.WriteLine("Ответ = " + (EnterDegree(a, b)));