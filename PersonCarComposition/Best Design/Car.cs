namespace PersonCarComposition.Best_Design
{
    public class Car
    {
        private string model;
        private string color;
        private string year;
        private string plateNumber;

        public string Model
        {
            get => model;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Model  is required");
                model = value.Trim();
            }
        }

        public string Color
        {
            get => color;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Color  is required");
                color = value.Trim();
            }
        }

        public string Year
        {
            get => year;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Year  is required");
                year = value.Trim();
            }
        }
        public string PlateNumber
        {
            get => plateNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Plate number is required.");

                plateNumber = value.Trim();
            }
        }
    }
}
