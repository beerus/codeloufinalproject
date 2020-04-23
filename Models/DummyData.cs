using System;
using System.Linq;
using LetsTryAgain.Data;

namespace LetsTryAgain.Models
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            if (!db.Players.Any())
            {
                db.Players.Add(new Player
                {
                    FirstName = "John",
                    LastName = "Doe",
                });
                db.SaveChanges();
            }
        }
    }
}
