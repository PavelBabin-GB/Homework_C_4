//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int CalculteSum(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}
Console.WriteLine("Сумма цифр в числе: " + CalculteSum(numberN));