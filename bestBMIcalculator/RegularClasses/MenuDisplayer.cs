namespace bestBMIcalculator.RegularClasses
{
    public class MenuDisplayer
    {
        public void DisplayMenuInEnglish()
        {
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("1. Change language");
            Console.WriteLine("2. Add new person");
            Console.WriteLine("3. Display person with lowest BMI");
            Console.WriteLine("4. Display person with highest BMI");
            Console.WriteLine("5. Display average BMI");
            Console.WriteLine("6. Exit");
        }

        public void DisplayMenuInPolish()
        {
            Console.WriteLine("Kalkulator BMI");
            Console.WriteLine("1. Zmień język");
            Console.WriteLine("2. Dodaj nową osobę");
            Console.WriteLine("3. Wyświetl osobę z najniższym BMI");
            Console.WriteLine("4. Wyświetl osobę z najwyższym BMI");
            Console.WriteLine("5. Wyświetl średnie BMI");
            Console.WriteLine("6. Wyjdź");
        }
    }
}
