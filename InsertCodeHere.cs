

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            int noOfBooksInOrder = 8;
            int noOfDVDsInOrder = 3;
            int noOfGamesInOrder = 2;

            double totalBookPrice = (noOfBooksInOrder * netPriceBook); // Total price books
            double totalDVDPrice = (noOfDVDsInOrder * netPriceDVD); // Total price DVD
            double totalGamePrice = (noOfGamesInOrder * netPriceGame); // Total price games
            
            double tax = 1.1; // 10%
            double netPricePlusTax = (totalBookPrice + totalDVDPrice + totalGamePrice) * tax;
            int shippingCosts = 49;
            double creditcardFee = 1.02; // 2%

            double totalPrice = (netPricePlusTax + shippingCosts) * creditcardFee; // This variable should contain the total price for the order

            System.Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            System.Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");

            // The LAST line of code should be ABOVE this line
        }
    }
}
