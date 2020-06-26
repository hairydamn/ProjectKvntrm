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
    public partial class FormPostav : Form
    {
        public FormPostav()
        {
            InitializeComponent();
            ShowPostav();
        }
        public void ShowPostav()
        {
            listViewPostavshiki.Items.Clear();
            foreach (Postav post in Program.KPDB.Postav)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    post.Id.ToString(), post.FirstName, post.MiddleName,
                    post.LastName, post.TimeWork, post.MediumPrice
                });
                item.Tag = post;
                listViewPostavshiki.Items.Add(item);
            }

            listViewPostavshiki.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Postav post = new Postav();
            post.FirstName = textBoxFirstName.Text;
            post.MiddleName = textBoxMiddleName.Text;
            post.LastName = textBoxLastName.Text;
            post.TimeWork = textBoxTimeWork.Text;
            post.MediumPrice = textBoxMediumPrice.Text;
            Program.KPDB.Postav.Add(post);
            Program.KPDB.SaveChanges();
            ShowPostav();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPostavshiki.SelectedItems.Count == 1)
            {
                Postav post = listViewPostavshiki.SelectedItems[0].Tag as Postav;
                post.FirstName = textBoxFirstName.Text;
                post.MiddleName = textBoxMiddleName.Text;
                post.LastName = textBoxLastName.Text;
                post.TimeWork = textBoxTimeWork.Text;
                post.MediumPrice = textBoxMediumPrice.Text;
                Program.KPDB.SaveChanges();
                ShowPostav();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPostavshiki.SelectedItems.Count == 1)
                {
                    Postav post = listViewPostavshiki.SelectedItems[0].Tag as Postav;
                    Program.KPDB.Postav.Remove(post);
                    Program.KPDB.SaveChanges();
                    ShowPostav();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxTimeWork.Text = "";
                textBoxMediumPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            listViewPostavshiki.Items.Clear();
        }

        private void listViewPostavshiki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPostavshiki.SelectedItems.Count == 1)
            {
                Postav post = listViewPostavshiki.SelectedItems[0].Tag as Postav;
                textBoxFirstName.Text = post.FirstName;
                textBoxMiddleName.Text = post.MiddleName;
                textBoxLastName.Text = post.LastName;
                textBoxTimeWork.Text = post.TimeWork;
                textBoxMediumPrice.Text = post.MediumPrice;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxTimeWork.Text = "";
                textBoxMediumPrice.Text = "";
            }
        }
    }
}
