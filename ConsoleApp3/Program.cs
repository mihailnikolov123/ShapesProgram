using ConsoleApp3;

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(5, 4);
        Circle circle = new Circle(3);

        Console.WriteLine("Лице на правоъгълника: " + rect.Area());
        Console.WriteLine("Лице на кръга: " + circle.Area());
    }
}
