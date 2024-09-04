using _66BitTestTask.Models;
using Microsoft.EntityFrameworkCore;

namespace _66BitTestTask.Data
{
    public class DbTeams
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.Migrate();

            if (context.Teams.Any()) { return; }

            var teams = new List<Team>
            {
                new Team {Name = "Спартак"},
                new Team {Name = "ЦСКА"},
                new Team {Name = "Зенит"},
                new Team {Name = "Лацио"},
                new Team {Name = "Ювентус"},
                new Team {Name = "Милан"},
                new Team {Name = "Нью-Ингленд"},
                new Team {Name = "Сиэтл"},
                new Team {Name = "Питтсбург"},
            };

            context.Teams.AddRange(teams);
            context.SaveChanges();
        }
    }
}
