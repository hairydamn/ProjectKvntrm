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
    public partial class FormOborud : Form
    {
        public FormOborud()
        {
            InitializeComponent();
            ShowOborud();
        }
        public void ShowOborud()
        {
            listViewOborud.Items.Clear();
            foreach (Oborud ob in Program.KPDB.Oborud)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    ob.Id.ToString(),
                    ob.Name,
                    ob.Price,
                    ob.ColOb
                });
                item.Tag = ob;
                listViewOborud.Items.Add(item);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Oborud ob = new Oborud();
            ob.Name = textBoxName.Text;
            ob.Price = textBoxPrice.Text;
            ob.ColOb = textBoxColOb.Text;
            Program.KPDB.Oborud.Add(ob);
            Program.KPDB.SaveChanges();
            ShowOborud();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOborud.SelectedItems.Count == 1)
            {
                Oborud ob = listViewOborud.SelectedItems[0].Tag as Oborud;
                ob.Name = textBoxName.Text;
                ob.Price = textBoxPrice.Text;
                ob.ColOb = textBoxColOb.Text;
                Program.KPDB.SaveChanges();
                ShowOborud();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOborud.SelectedItems.Count == 1)
                {
                    Oborud ob = listViewOborud.SelectedItems[0].Tag as Oborud;
                    Program.KPDB.Oborud.Remove(ob);
                    Program.KPDB.SaveChanges();
                    ShowOborud();
                }
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxColOb.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            listViewOborud.Items.Clear();
        }

        private void listViewOborud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOborud.SelectedItems.Count == 1)
            {
                Oborud ob = listViewOborud.SelectedItems[0].Tag as Oborud;
                textBoxName.Text = ob.Name;
                textBoxPrice.Text = ob.Price;
                textBoxColOb.Text = ob.ColOb;
            }
            else
            {
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxColOb.Text = "";
            }
        }
    }
}
