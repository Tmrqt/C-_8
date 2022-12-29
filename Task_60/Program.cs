Console.WriteLine("Введите размеры массива через пробел: ");
string[] nums = Console.ReadLine().Split();

int[,,] NewArr(int[] sizes, int min, int max)
{
    int[,,] arr = new int[sizes[0], sizes[1], sizes[2]];
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int p = 0; p < arr.GetLength(2); p++)
            {
                arr[i,j,p] = rand.Next(min, max);
            }
        }
    }
    return arr;
}

int[,,] ShowArr (int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int p = 0; p < arr.GetLength(2); p++)
            {
                System.Console.Write(arr[i,j,p] + $"({i},{j},{p})");
            }
            System.Console.WriteLine();
        }
    }
    return arr;
}

int[,,] arr = NewArr(new int[] {int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]),}, 10, 100);
ShowArr(arr);