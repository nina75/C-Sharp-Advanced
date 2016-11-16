namespace MatrixClass
{
    using System;

    public class Test
    {
        static void Main()
        {
            Matrix m1 = new Matrix(2,3);
            m1[0, 0] = 2;
            m1[0, 1] = 3;
            m1[0, 2] = 3;
            m1[1, 0] = 1;
            m1[1, 1] = 4;
            m1[1, 2] = 1;

            Matrix m2 = new Matrix(3, 4);
            m2[0, 0] = 1;
            m2[0, 1] = 2;
            m2[0, 2] = 1;
            m2[0, 3] = 3;
            m2[1, 0] = 5;
            m2[1, 1] = 1;
            m2[1, 2] = 3;
            m2[1, 3] = 1;
            m2[2, 0] = 2;
            m2[2, 1] = 2;
            m2[2, 2] = 1;
            m2[2, 3] = 3;

            Console.WriteLine(m1);
            Console.WriteLine("-------------------");
        }
    }
}
