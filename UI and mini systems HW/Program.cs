using Hackerme.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_and_mini_systems_HW
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Course course1 = new Course(".NET Basic", new DateTime(2021, 7, 23), 57);
            Course course2 = new Course("OOP", new DateTime(2021, 6, 13), 153);
            Course course3 = new Course("Core", new DateTime(2021, 3, 27), 376);
            Course course4 = new Course("CSS", new DateTime(2021, 2, 14), 80);
            Course course5 = new Course("HTML", new DateTime(2021, 5, 24), 150);

            MyDB.CourseList.Add(course1);
            MyDB.CourseList.Add(course2);
            MyDB.CourseList.Add(course3);
            MyDB.CourseList.Add(course4);
            MyDB.CourseList.Add(course5);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
