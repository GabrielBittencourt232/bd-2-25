using Imobiliaria.Models;

namespace Imobiliaria.Data
{
    public class DbInitializer
    {
        public static void Initialize(ImobiContext context)
        {
            context.Database.EnsureCreated();

          
            if (context.Residentes.Any())
            {
                return;   // DB has been seeded
            }

            var residentes = new Residente[]
            {
            new Residente{Nome="Carson",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Residente{Nome="Meredith",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Residente{Nome="Arturo",EnrollmentDate=DateTime.Parse("2003-09-01")},
            };
            foreach (Residente s in residentes)
            {
                context.Residentes.Add(s);
            }
            context.SaveChanges();


        }
    }
}
