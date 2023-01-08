/* Example1. Вывели пустые строки и столбцы:

//      наименование    строка,столбец 
string[,] table = new string[2, 5];//двумерный массив-[,]
// String.Empty - строка пустая
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)// row ряды, а 2 это кл-во строк
{
    for(int columns = 0; columns < 5; columns++)//columns столбцы
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}


// Examle2. Вводим значения в строки и столбцы
int[,] matrix = new int[3, 4];
for //(int i = 0; i < 3; i++)
     (int i = 0; i < matrix.GetLength(0); i++);
{
    for //(int j = 0; j < 4; j++)
     (int j = 0; j < matrix.GetLength(1); j++);
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}


// Example3. С помощью метода выводим матрицу и заполняем числами

void PrintArray(int[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++);
    {
        for (int j = 0; j < matr.GetLength(1); j++);
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++);
    {
        for (int j = 0; j < matr.GetLength(1); j++);
        {
             matr[i, j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/