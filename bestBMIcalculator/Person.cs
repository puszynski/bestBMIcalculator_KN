namespace BMICalculator
{
    internal class Person
    {
        private string? firstName;
        private string? lastName;
        private double weight;
        private double height;

        public Person(string? firstName, string? lastName, double weight, double height)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.weight = weight;
            this.height = height;
        }

        public int BMI { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
    }
}