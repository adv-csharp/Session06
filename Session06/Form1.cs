using Session06.DataModel;

namespace Session06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();            
            var country = new Country { Name = "Iran"};
            db.Countries.Add(country);
            db.SaveChanges();
            MessageBox.Show("Done!");            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext()) {
                var province = new Province { Name = "Tehran", CountryId = 1 };
                var city = new City { Name = "Tehran", Province = province };

                db.Provinces.Add(province);
                db.Cities.Add(city);
                db.SaveChanges();
                MessageBox.Show("Done!");
            }

            
        }
    }
}