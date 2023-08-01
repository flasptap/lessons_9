int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintEvenNumbers(int n, int m)
{
    n += n % 2;
    if (n > m)
    {
       return;
    }
    System.Console.WriteLine(n);
    PrintEvenNumbers(n + 2, m);
}

int m = ReadInt("M  ");
int n = ReadInt("N  ");
PrintEvenNumbers(m, n);

