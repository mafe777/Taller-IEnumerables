using IEnumerables.Logic;

int option;
do
{
    option = Menu();
    switch (option)
    {
        case 1: MatrixesMultiplication(); break;
        case 2: SandGlass(); break;
        case 3: DecompositionByFactors(); break;
        case 4: Harvesting(); break;
        case 5: Conflicts(); break;

        default: break;
    }
} while (option != 0);

void Conflicts()
{
    #region 37-Horses In Conflict
    Console.WriteLine("****Horses In Conflict****");
    Console.WriteLine();
    #endregion*/ 
}

void Harvesting()
{
    #region 36-Harvesting On Horseback
    Console.WriteLine("****Harvesting On Horseback****");
    Console.WriteLine();
    Console.Write("Please Enter The location of the fruits: ");
    string fruits = Console.ReadLine()!;
    Console.WriteLine();

    Console.Write("Enter The Initial Position Of The Horse: ");
    string PositionHorse = Console.ReadLine()!;
    Console.WriteLine();

    Console.Write("Enter the Movements That The Horse Will Make: ");
    string movements = Console.ReadLine()!;
    Console.WriteLine();

    HarvestingOnHorseback harvest = new HarvestingOnHorseback(fruits, PositionHorse);
    string collectedFruits = harvest.CollectedFruits(movements);

    Console.WriteLine($"The fruits collected Were: {collectedFruits}");
    #endregion*/

}

void DecompositionByFactors()
{
    #region 35-Descompotition Into Factors
    Console.WriteLine("   ****Descompotition Into Factors****");
    Console.WriteLine();
    Console.Write("Type The Number That You Want To Be Decomposed: ");
    int number = int.Parse(Console.ReadLine()!);

    List<int> factors = DescompotitionIntoFactors.GetPrimeFactors(number);

    Console.Write("Prime Factors of " + number + " : ");
    foreach (int factor in factors)
    {
        Console.Write(factor + " ");
    }
    Console.WriteLine();

    #endregion*/
}

void SandGlass()
{
    #region 34-HourGlass
    Console.WriteLine("        ****HourGlass****");
    Console.WriteLine();
    Console.Write("Enter The Order Of The Matrix: ");
    int order = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    int[,] matrix = new int[order, order];
    int[,] hourglassmatrix = new int[order, order];
    Console.WriteLine("Complete Matrix");
    Console.WriteLine();
    HourGlass.GenerateMatrix(matrix, order);
    var MMC = HourGlass.ShowMatrix(matrix, order);
    Console.WriteLine(MMC);

    Console.WriteLine();
    Console.WriteLine("HourGlass");
    Console.WriteLine();
    HourGlass.GenerateOtherMatrix(matrix, hourglassmatrix, order);
    var MOM = HourGlass.ShowOtherMatrix(hourglassmatrix, order);
    Console.WriteLine(MOM);
    #endregion*/
}

void MatrixesMultiplication()
{
    #region 33-Matrix multiplication
    Console.WriteLine("****Matrix Multiplication****");
    Console.WriteLine();

    Console.Write("Please Enter The Value Of M:");
    var m = int.Parse(Console.ReadLine()!);

    Console.Write("Please Enter The Value Of N:");
    var n = int.Parse(Console.ReadLine()!);

    Console.Write("Please Enter The Value Of P:");
    var p = int.Parse(Console.ReadLine()!);

    List<List<int>> matrixA = new List<List<int>>();
    MatrixMultiplication.MakeMatrixA(matrixA, m, n);
    Console.WriteLine("--- A ---");
    Console.Write(MatrixMultiplication.ShowMatrix(matrixA, m, n));

    List<List<int>> matrixB = new List<List<int>>();
    MatrixMultiplication.MakeMatrixB(matrixB, n, p);
    Console.WriteLine("--- B ---");
    Console.Write(MatrixMultiplication.ShowMatrix(matrixB, n, p));

    List<List<int>> matrixC = MatrixMultiplication.Multiplication(matrixA, matrixB);
    Console.WriteLine("--- C ---");
    Console.Write(MatrixMultiplication.ShowMatrix(matrixC, m, p));
    Console.WriteLine();
    #endregion*/
}


int Menu()
{
    Console.WriteLine("   *-- IEnumerables Workshop--*   ");
    Console.WriteLine();
    Console.WriteLine("   1. Matrix Mukltiplication");
    Console.WriteLine("   2. HourGlass");
    Console.WriteLine("   3. Descompotition Into Factors");
    Console.WriteLine("   4. Harvesting On Horseback");
    Console.WriteLine("   5. Horses In Conflict");
    Console.WriteLine("   0. Exit");
    Console.Write("    Choose The Option:  ");
    Console.WriteLine();
    var option = Console.ReadLine();
    return Convert.ToInt32(option);
}