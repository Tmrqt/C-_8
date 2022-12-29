int m1 = InputNumbers("Введите кол-во строк первой марицы m1: ");;
int n1 = InputNumbers("Введите кол-во столбцов первой матрицы n1: ");
int m2 = InputNumbers("Введите кол-во строк второй марицы m2: ");
int n2 = InputNumbers("Введите кол-во столбцов второй матрицы n2: ");

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

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
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n2; j++) 
        {
            System.Console.Write(arr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    return arr;
}

int[,] MultiplyArr(int[,] arr1, int[,] arr2)
{
    System.Console.WriteLine();
    int [,] arr = new int[m1,n2];
    if (n1 != m2)
        System.Console.WriteLine("Матрицы перемножить нелзя");
    else
        for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n2; j++) 
        {
            for (int p = 0; p < n1; p++)
            {
                arr[i,j] += arr1[i, p] * arr2[p, j];
            }
        }
    }
    ShowArr(arr);
    return arr;
}

int[,] arr1 = NewArr(m1,n1);
int[,] arr2 = NewArr(m2,n2);
MultiplyArr(arr1, arr2);
