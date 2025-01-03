using System;


class CmplxTest
{
    static void Main(string[] args)
    {
        var cx = Complex.GetInstance(1, 2);
        var cx2 = Complex.GetInstance();
        var cx4 = cx + cx2;
        Console.WriteLine($"{cx} - {cx2} => {cx + cx2}");
        var cx3 = Complex.GetInstance(2, 5);
        Console.WriteLine($"{cx2} - {cx3} => {cx2 + cx3}, => {cx3 + cx4}");
        //////
        int[,] arr = { { 4, 8 }, { 1, 3 }, { 16, 32 } };
        Print2DArray(arr);
        int[][] arrJagged = { new int[] { 5, 9 },
                              new int[] { 1, 6, 21 },
                              new int[] { 90 },
                              new int[] { 1, 3, 6, 2 } };
        Print2DJagged(arrJagged);
    }

    static void Print2DJagged(int[][] arr)
    {
        foreach (var row in arr)
        {
            foreach (var elem in row)
            {
                Console.Write($"{elem,5} ");
            }
            Console.WriteLine();
        }
    }

    static void Print2DArray(int[,] arr)
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.WriteLine(arr[row, col]);
            }
        }
    }
}

class Complex
{
    private int real;
    private int img;
    private Complex(int real, int img)
    {
        Real = real;
        Img = img;
    }

    public int Real { get => real; set { real = value; } }
    public int Img { get => img; set { img = value; } }

    public static Complex GetInstance(int real, int img) => new Complex(real, img);
    public static Complex GetInstance() => new Complex(1, 0);

    public static Complex operator +(Complex cmplx1, Complex cmplx2) =>
        new Complex(cmplx1.real + cmplx2.real, cmplx1.img + cmplx2.img);

    public static Complex operator -(Complex cmplx1, Complex cmplx2) =>
        new Complex(cmplx1.real - cmplx2.real, cmplx1.img - cmplx2.img);

    public override string ToString() => $"Complex(Real: {real}, Imag: {img}i)";
}
