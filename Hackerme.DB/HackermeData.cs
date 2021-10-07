using Hackerme.Infrastructure.Entities;
using System;
using System.Collections.Generic;

namespace Hackerme.DB
{
    public class HackermeData
    {
        public static List<Student> students = new();

        public static List<Course> courses = new(new Course[]
        {
            new Course(".NET Basic"), new Course("OOP"), new Course("Core"), new Course("CSS"), new Course("HTML")
        });
    }
}

