namespace OperatorExercise
{
    public class Program
    {
        public static void Main()
        {

            int a = 17;
            int b = 4;
            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {addition}\n{a} - {b} is {subtraction}\n{a} * {b} is {multiplication}\n{a} / {b} is {quotient} remainder of {remainder}");

            Console.WriteLine();

            Console.WriteLine("What is the Area of your circle?");

            Console.WriteLine();  

            double radius = double.Parse( Console.ReadLine() );

            double area = AreaOfCircle( radius );

            Console.WriteLine($"The area of circle with radius of {radius} is  {area}" );

            Console.WriteLine("The thought exercise answer should be 20");
            
        }

        public static double AreaOfCircle(double radius)
        {
            radius = Math.PI * Math.Pow(radius, 2);

            return radius;
        }
    }
}