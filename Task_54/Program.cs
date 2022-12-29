Console.WriteLine("Введите кол-во строк массив m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массив n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] NewArr (int m, int n)
{
    int[,] arr = new int[m,n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
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

int[,] ShowArr (int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) 
        {
            System.Console.Write(arr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    return arr;
}

int[,] Streamline (int[,] arr)
{
    System.Console.WriteLine();
    int max = 0;
    for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {   
                for (int p = 0; p < n-1; p++)
                {
                    if (arr[i,p] < arr[i,p+1])
                    {
                        max = arr[i,p+1];
                        arr[i,p+1] = arr[i,p];
                        arr[i,p] = max;
                    }
                }
            } 
        }
ShowArr(arr);
return arr;  
}

int[,] arr = NewArr(m,n);
Streamline(arr);