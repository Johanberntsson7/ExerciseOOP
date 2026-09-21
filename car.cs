namespace ExerciseOOP
{
    public class Car
    {
        // Attribut
        public string Brand;
        public string Model;
        public int Year;

        // Konstruktör: sätter värdena när objektet skapas
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        // Metod som skriver ut bilens detaljer
        public void PrintInfo()
        {
            Console.WriteLine($"Märke: {Brand}, Modell: {Model}, Årsmodell: {Year}");
        }
    }
}