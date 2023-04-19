// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}


void filterString(int[,] mass)

{
    int[] massiv1 = new int[mass.GetLength(0)];
    int FrameElement=0;
            for (int i=0 ;i<massiv1.Length; i++)
            {
                for (int j=0;j<mass.GetLength(1);j++)
                    {
                        if(mass[i,j]<1000)
                        FrameElement++;
                    }
            }
            int[] massiv2 = new int [FrameElement];
            for (int i=0, ii=0 ;i<massiv1.Length; i++)
            {
                for (int j=0;j<mass.GetLength(1);j++)
                    {
                        if(mass[i,j]<1000)
                        {
                        massiv2[ii]=mass[i,j];
                        ii++;
                        }
                    }
            }
            foreach(var k in massiv2)
            {
                Console.Write(k+" ");
            }
            Console.WriteLine();

}


Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the bottom line: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the upper bound: ");
int stop = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
filterString(mass);
