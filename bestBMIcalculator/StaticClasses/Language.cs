namespace bestBMIcalculator.StaticClasses
{
    public static class Language
    {
        private static string SelectedLanguage = "English"; //todo => replace with ENUM

        public static void SetLanguage(string language)
        {
            if (language != "English" && language != "Polish")
                Console.WriteLine("User input error, no such language exists!");

            SelectedLanguage = language;
        }

        public static string GetLanguage()
        {
            return SelectedLanguage;
        }
    }
}
