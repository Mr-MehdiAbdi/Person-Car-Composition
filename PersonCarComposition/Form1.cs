using PersonCarComposition.Bad_Design;
using PersonCarComposition.Best_Design;

namespace PersonCarComposition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBadDesign_Click(object sender, EventArgs e)
        {
            Bad_Design.Person p = new Bad_Design.Person();

            /*Info*/
            p.Fname = "Mehdi";
            p.Lname = "Abdi";

            /*Car 1*/
            p.Car1Model = "BMW😢";
            p.Car1Year = "2022";
            p.Car1plateNumber = "13e123d";

            /*Car 2*/
            p.Car2Model = "Benz😢";
            p.Car1Year = "2024";
            p.Car1plateNumber = "14e123d";

            MessageBox.Show(
              $"{p.Fname} {p.Lname}\n" +
                $"Car 1: {p.Car1Model}\n" +
                    $"Car 2: {p.Car2Model}"
   );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Best_Design.Person person = new Best_Design.Person();
            person.PersonalInfo = new PersonalInfo
            {
                FirstName = "Mehdi",
                LastName = "Abdi"
            };

            person.Car1 = new Car
            {
                Model = "Sonata",
                Color = "White",
                Year = "2026",
                PlateNumber = "12d221"

            };
            person.Car2 = new Car
            {
                Model = "Azera",
                Color = "White",
                Year = "2025",
                PlateNumber = "12d221"
            };

            MessageBox.Show(
                $"{person.PersonalInfo.FirstName} {person.PersonalInfo.LastName}\n" +
                $"{person.Car1.Model} - {person.Car1.Color} - {person.Car1.Model}\n" +
                $"{person.Car2.Model}-{person.Car2.Color} - {person.Car2.Model}"
                );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PlateNumber p = new PlateNumber
                {
                    FirstPart = "116",
                    Letter = "ب",
                    MiddlePart = "123",
                    CityCode = "13"
                };

                MessageBox.Show(
                    $"{p.FirstPart}  {p.Letter} {p.MiddlePart} {p.CityCode}",
                    "Plate Number"
                );
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error");
            }
        }
    }
}
