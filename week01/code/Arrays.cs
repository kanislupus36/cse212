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

        //I need to create an array that will hold numbers that are multiples of the starting number. 
        //There also needs to be something that tells the array how long it needs to be.
        //It then need it to be displayed.

        double[] multiples = new double[length];

 
        for (int i = 0; i < length; i++)
        {

            multiples[i] = number * (i + 1);
        }


        return multiples;
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

        //I need a list of numbers and a variable that keeps track of a number that means the amount needed to be rotated.
        //I need to then use that variable to rotate the correct amount on that list so that it is shifted.

        if (data.Count == 0 || amount == 0 || amount % data.Count == 0)
            return;

        int effectiveAmount = amount % data.Count;
        
        int splitIndex = data.Count - effectiveAmount;

        List<int> rightPart = data.GetRange(splitIndex, effectiveAmount);
        List<int> leftPart = data.GetRange(0, splitIndex);

        rightPart.AddRange(leftPart);

        data.Clear();
        data.AddRange(rightPart); 
    }
}
