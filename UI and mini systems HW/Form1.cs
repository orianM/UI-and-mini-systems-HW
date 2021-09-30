using Hackerme.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_and_mini_systems_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            DateTime DoB = dateTimePicker1.Value;
            string email = textBox4.Text;
            string city = textBox5.Text;
            int amountToPay = int.Parse(textBox6.Text);
            int amountPayed = int.Parse(textBox7.Text);
            new Student(id, firstName, lastName, DoB, email, city, amountToPay, amountPayed);
        }
    }
}
