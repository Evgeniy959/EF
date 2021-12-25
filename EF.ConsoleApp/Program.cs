using EF.Lib;
using EF.Model;

namespace EF.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            var db = DataBase.Init();

            db.TabCountries.Add(new Country
            {
                Name = "Russia",
                Population = 140,
                Capital = "Moscow"
            });
            
            db.TabCountries.Add(new Country
            {
                Name = "China",
                Population = 1000,
                Capital = "Beijing"
            });

            db.SaveChanges();
        }
    }
}