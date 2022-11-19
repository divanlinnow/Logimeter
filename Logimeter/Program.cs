class Logimeter
{
    public static void Main(String[] args)
    {
        int[] populations = {
            18897109,
            12828837,
            9661105,
            6371773,
            5965343,
            5926800,
            5582170,
            5564635,
            5268860,
            4552402,
            4335391,
            4296250,
            4224851,
            4192887,
            3439809,
            3279933,
            3095213,
            2812896,
            2783243,
            2710489,
            2543482,
            2356285,
            2226009,
            2149127,
            2142508,
            2134411
        };
        int targetSum = 101000000;

        GetSubsets(populations, targetSum);
        Console.ReadLine();
    }

    /// <summary>
    /// Gets subsets where sum = targetSum
    /// </summary>
    /// <param name="arr">Array of populations</param>
    /// <param name="target">Target sum for subsets</param>
    static void GetSubsets(int[] arr, int target)
    {
        // Calculate the total number of subsets
        int total = (int)Math.Pow(2, arr.Length);

        // Loop through subsets and call "SumSubsets" function
        for (int i = 1; i < total; i++)
            SumSubsets(arr, i, target);
    }

    /// <summary>
    /// Prints all subsets where sum == target
    /// </summary>
    /// <param name="arr">Array of populations</param>
    /// <param name="num">Given num</param>
    /// <param name="target">Target sum for subset</param>
    static void SumSubsets(int[] arr, int num, int target)
    {
        // Create a new array with size equal to arr length to create a binary array 
        int[] set = new int[arr.Length];
        int idx = arr.Length - 1;

        // Convert the array into a binary array
        while (num > 0)
        {
            set[idx] = num % 2;
            num = num / 2;
            idx--;
        }

        int setSum = 0;

        // Calculate the sum of this subset
        for (int i = 0; i < arr.Length; i++)
            if (set[i] == 1)
                setSum = setSum + arr[i];

        // Print subset if sum is equal to target
        if (setSum == target)
        {
            PrintSubset(arr, set);
        }
    }

    /// <summary>
    /// Print subset
    /// </summary>
    /// <param name="arr">Array of populations</param>
    /// <param name="subSet">Given subset</param>
    static void PrintSubset(int[] arr, int[] subSet)
    {
        for (int i = 0; i < arr.Length; i++)
            if (subSet[i] == 1)
            {
                if (i == arr.Length - 1)
                    Console.WriteLine(arr[i]);
                else
                    Console.Write(arr[i] + ", ");
            }
    }
}
