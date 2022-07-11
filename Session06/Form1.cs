using Microsoft.EntityFrameworkCore;
using Serilog;
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
            //using var db = new AppDbContext();            
            //var country = new Country { Name = "Iran"};
            //db.Countries.Add(country);
            //db.SaveChanges();
            //MessageBox.Show("Done!");            

            var country = new Country { Name = "Iran" };
            var repo = new RepositoryOld<Country>();
            repo.Add(country);
            MessageBox.Show("Done!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //using (var db = new AppDbContext()) {
            //    var province = new Province { Name = "Tehran", CountryId = 1 };
            //    var city = new City { Name = "Tehran", Province = province };

            //    db.Provinces.Add(province);
            //    db.Cities.Add(city);
            //    db.SaveChanges();
            //    MessageBox.Show("Done!");
            //}

            var province = new Province { Name = "Tehran", CountryId = 1 };
            var city = new City { Name = "Tehran", Province = province };

            //var repoCity = new RepositoryOld<City>();
            //var repoProvince = new RepositoryOld<Province>();
            //repoProvince.Add(province);
            //repoCity.Add(city);


            try
            {
                var repo = new Repository();
                repo.Add(province);
                repo.Add(city);
            }catch (DbUpdateException ex)
            {
                Log.Error(ex.StackTrace);
            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                // 1. show message
                // 2. option
                // 3. log
                //      serilog
            }

            MessageBox.Show("Done!");


            /**
             * Error:
             *  Syntax Error
             *  Runtime-Error
             *      
             *      
             *  Sematic Error, Logical Error
             *      unit test /e2e test
             */
        }
    }
}