// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// 1. Сформировать трехмерный массив из двухзначных чисел;
// 2. Разбить массив на строки;
// 3. Узнать индекс каждого элемента массива;
// 4. Вывести массив построчно с индексами.

int[,,] Get3DArray(int row, int column, int hight, int minValue, int maxValue)
{
    int[,,] matrix = new int[row, column, hight];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            for(int k = 0; k < hight; k++)
            {
                matrix[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return matrix; 
}

void PrintArray(int[,,] inArray) // Вывод массива на консоль
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int colunm = 0; colunm < inArray.GetLength(1); colunm++)
        {
            for(int hight = 0; hight < inArray.GetLength(2); hight++ )
            {
                Console.Write($"{inArray[row, colunm, hight]}\t ");
            }    
        }
        Console.WriteLine();
    }
}

void LineBraiking(int[,,] matrix)
{
    int rowSize = matrix.GetLength(0);
    int[] resultMatrix = new int[rowSize];
    for(int row =0; row < rowSize; row++ )
    {
        for(int hight = 0; hight < matrix.GetLength(2); hight++)
        {
            for(int column = 0; column < matrix.GetLength(1); column++)
            {
                resultMatrix[row] = matrix[row, column, hight];
                Console.WriteLine($"{resultMatrix[row]}{(row, column, hight)}");
            }
        }
    }
}

void Main()
{
    int[,,] ourMatrix = Get3DArray(3, 4, 5, 10, 99);
    PrintArray(ourMatrix);
    Console.WriteLine();
    LineBraiking(ourMatrix);
}

Main();