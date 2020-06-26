using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kvantorium_Project
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonSotrud_Click(object sender, EventArgs e)
        {
            Form formsotr = new FormSotrud();
            formsotr.Show();
        }

        private void buttonPostav_Click(object sender, EventArgs e)
        {
            Form formpost = new FormPostav();
            formpost.Show();
        }

        private void buttonUchetPostav_Click(object sender, EventArgs e)
        {
            Form formuchet = new FormUchetPostav();
            formuchet.Show();
        }

        private void buttonGetOborud_Click(object sender, EventArgs e)
        {
            Form formget = new FormGetOborud();
            formget.Show();
        }

        private void buttonPeredachaOborud_Click(object sender, EventArgs e)
        {
            Form formpered = new FormPeredachaOborud();
            formpered.Show();
        }
        private void buttonOborud_Click(object sender, EventArgs e)
        {
            Form formobor = new FormOborud();
            formobor.Show();
        }
    }
}
