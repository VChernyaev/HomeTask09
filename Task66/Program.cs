// Задайте значение M и N
// напишите программу, которая найдет сумму натуральных чисел в промежутке от M и N

Console.WriteLine("Input tne number M ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number N");
int numN = Convert.ToInt32(Console.ReadLine());


void SumNumbers (int firstNumber, int secondNumber, int sum)
{
    if(firstNumber>secondNumber)
    {
        Console.WriteLine($"Сумма цифр в промежутке от M до N равна {sum}");
        return;
    }
    sum = sum + (firstNumber++);
    SumNumbers(firstNumber,secondNumber,sum);
}
SumNumbers(numM,numN,0);