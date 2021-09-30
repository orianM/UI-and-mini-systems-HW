using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerme.DB
{
    public class Course
    {
        public Guid courseIdentifier;
        public string courseName;
        public DateTime startDate;
        public int numberOfMeetings;

        public Course(string courseName, DateTime startDate, int numberOfMeetings)
        {
            this.courseIdentifier = Guid.NewGuid();
            this.courseName = courseName;
            this.startDate = startDate;
            this.numberOfMeetings = numberOfMeetings;
        }
    }
}
