namespace C50_GSatTue_Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Create a one-dimensional array double[] prices\
            //with the values 25.5, 40.0, 33.75. Print 
            //the second price(index 1).

            double[] array = { 25.5, 40.0, 33.75 };
            Console.WriteLine($"Second price is: {array[1]}");
            #endregion
        }
    }
}
