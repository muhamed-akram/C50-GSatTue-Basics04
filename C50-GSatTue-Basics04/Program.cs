using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C50_GSatTue_Basics04
{
    internal class Program
    {
        #region Question 3
         //Write a method called PrintWelcomeMessage that takes no parameters and prints 
        //"Welcome to the Library!". Call it from Main.
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcom to the Library");
        }

        #endregion
        #region Question 4
        //Write a method PrintBookTitle(string title) that prints
        //"Book title: " + title. Call it with 
        //"Clean Code".

        public static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book Title is : {title}");
        }
        #endregion
        #region Question 5
        //Write a method AddBonusPages(int pages) that adds 50 to pages.
        //Call it with a variable 
        //int pages = 400; and print pages afterward.What do you expect to see, and why?
        
        public static void AddBonusPages(int pages)
        {
            pages += 50;
            Console.WriteLine($"pages inside method:{pages}");
        }
        #endregion
        #region Question 6
        //Write a method ApplyDiscount(double[] prices) t
        //hat subtracts 5 from prices[0]. Call it 
        //with double[] prices = { 25.5, 40.0 };
        //and print prices[0] afterward.What do you expect to
        //see, and why?
         public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        #endregion
        #region Question 7
        //Rewrite the method from question 5 as
        //AddBonusPagesByRef(ref int pages) using ref. 
       // Call it and print pages afterward.How is the result different from question 5?
        
        public static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
            Console.WriteLine($"Pages inside method: {pages}");
        }
        #endregion

        static void Main(string[] args)
        {
            #region Question 1
            //Create a one-dimensional array double[] prices\
            //with the values 25.5, 40.0, 33.75. Print 
            //the second price(index 1).

            //double[] array = { 25.5, 40.0, 33.75 };
            //Console.WriteLine($"Second price is: {array[1]}");
            #endregion
            #region Question 2
            //Create a 2x2 multidimensional array int[,] shelfCopies where
            //shelf 0 has 3, 5 copies and 
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.

            //int[,] ShelfCopies = { { 3,5 }, 
            //                       { 1, 4 } };
            //for(int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        if (i == 1 && j == 0)
            //        {
            //            Console.WriteLine(ShelfCopies[i, j]);
            //            break;
            //        }
            //    }
            //}
            #endregion

            PrintWelcomeMessage();//Q3
            PrintBookTitle("Clean Code");//Q4

            int pages = 400;//pages here will never change as it was passed by value
            AddBonusPages(pages);//here pages are copy so any change not affect on origrinal value
            Console.WriteLine($"after method: {pages}");//400

            double[] prices = { 25.5, 40.0 };//Q6
            ApplyDiscount(prices);//prices[0] will decrease as array is refrence
                                  //type and passed by refrence not copy 
            Console.WriteLine($"price after discount: {prices[0]}");

            int pages2 = 400;
            AddBonusPagesByRef(ref pages2);//passing by ref here make change
                                           //in original variable
            Console.WriteLine($"pages after passing by ref : {pages2}");//450

        }
    }
}
