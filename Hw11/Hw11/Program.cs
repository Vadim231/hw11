using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw11
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MigrationContext context = new MigrationContext())
            {

                //var user1 = new User
                //{
                //    Name = "test",
                //    SecondName = "one"
                //};
                //context.Users.Add(user1);
                //context.SaveChanges();



                //AddUserTelephone Migration

                //var user2 = new User
                //{
                //    Name = "test",
                //    SecondName = "two",
                //    Telephone = "123"
                //};
                //context.Users.Add(user2);
                //context.SaveChanges();



                //AddUserAge Migration

                var user3 = new User
                {
                    Name = "test",
                    SecondName = "three",
                    Telephone = "231",
                    Age=25
                };
                context.Users.Add(user3);
                context.SaveChanges();

            }
        }
    }
}
