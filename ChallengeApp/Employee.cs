namespace ChallengeApp
{
    public class Employee
    {

        private List<float> Grades = new List<float>();

        public Employee(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float Grade)
        {
            if (Grade >= 0 && Grade <= 100)
            {
                this.Grades.Add(Grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        
        public void AddGrade(string Grade)
        {
            if (float.TryParse(Grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(double Grade)
        {
            var valueInDouble = (float)Grade;
            this.AddGrade(valueInDouble);
        }
        
        public void AddGrade(long Grade)
        {
            var valueInLong = (float)Grade;
            this.AddGrade(valueInLong);
        }
        
        public void AddGrade(decimal Grade)
        {
            string Grade = Grade.ToString();
            this.AddGrade(Grade);
        }
        
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var Grade in this.Grades)
            {
                statistics.Max = Math.Max(statistics.Max, Grade);
                statistics.Min = Math.Min(statistics.Min, Grade);
                statistics.Average += Grade;
            }

            statistics.Average /= this.Grades.Count;
            return statistics;
        }
    }
}
