Console.WriteLine("Введите размерность прямоугольного 2мерного массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] NewArr (int n)
{
    int[,] arr = new int[n,n];
    Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++) 
        {
            arr[i,j] = rand.Next(0, 10);
            System.Console.Write(arr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    return arr;
}

void MinSumLineNumber(int[,] arr)
{
    int LineNumber = 1;
    int SumLine = 0;
    int MinSumLine = 0;
    for (int p = 0; p < n; p++)
    {
        MinSumLine = MinSumLine + arr[0,p];
    }
    //System.Console.WriteLine(MinSumLine);
    for (int i = 1; i < n; i++)
    {
        SumLine = 0;
        for (int j = 0; j < n; j++) 
        {
            SumLine = SumLine + arr[i,j];
        }
        if (SumLine < MinSumLine)
        {
            MinSumLine = SumLine;
            LineNumber = i+1;
        }      
        //System.Console.WriteLine();
        //System.Console.WriteLine(SumLine);
    }
    //System.Console.WriteLine(MinSumLine);
    System.Console.WriteLine(LineNumber);
}

int[,] arr = NewArr(n);
MinSumLineNumber(arr);