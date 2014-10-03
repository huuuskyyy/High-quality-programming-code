using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(UtilsFiles.GetFileExtension("example"));
            Console.WriteLine(UtilsFiles.GetFileExtension("example.pdf"));
            Console.WriteLine(UtilsFiles.GetFileExtension("example.new.pdf"));

            Console.WriteLine(UtilsFiles.GetFileNameWithoutExtension("example"));
            Console.WriteLine(UtilsFiles.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(UtilsFiles.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                UtilsCalculateDistance.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                UtilsCalculateDistance.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Cube cube = new Cube(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", cube.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", cube.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", cube.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", cube.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", cube.CalcDiagonalYZ());
        }
    }
}
