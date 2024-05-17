using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDll
{
    public class MyMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }
    }

    public class Student
    {
        private string name;
        private int id;
        private int age;

        public Student(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name} {id} {age}";
        }
    }
}
