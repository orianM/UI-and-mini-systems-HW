using System;

namespace Hackerme.Infrastructure.Entities
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public int NumOfMeetings { get; set; }

        Random rndNum = new Random();
        public Course(string name)
        {
            this.CourseId = Guid.NewGuid();
            this.CourseName = name;
            this.StartDate = new DateTime(2022, rndNum.Next(1, 12), rndNum.Next(1, 28));
            this.NumOfMeetings = rndNum.Next(30, 71);
        }

        public override string ToString()
        {
            return CourseName;
        }
    }
}
