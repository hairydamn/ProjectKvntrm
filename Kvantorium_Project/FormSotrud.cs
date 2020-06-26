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
    public partial class FormSotrud : Form
    {
        public FormSotrud()
        {
            InitializeComponent();
            ShowSotrud();
        }
        public void ShowSotrud()
        {
            listViewSotrudniki.Items.Clear();
            foreach (Sotrud sotr in Program.KPDB.Sotrud)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    sotr.Id.ToString(), sotr.FirstName, sotr.MiddleName,
                    sotr.LastName, sotr.TimeWork, sotr.Phone, sotr.Position.ToString()
                });
                item.Tag = sotr;
                listViewSotrudniki.Items.Add(item);
            }

            listViewSotrudniki.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Sotrud sotr = new Sotrud();
            sotr.FirstName = textBoxFirstName.Text;
            sotr.MiddleName = textBoxMiddleName.Text;
            sotr.LastName = textBoxLastName.Text;
            sotr.TimeWork = textBoxTimeWork.Text;
            sotr.Phone = textBoxPhone.Text;
            sotr.Position = Convert.ToString(comboBoxPosition.Text);
            Program.KPDB.Sotrud.Add(sotr);
            Program.KPDB.SaveChanges();
            ShowSotrud();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSotrudniki.SelectedItems.Count == 1)
            {
                Sotrud sotr = listViewSotrudniki.SelectedItems[0].Tag as Sotrud;
                sotr.FirstName = textBoxFirstName.Text;
                sotr.MiddleName = textBoxMiddleName.Text;
                sotr.LastName = textBoxLastName.Text;
                sotr.TimeWork = textBoxTimeWork.Text;
                sotr.Phone = textBoxPhone.Text;
                sotr.Position = Convert.ToString(comboBoxPosition.Text);
                Program.KPDB.SaveChanges();
                ShowSotrud();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSotrudniki.SelectedItems.Count == 1)
                {
                    Sotrud sotr = listViewSotrudniki.SelectedItems[0].Tag as Sotrud;
                    Program.KPDB.Sotrud.Remove(sotr);
                    Program.KPDB.SaveChanges();
                    ShowSotrud();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxTimeWork.Text = "";
                textBoxPhone.Text = "";
                comboBoxPosition.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            listViewSotrudniki.Items.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSotrudniki.SelectedItems.Count == 1)
            {
                Sotrud sotr = listViewSotrudniki.SelectedItems[0].Tag as Sotrud;
                textBoxFirstName.Text = sotr.FirstName;
                textBoxMiddleName.Text = sotr.MiddleName;
                textBoxLastName.Text = sotr.LastName;
                textBoxTimeWork.Text = sotr.TimeWork;
                textBoxPhone.Text = sotr.Phone;
                comboBoxPosition.Text = sotr.Position.ToString();
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxTimeWork.Text = "";
                textBoxPhone.Text = "";
                comboBoxPosition.Text = "";
            }
        }
    }
}
