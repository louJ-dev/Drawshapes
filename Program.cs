using System;
using Reviewer;

public class Program{
    static void Main(){
        int size = 7;
        Shapes.DrawLine(size);
		Console.WriteLine();
        Shapes.DrawStripedLine(size);
		Console.WriteLine();
        Shapes.DrawSquare(size);
		Console.WriteLine();
        Shapes.DrawParallelogram(size);
		Console.WriteLine();
        Shapes.DrawTriangle(size);
		Console.WriteLine();
        Shapes.DrawReverseTriangle(size);
		Console.WriteLine();
        Shapes.DrawIsocelesTriangle(size);
		Console.WriteLine();
        Shapes.DrawReverseIsocelesTriangle(size);
		Console.WriteLine();
        Shapes.DrawHourglass(size);
		Console.WriteLine();
        Shapes.DrawDiamond(size);
		Console.WriteLine();
        Shapes.DrawZero(size);
		Console.WriteLine();
		Shapes.DrawArrowUp(size);
		Console.WriteLine();
		Shapes.DrawArrowDown(size);
		Console.WriteLine();
		Shapes.DrawX(size);
		Console.WriteLine();
		Shapes.DrawBowTie(size);
    }
}
