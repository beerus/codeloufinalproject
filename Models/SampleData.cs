using System;
using LetsTryAgain.Data;

namespace LetsTryAgain.Models
{
    public class SampleData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            if (!db.Players.Any())
            {
                db.Players.Add(new Player
                {
                    FirstName = "John",
                    LastName = "Deere",
                    Year = "05/30/2020",
                    Position = "2",
                    Ranking = 5,
                    ProspectLevel = 5,
                    ChipLevel = 3,
                });
                db.SaveChanges();
            }
        }
    }
}
