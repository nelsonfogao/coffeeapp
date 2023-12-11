using Aplication.Domain.Models;
using Aplication.Interfaces.Repository;

namespace CoffeeApp.Repository
{
    public class CoffeeRepository : ICoffeeRepository
    {
        public async Task<IEnumerable<Coffee>> GetAll()
        {
            var list = new List<Coffee>();

            list.Add(new Coffee() { Name = "Black Coffee", Code = "blk" });
            list.Add(new Coffee() { Name = "Espresso", Code = "esp" });
            list.Add(new Coffee() { Name = "Cappuccino", Code = "cap" });
            list.Add(new Coffee() { Name = "Latte", Code = "lat" });
            list.Add(new Coffee() { Name = "Flat White", Code = "wht" });
            list.Add(new Coffee() { Name = "Cold Brew", Code = "clb" });
            list.Add(new Coffee() { Name = "Decaf Coffee", Code = "dec" });

            return list;
        }

        public async Task<IEnumerable<CafeinneLevel>> GetCafeinneLevels()
        {
            var listCoffees = new List<CafeinneLevel>();


            listCoffees.Add(new CafeinneLevel() { Name = "Black coffee", Code = "blk", Level = 95 });
            listCoffees.Add(new CafeinneLevel() { Name = "Espresso", Code = "esp", Level = 63 });
            listCoffees.Add(new CafeinneLevel() { Name = "Cappuccino", Code = "cap", Level = 63 });
            listCoffees.Add(new CafeinneLevel() { Name = "Latte", Code = "lat", Level = 63 });
            listCoffees.Add(new CafeinneLevel() { Name = "FlatWhite", Code = "wht", Level = 63 });
            listCoffees.Add(new CafeinneLevel() { Name = "ColdBrew", Code = "clb", Level = 120 });
            listCoffees.Add(new CafeinneLevel() { Name = "DecafCoffee", Code = "dec", Level = 3 });

            return listCoffees;
        }

    }
}
