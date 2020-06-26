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
    public partial class FormGetOborud : Form
    {
        public FormGetOborud()
        {
            InitializeComponent();
            ShowPostav();
            ShowSotr();
            ShowObor();
            ShowGet();
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
        public void ShowSotr()
        {
            comboBoxSotr.Items.Clear();
            foreach (Sotrud sotr in Program.KPDB.Sotrud)
            {
                string[] item = { sotr.Id.ToString() + ".", sotr.FirstName, sotr.LastName };
                comboBoxSotr.Items.Add(string.Join(" ", item));
            }
        }
        public void ShowObor()
        {
            comboBoxOborud.Items.Clear();
            foreach (Oborud ob in Program.KPDB.Oborud)
            {
                string[] item = { ob.Id.ToString() + ".", ob.Name};
                comboBoxOborud.Items.Add(string.Join(" ", item));
            }
        }
        public void ShowGet()
        {
            listViewGet.Items.Clear();
            foreach (GetOborudovanie go in Program.KPDB.GetOborudovanie)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    go.IdPostav.ToString(),
                    go.Postav.FirstName + " " + go.Postav.LastName,
                    go.IdSotr.ToString(),
                    go.Sotrud.FirstName  + " " + go.Sotrud.LastName,
                    go.IdObor.ToString(),
                    go.Oborud.Name,
                    go.Price,
                    go.DateVid
                });
                item.Tag = go;
                listViewGet.Items.Add(item);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            GetOborudovanie go = new GetOborudovanie();
            go.IdPostav = Convert.ToInt32(comboBoxPostav.SelectedItem.ToString().Split('.')[0]);
            go.IdSotr = Convert.ToInt32(comboBoxSotr.SelectedItem.ToString().Split('.')[0]);
            go.IdObor = Convert.ToInt32(comboBoxOborud.SelectedItem.ToString().Split('.')[0]);
            go.Price = textBoxPriceOborud.Text;
            go.DateVid = textBoxDateVid.Text;
            Program.KPDB.GetOborudovanie.Add(go);
            Program.KPDB.SaveChanges();
            ShowGet();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewGet.SelectedItems.Count == 1)
            {
                GetOborudovanie go = listViewGet.SelectedItems[0].Tag as GetOborudovanie;
                go.IdPostav = Convert.ToInt32(comboBoxPostav.SelectedItem.ToString().Split('.')[0]);
                go.IdSotr = Convert.ToInt32(comboBoxSotr.SelectedItem.ToString().Split('.')[0]);
                go.IdObor = Convert.ToInt32(comboBoxOborud.SelectedItem.ToString().Split('.')[0]);
                go.Price = textBoxPriceOborud.Text;
                go.DateVid = textBoxDateVid.Text;
                Program.KPDB.SaveChanges();
                ShowGet();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewGet.SelectedItems.Count == 1)
                {
                    GetOborudovanie go = listViewGet.SelectedItems[0].Tag as GetOborudovanie;
                    Program.KPDB.GetOborudovanie.Remove(go);
                    Program.KPDB.SaveChanges();
                    ShowGet();
                }
                comboBoxPostav.SelectedItem = null;
                comboBoxSotr.SelectedItem = null;
                comboBoxOborud.SelectedItem = null;
                textBoxPriceOborud.Text = "";
                textBoxDateVid.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            listViewGet.Items.Clear();
        }

        private void listViewGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGet.SelectedItems.Count == 1)
            {
                GetOborudovanie go = listViewGet.SelectedItems[0].Tag as GetOborudovanie;
                comboBoxPostav.SelectedIndex = comboBoxPostav.FindString(go.IdPostav.ToString());
                comboBoxSotr.SelectedIndex = comboBoxSotr.FindString(go.IdSotr.ToString());
                comboBoxOborud.SelectedIndex = comboBoxOborud.FindString(go.IdObor.ToString());
                textBoxPriceOborud.Text = go.Price;
                textBoxDateVid.Text = go.DateVid;
            }
            else
            {
                comboBoxPostav.SelectedItem = null;
                comboBoxSotr.SelectedItem = null;
                comboBoxOborud.SelectedItem = null;
                textBoxPriceOborud.Text = "";
                textBoxDateVid.Text = "";
            }
        }
    }
}
