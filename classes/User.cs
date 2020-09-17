using System;
using System.Collections.Generic;
using System.Text;

namespace LB_2.classes
{
    class User
    {
        string login;
        string name;
        string surname;
        int age;
        string date;

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.date = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        public void displayUserInfo()
        {
            Console.WriteLine($"логiн: {login}");
            Console.WriteLine($"iм'я: {name}");
            Console.WriteLine($"прiзвище: {surname}");
            Console.WriteLine($"вiк: {age}");
            Console.WriteLine($"дата заповнення анкети: {date}");
        }
    }
}
