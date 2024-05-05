// a jagged array, also known as a ragged array or irregular array, 
// is a multi-dimensional array where the member arrays can have different lengths. 

class JaggedArray
{
    public static void Main()
    {
        // Declare a jagged array to store test scores for 3 students (rows)
        int[][] testScores = new int[3][];

        // Initialize each row (testScores) separately
        testScores[0] = new int[] { 67, 87, 23 };
        testScores[1] = new int[] { 55, 76 };
        testScores[2] = new int[] { 76, 87, 45, 66 };

        // access and display scores
        Console.WriteLine("Test Scores:");
        for (int i = 0; i < testScores.GetLength(0); i++)
        {
            for (int j = 0; j < testScores[i].Length; j++)
            {
                Console.Write(" " + testScores[i][j]);
            }
            Console.WriteLine();
        }

    }
}