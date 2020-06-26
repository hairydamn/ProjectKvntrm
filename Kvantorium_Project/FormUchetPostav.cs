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
    public partial class FormUchetPostav : Form
    {
        public FormUchetPostav()
        {
            InitializeComponent();
            ShowPostav();
            ShowUchet();
        }
        public void ShowPostav()
        {
            comboBoxPostav.Items.Clear();
            foreach (Postav post in Program.KPDB.Postav)
            {
                string[] item = { post.Id.ToString() + ".", post.FirstName, post.LastName };
                comboBoxPostav.Items.Add(string.Join(" ", item));
            }
        }
        public void ShowUchet()
        {
            listViewUchet.Items.Clear();
            foreach (UchetPostav up in Program.KPDB.UchetPostav)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    up.IdPostav.ToString(),
                    up.Postav.FirstName + up.Postav.LastName,
                    up.Oborud,
                    up.DatePostav,
                    up.Price
                });
                item.Tag = up;
                listViewUchet.Items.Add(item);
            }

            listViewUchet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UchetPostav up = new UchetPostav();
            up.IdPostav = Convert.ToInt32(comboBoxPostav.SelectedItem.ToString().Split('.')[0]);
            up.DatePostav = textBoxDatePostav.Text;
            up.Price = textBoxPrice.Text;
            up.Oborud = textBoxOborud.Text;
            Program.KPDB.UchetPostav.Add(up);
            Program.KPDB.SaveChanges();
            ShowUchet();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewUchet.SelectedItems.Count == 1)
            {
                UchetPostav up = listViewUchet.SelectedItems[0].Tag as UchetPostav;
                up.IdPostav = Convert.ToInt32(comboBoxPostav.SelectedItem.ToString().Split('.')[0]);
                up.DatePostav = textBoxDatePostav.Text;
                up.Price = textBoxPrice.Text;
                up.Oborud = textBoxOborud.Text;
                Program.KPDB.SaveChanges();
                ShowUchet();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewUchet.SelectedItems.Count == 1)
                {
                    UchetPostav up = listViewUchet.SelectedItems[0].Tag as UchetPostav;
                    Program.KPDB.UchetPostav.Remove(up);
                    Program.KPDB.SaveChanges();
                    ShowUchet();
                }
                comboBoxPostav.SelectedItem = null;
                textBoxDatePostav.Text = "";
                textBoxPrice.Text = "";
                textBoxOborud.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            listViewUchet.Items.Clear();
        }

        private void listViewUchet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUchet.SelectedItems.Count == 1)
            {
                UchetPostav up = listViewUchet.SelectedItems[0].Tag as UchetPostav;
                comboBoxPostav.SelectedIndex = comboBoxPostav.FindString(up.IdPostav.ToString());
                textBoxDatePostav.Text = up.DatePostav;
                textBoxPrice.Text = up.Price;
                textBoxOborud.Text = up.Oborud;
            }
            else
            {
                comboBoxPostav.SelectedItem = null;
                textBoxDatePostav.Text = "";
                textBoxPrice.Text = "";
                textBoxOborud.Text = "";
            }
        }
    }
}
