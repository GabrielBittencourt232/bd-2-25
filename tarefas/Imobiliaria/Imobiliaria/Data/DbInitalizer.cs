using Imobiliaria.Models;
namespace Imobiliaria.Data
{
    public class DbInitalizer
    {
        public static void Initialize(ImobiliariaContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Imovel.Any())
            {
                return;   // DB has been seeded
            }
            foreach (Imovel I in Imovel)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
        }
    }

}
