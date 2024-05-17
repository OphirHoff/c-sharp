using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string name;
        private double age;
        private double height;
        private double weight;
        private string address;
        private bool hasCellPhone;

        // Constructor בנאי
        public Person(string newName, double newAge, double newHeight, double newWeight)
        {
            this.name = newName;
            this.age = newAge;
            address = "";
            this.height = newHeight;
            this.weight = newWeight;
        }

        // Constructor II - בנאי עם תכונה האם יש טלפון
        public Person(string newName, double newAge, double newHeight, double newWeight, bool HasPhone)
        {
            this.name = newName;
            this.age = newAge;
            address = "";
            this.height = newHeight;
            this.weight = newWeight;
            this.hasCellPhone = HasPhone;
        }


        // פעולה קובעת גיל
        public void SetAge(double age)
        {
            if (age >= 0)
                this.age = age;
        }

        // פעולה מאחזרת גיל
        public double GetAge()
        {
            return this.age;
        }

        // פעולה מאחזרת שם
        public string GetName()
        {
            return this.name;
        }

        // פעולה מתארת
        public override string ToString()
        {
            string s = "Name: " + this.name + ", age: " + this.age + ", address: " + address;
            return s;
        }

        // פעולה בודקת שם פרטי זהה
        public bool SameName(Person other)
        {
            return (this.name == other.name);
        }

        // פעולה מאחזרת BMI תקין
        public bool GoodBMI()
        {
            return weight / (height * height) >= 20 && weight / (height * height) <= 25;
        }

        // פעולה הוספת אחד לגיל
        public void AgePlusOne()
        {
            this.age++;
        }

        // פעולה מחזירה מתי יום הולדת עגול
        public double WhenRoundAge()
        {
            if (10 - this.age % 10 < 10)
            {
                return 10 - this.age % 10;
            }
            Console.WriteLine("You Have a round birthday this year, congratulations!!!");
            return 0;

        }

        // פעולה מחזירה האם האדם גדול יותר מהאחר
        public bool Older(Person other)
        {
            return this.age > other.age;
        }
    }
}
