﻿namespace CantinaUnitBV.Models
{
    public class DbInitializer
    {
        public static void Initialize(UserContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new[]
            {
                new User
                {
                    Email = "test@yahoo.com"
                }
            };

            context.Users.AddRange(users);


            context.SaveChanges();
        }
    }
}
