using IEnumerables.Logic;

#region 33-Matrix multiplication
Console.WriteLine("****Matrix Multiplication****");

Console.Write("Please Enter The Value Of M:");
var m = int.Parse(Console.ReadLine()!);

Console.Write("Please Enter The Value Of N:");
var n = int.Parse(Console.ReadLine()!);

Console.Write("Please Enter The Value Of P:");
var p = int.Parse(Console.ReadLine()!);

List<List<int>> matrixA = new List<List<int>>();
MatrixMultiplication.MakeMatrixA(matrixA, m, n);
Console.WriteLine("--- A ---");
Console.Write(Matrixmultiplication.ShowMatrix(matrixA, m, n));

List<List<int>> matrixB = new List<List<int>>();
Matrixmultiplication.MakeMatrixB(matrixB, n, p);
Console.WriteLine("--- B ---");
Console.Write(Matrixmultiplication.ShowMatrix(matrixB, n, p));

List<List<int>> matrixC = Matrixmultiplication.MatrixMultiplication(matrixA, matrixB);
Console.WriteLine("--- C ---");
Console.Write(Matrixmultiplication.ShowMatrix(matrixC, m, p));
Console.WriteLine();
#endregion*/

#region 34-HourGlass
Console.WriteLine("        ****Sand Clock****");
Console.Write("Enter The Order Of The Matrix: ");
int order = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] matrix = new int[n, n];
int[,] hourglassmatrix = new int[n, n];
Console.WriteLine("Complete Matrix");
Console.WriteLine();
HourGlass.GenerateMatrix(matrix, n);
var MMC = HourGlass.ShowMatrix(matrix, n);
Console.WriteLine(MMC);

Console.WriteLine();
Console.WriteLine("HourGlass");
Console.WriteLine();
HourGlass.GenerateOtherMatrix(matrix, hourglassmatrix, n);
var MOM = HourGlass.ShowOtherMatrix(hourglassmatrix, n);
Console.WriteLine(MOM);
#endregion*/

#region 35-Descompotition Into Factors
Console.WriteLine("   ****Descompotition Into Factors****");
Console.WriteLine();
Console.Write("Type The Number That You Want To Be Decomposed: ");
int number = int.Parse(Console.ReadLine());

List<int> factors = DescompotitionIntoFactors.GetPrimeFactors(number);

Console.Write("Prime Factors of "+ number +" : ");
foreach (int factor in factors) 
{
    Console.Write(factor +" ");
}
Console.WriteLine();

#endregion*/

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

/*#region 37-Horses In Conflict
Console.WriteLine("****Horses In Conflict****");
#endregion*/