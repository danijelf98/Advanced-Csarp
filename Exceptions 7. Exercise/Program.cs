namespace Exceptions_7._Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an applicaton for inserting products
            //Product must have: name, price, quantity, description
            //save in a list
            //check if entered string for name is not empty if it's empty, throw an exception: Product name not entered
            //check if price is entered, if not, throw your own exception: PriceIsNullOrZero
            //check if entered quantity is not less than 1, if yes, throw your own exception: ThereIsNoItemInProducts
            //check if entered descripton is not longer than 50 characters, if yes, throw your own exception: DescriptionIsTooLong
            //DescriptionIsTooLong must have a method and property for calculating the number of characters

            //Save all products in a File.

            Product products = new Product();
            products.GetProducts();
        }
    }
}
