using Homework2.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();

            users.Add(new User { Name = "Dave", Password = "hello" });
            users.Add(new User { Name = "Steve", Password = "steve" });
            users.Add(new User { Name = "Lisa", Password = "hello" });
            users.Add(new User { Name = "Linda", Password = "xyz" });

            ////Foreach Implementation
            //foreach (var user in users.Where(x=>x.Password=="hello"))
            //{

            //    Console.WriteLine($"UserName: {user.Name} Password: {user.Password}");
            //}

            //Task1
            var userswithPasswordHello = users.Where(x => x.Password == "hello").ToList();
            string lines = string.Join(Environment.NewLine, userswithPasswordHello.Select(r => new { r.Name, r.Password }));
            Console.WriteLine(lines);
            Console.WriteLine();

            //Task2
            users.RemoveAll(s => s.Name.ToLower() == s.Password);
            string task2 = string.Join(Environment.NewLine, users.Select(r => new { r.Name, r.Password }));
            Console.WriteLine(task2);
            Console.WriteLine();

            //Task3
            users.Remove(users.FirstOrDefault(x => x.Password == "hello"));
            
            //Task4
            string task4 = string.Join(Environment.NewLine, users.Select(r => new { r.Name, r.Password }));
            Console.WriteLine(task4);

            Console.ReadLine();
        }
    }
}
