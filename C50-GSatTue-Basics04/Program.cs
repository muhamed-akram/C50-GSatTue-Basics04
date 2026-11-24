using System.Diagnostics;
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
        #region Question 8
        //Write a method ReplaceArray(ref double[] prices)
        //that replaces prices entirely with a 
       // new array { 10.0, 12.5, 15.0 }.
       // Call it with your prices array and print prices.Length
       //afterward.

        public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        #endregion
        #region Question 9
        //Write a method bool TryGetPrice(string title, out double price)
        //that returns true and sets 
        //price to 25.5 if title is "Clean Code",
        //otherwise returns false and sets price to 0.Call it
        public static bool TryGetPrice(string title, out double price)
        {
            if(title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }

        }
        #endregion
        #region Question 10
        //Write a method PrintBookInfo(string title, int pages = 300)
        //where pages is optional. Call 
        //it once with only a title, and once passing both a title and pages.

        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title is : {title}\nPages are : { pages}");
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
                                  //type and passed a copy of it's refrence. 
            Console.WriteLine($"price after discount: {prices[0]}");

            int pages2 = 400;
            AddBonusPagesByRef(ref pages2);//passing by ref here make change
                                           //in original variable
            Console.WriteLine($"pages after passing by ref : {pages2}");//450

            ReplaceArray(ref prices);//Q8, prices length in line 110 was 2
            Console.WriteLine($"prices length: {prices.Length}");//here is 3

            double price;//Q9
            TryGetPrice("Clean Code" ,out price);//Q9
            Console.WriteLine(price);//Q9

            PrintBookInfo("How to Program");//Q10
            PrintBookInfo("java for Beginners", 500);
            #region Question 11
            /*Using the PrintBookInfo method from the question above, 
             * call it by naming the 
             parameters, passing pages before title.*/
            PrintBookInfo(pages: 1024, title: "OS Concepts");//Q11
            #endregion
        }
    }
}
