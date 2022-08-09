namespace Assignment_matrix
{
    internal class Multidimensionalarrayclass
    {
        static void Main(string[] args)
        {
            //Declear a 3 dimensional array
            int[,,] multidimensionalArray1 = new int[2, 2, 3]
            {

                    { { 1, 2, 3 }, { 2, 1, 5 } },
                  { { 1, 2, 3 }, { 2, 1, 5 } }

            };
            //Declear a 3 dimensional array
            int[,,] multidimensionalArray2 = new int[2, 2, 3]
            {
                    { { 1, 2, 3 }, { 2, 1, 5 } },
                  { { 1, 2, 3 }, { 2, 1, 5 } }
            };


            int[,,] multidimensionalArray3 = new int[2, 2, 3];


            for (int i = 0; i < multidimensionalArray1.GetLength(0); i++)
            {
                for (int j = 0; j < multidimensionalArray2.GetLength(1); j++)
                {
                    for (int k = 0; k < multidimensionalArray1.GetLength(2); k++)
                    {
                        multidimensionalArray3[i, j, k] += multidimensionalArray1[i, j, k] * multidimensionalArray2[i, j, k];
                    }
                }
            }

            foreach (int i in multidimensionalArray3)

            {
                Console.WriteLine(i);

            }
        }
    }
}