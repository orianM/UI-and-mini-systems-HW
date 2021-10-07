using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackerme.UI
{
    public partial class frmHackermeUI : Form
    {
        public frmHackermeUI()
        {
            InitializeComponent();
        }

        private void TsmiActions_Click(object sender, EventArgs e)
        {
            pnlStudent studentPanel = new();
            panel1.Controls.Clear();
            panel1.Controls.Add(studentPanel);
            studentPanel.Dock = DockStyle.Fill;
        }
    }
}
