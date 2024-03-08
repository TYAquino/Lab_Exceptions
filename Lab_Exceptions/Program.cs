namespace Lab_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            Console.Write("Enter the radius for circle: ");
            string input = Console.ReadLine();

            try
            {
                circle.SetRadius(Convert.ToDouble(input));
                Console.WriteLine(circle);

                //Circle circle1 = new Circle();
                //circle1.SetRadius(10);

                //Circle circle2 = new Circle();
                //circle2.SetRadius(-5);

                //Circle circle3 = new Circle();
                //circle3.SetRadius(0);

            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
