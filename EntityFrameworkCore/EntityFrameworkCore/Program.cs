using System;
using System.Linq;

namespace EntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                User u1 = new User() { Email = "amy@gmail.com", Name = "Amy" };
                User u2 = new User() { Email = "Kurt@gmail.com", Name = "Kurt" };

                context.Users.Add(u1);
                context.Users.Add(u2);
                context.SaveChanges();
                Console.WriteLine(" OK");

                var users = context.Users.ToList();
                foreach (var user in users)
                {
                    Console.WriteLine(user.ToString());
                }
            }
        }
    }
}
