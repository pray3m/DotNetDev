// Rectangular arrays, also known as regular arrays, are multi-dimensional arrays
// where all rows have the same number of columns. 
// This creates a uniform, grid-like structure for data storage.

class RectangularArray
{
    public static void Main()
    {
        // rectangular array to store student grades(rows) for different subjects(columns)
        int[,] grades = new int[3, 2];

        // sample grades
        grades[0, 0] = 60; // Student 1 ,Math grade
        grades[0, 1] = 70;
        grades[1, 0] = 76;
        grades[1, 1] = 88;
        grades[2, 0] = 77;
        grades[2, 1] = 67;

        // display grades
        Console.WriteLine("Obtained grades: ");
        double averageGrade = 0;
        
        for (int i = 0; i < grades.GetLength(0); i++)
        {
            double studentTotal = 0;
            for (int j = 0; j < grades.GetLength(1); j++)
            {
                studentTotal += grades[i, j];
                Console.Write($" {grades[i, j]} ");
            }
            Console.WriteLine(" Total :" + studentTotal);
            Console.WriteLine("");
        }
    }
}