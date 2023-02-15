using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string language = "English";
            int option = 0;

            while (option != 6)
            {
                Console.Clear();
                switch (language)
                {
                    case "English":
                        Console.WriteLine("BMI Calculator");
                        Console.WriteLine("1. Change language");
                        Console.WriteLine("2. Add new person");
                        Console.WriteLine("3. Display person with lowest BMI");
                        Console.WriteLine("4. Display person with highest BMI");
                        Console.WriteLine("5. Display average BMI");
                        Console.WriteLine("6. Exit");
                        break;
                    case "Polski":
                        Console.WriteLine("Kalkulator BMI");
                        Console.WriteLine("1. Zmień język");
                        Console.WriteLine("2. Dodaj nową osobę");
                        Console.WriteLine("3. Wyświetl osobę z najniższym BMI");
                        Console.WriteLine("4. Wyświetl osobę z najwyższym BMI");
                        Console.WriteLine("5. Wyświetl średnie BMI");
                        Console.WriteLine("6. Wyjdź");
                        break;
                }

                Console.WriteLine();
                Console.Write("Choose an option: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        if (language == "English")
                        {
                            language = "Polski";
                        }
                        else
                        {
                            language = "English";
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Add new person");
                        Console.WriteLine();
                        Console.Write("First name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Weight (kg): ");
                        double weight = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Height (m): ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Person person = new Person(firstName, lastName, weight, height);
                        people.Add(person);
                        Console.WriteLine();
                        Console.WriteLine("Person added successfully");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        if (people.Count == 0)
                        {
                            Console.WriteLine("No people added");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }


                        Person lowestBMI = people[0];
                        foreach (Person p in people)
                        {
                            if (p.BMI < lowestBMI.BMI)
                            {
                                lowestBMI = p;
                            }
                        }
                        Console.WriteLine("Person with lowest BMI");
                        Console.WriteLine();
                        Console.WriteLine("First name: " + lowestBMI.FirstName);
                        Console.WriteLine("Last name: " + lowestBMI.LastName);
                        Console.WriteLine("BMI: " + lowestBMI.BMI);
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        if (people.Count == 0)
                        {
                            Console.WriteLine("No people added");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                        Person highestBMI = people[0];
                        foreach (Person p in people)
                        {
                            if (p.BMI > highestBMI.BMI)
                            {
                                highestBMI = p;
                            }
                        }
                        Console.WriteLine("Person with highest BMI");
                        Console.WriteLine();
                        Console.WriteLine("First name: " + highestBMI.FirstName);
                        Console.WriteLine("Last name: " + highestBMI.LastName);
                        Console.WriteLine("BMI: " + highestBMI.BMI);
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        if (people.Count == 0)
                        {
                            Console.WriteLine("No people added");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                        double totalBMI = 0;
                        foreach (Person p in people)
                        {
                            totalBMI += p.BMI;
                        }
                        double averageBMI = totalBMI / people.Count;
                        Console.WriteLine("Average BMI: " + averageBMI);
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}