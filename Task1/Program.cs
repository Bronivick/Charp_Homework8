Console.Clear();
Console.WriteLine("первая размерность массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("вторая размерность массива");
int colomns = Convert.ToInt32(Console.ReadLine());

int[,] matrixBeforeSort = new int[rows, colomns];
int[,] matrixAfterSort = new int[rows, colomns];
int[] sort = new int[colomns];


int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            array[i, m] = new Random().Next(0, 10);
        }

    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            Console.Write(array[i, m] + " ");
        }
        Console.WriteLine();
    }
}



int[,] ChangeArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int m = 0; m < array.GetLength(1); m++)    
            sort[m] = array[i, m];
        Array.Sort(sort);
        Array.Reverse(sort);
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = sort[j];
    }
    return array;
}

PrintArray(FillArray(matrixBeforeSort));
matrixAfterSort = matrixBeforeSort;
Console.WriteLine("----------------------");
PrintArray(ChangeArray(matrixAfterSort));