int n = 4;

int[,] NewArr (int n)
{
    int[,] arr = new int[n,n];
    int counter = 1;
    for (int itr = 0; itr < 2; itr++)
    {
        for (int j = 0 + itr; j < n - itr; j++) 
        {    
            arr[0+itr,j] = counter;
            counter++;
        }
        counter--;
        for (int i = 0 + itr; i < n - itr; i++)
        { 
            arr[i,n-1-itr] = counter;
            counter++;
        }
        counter--;
        for (int j = n-1-itr; j >= 0 + itr; j--) 
        {    
            arr[n-1 - itr,j] = counter;
            counter++;
        }
        counter--;
        for (int i = n-1-itr; i >= 1 + itr; i--)
        {
            arr[i,0+itr] = counter;
            counter++;
        }
    }
    return arr;
}

int[,] ShowArr (int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++) 
        {
            System.Console.Write(arr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    return arr;
}

int[,] arr = NewArr(n);
ShowArr(arr);