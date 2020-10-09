namespace Lab_2_1
{
    public class Swimmer
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public int Rating { get; set; }
        public int Track { get; set; }

        public Swimmer(string fullName, int age, int rating)
        {
            FullName = fullName;
            Age = age;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"ФИО: {FullName}, Возраст: {Age}, Место в рейтинге: {Rating}, Номер дорожки: {Track}";
        }
    }
}