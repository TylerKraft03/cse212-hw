public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var result = new int[select.Length];
        int ia = 0;
        int ib = 0;
        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                result[i] = list1[ia++];
            }
            else
            {
                result[i] = list2[ib++];
            }
        }
        return [];
    }

    /// <summary>
    /// Interleaves elements from two arrays based on a selector array.
    /// 
    /// For each position in the select array:
    /// - If select[i] == 1: take the next element from list1
    /// - If select[i] == 2: take the next element from list2
    /// 
    /// Uses two independent pointers (ia, ib) that advance independently based on selections.
    /// 
    /// Example:
    /// list1 = [1, 2, 3, 4, 5]
    /// list2 = [2, 4, 6, 8, 10]
    /// select = [1, 1, 1, 2, 2, 1, 2, 2, 2, 1]
    /// 
    /// Result: [1, 2, 3, 2, 4, 4, 6, 8, 10, 5]
    /// </summary>
}