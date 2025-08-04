class program
{
    static string TriangleTypeIdentifier(int length, int width, int height)
    {
        if (length == width && width == height)
        {
            return "Equilateral";
        }
        else if (length == width || width == height || length == height)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }

    }
    static void Main(String[] args)
    {
        Console.WriteLine("Enter the Length of the Triangle: ");
        int length=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Width of the Triangle: ");
        int width=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Height of the Triangle: ");
        int height=Convert.ToInt32(Console.ReadLine());
        string triangleType = TriangleTypeIdentifier(length, width, height);
        Console.WriteLine("Triangle type is :" + triangleType);
    }
}