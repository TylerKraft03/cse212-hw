public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // 1) Create an output array of the requested length.
        // 2) Fill each index i with (i+1) * number (because first multiple is number itself).
        // 3) Return the array.
        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
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
        // 1) Determine effective rotation by amount % count (but amount guaranteed 1..count inclusive).
        // 2) Copy last 'amount' values to temporary list.
        // 3) Shift original values right by amount using insertion from end.
        // 4) Write temp values into first positions.
        int count = data.Count;
        if (count <= 1 || amount % count == 0)
        {
            return;
        }

        int rotate = amount % count;
        List<int> tail = new List<int>(count);
        for (int i = count - rotate; i < count; i++)
        {
            tail.Add(data[i]);
        }

        for (int i = count - 1; i >= rotate; i--)
        {
            data[i] = data[i - rotate];
        }

        for (int i = 0; i < rotate; i++)
        {
            data[i] = tail[i];
        }
    }
}
