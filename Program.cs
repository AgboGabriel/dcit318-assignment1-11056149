class program
{
    static int TicketPriceCalculator(int price, int age)
    {

        if (age <= 12)
        {
            price = price - 3;

        }
        else if (age >= 60)
        {
            price = price - 3;
        }
        return price;

        }
    static void Main(String[] args)
    {
        int price = 10;
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        int finalPrice = TicketPriceCalculator(price, age);
        Console.WriteLine("The final ticket price is: " + finalPrice);
    }
}