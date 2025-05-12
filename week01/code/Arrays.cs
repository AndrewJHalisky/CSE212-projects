using System.ComponentModel;
using System.Globalization;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    ///
    /// My plan for this project is to implement the MultiplesOf function by return a list of multiples and how many you can get in a set.
    
    public static void Run(string[] args) {
        List<int> data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(data, 3);
        Console.WriteLine(string.Join(", ", data));
    }
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // First, I will create a list of integers that repeat themselves
        List<double> multiples = new List<double>();
        // Then, I will create a for loop to implement
            for (int i = 1; i <= length; i++) {
                multiples.Add(i * number);
            }
        // Next I will return the multiples (integers) that were implemented
        return multiples.ToArray(); // replace this return statement with your own
    }
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // For this function, first I will call an integer for the list of chunks
        List<List<int>> chunks = new List<List<int>>();
        for (int i = 0; i < data.Count; i += 3) {
            // Then I will call an int variable to get the data count and implement it through there.
            int count = Math.Min(3, data.Count - i);
            // Next I will add the chunks to the name of the list
            List<int> chunk = data.GetRange(i, count);
            chunks.Add(chunk);
        }
    }
}