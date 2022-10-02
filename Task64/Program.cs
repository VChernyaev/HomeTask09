// задайте значение N
// напишите программу, которая выведет все натуральные числа в промежутке
// от N до 1


Console.WriteLine("Please, input the number ");
int number = Convert.ToInt32(Console.ReadLine());
FindNumber(number);

void FindNumber(int num)
{
    int secondNum = 1;
    while (num > secondNum)
    {
        
        Console.WriteLine($"{secondNum}");
        secondNum++;
    }
    
}