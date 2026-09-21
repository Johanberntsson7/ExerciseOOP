namespace ExerciseOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Volvo", "XC60", 2015);
            Car car2 = new Car("Saab", "9-3", 2008);

            car1.PrintInfo();
            car2.PrintInfo();
        }
    }
}