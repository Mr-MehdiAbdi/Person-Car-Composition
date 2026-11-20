namespace PersonCarComposition.Best_Design
{
    public class PersonalInfo
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("First Name is required");
                firstName = value.Trim();
            }
        }
        public string LastName 
        {
            get => lastName;
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name is required");

                lastName = value.Trim();
            }
        }
    }
}
