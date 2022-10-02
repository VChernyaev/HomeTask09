// программа вычисления функции Акермана
// даны два неотрицательеых числа

Console.WriteLine("Input tne number M ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number N");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkermanFun(numM,numN));
int AkkermanFun(int m, int n)
{
    if(n==0) return m+1;
    else if ((n!=0)&&(m==0)) return AkkermanFun(n-1,1);
    else return AkkermanFun(n-1, AkkermanFun(n, m-1));
}