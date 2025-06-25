Console.WriteLine("Lection 17/01");

static int GetMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++) // O(n)
        if (numbers[i] > max)
            max = numbers[i];

    return max;
}

static int GetMaxSum(int[][] numbers)
{
    int sum = 0;

    for(int i = 0; i < numbers.Length;i++)
        sum += GetMax(numbers[i]);         //O(n^2)
    
    return sum;
}

static int GetSum(int[] numbers)
{
    int sum = 0;                             //O(1)

    for (int i = 0; i < numbers.Length; i++) //O(n)
        sum += numbers[i];                   //O(1)

    return sum;                              //O(1)
}
//O(n*(1+1+1)) = O(n)


static int GetSum2D(int[,] numbers)
{
    int sum = 0;                                        //O(1)

    for (int i = 0; i < numbers.GetLength(0); i++)      //O(n)
        for (int j = 0; j < numbers.GetLength(1); j++)  //O(n)
            sum += numbers[i, j];                       //0(1)

    return sum;                                         //0(1)
}
//O(n*n*(1+1+1)) = O(n^2)


static int GetElement(int[] numbers, int index)
{
    return numbers[index]; // O(1)
}

static int GetElement2(int[] numbers, int index)
{
    int element = numbers[index]; // O(1)
    return element;               // O(1)
}
// O(1+1) = O(2) = O(1)