namespace PersonCarComposition.Best_Design
{
    public class Person
    {
        private PersonalInfo personalInfo;
        private Car car1;
        private Car car2;

        public PersonalInfo PersonalInfo
        {
            get => personalInfo;
            set
            {
                personalInfo = value ?? throw new ArgumentNullException(nameof(PersonalInfo));
            }
        }

        public Car Car1
        {
            get => car1;
            set=>car1=value;
        }

        public Car Car2
        {
            get => car2;
            set => car2 = value;
        }


    }
}
