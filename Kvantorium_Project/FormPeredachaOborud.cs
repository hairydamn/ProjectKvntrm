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
    public partial class FormPeredachaOborud : Form
    {
        public FormPeredachaOborud()
        {
            InitializeComponent();
            ShowSotr();
            ShowObor();
            ShowPeredacha();
        }
        public void ShowSotr()
        {
            comboBoxFirstSotr.Items.Clear();
            comboBoxSecondSotr.Items.Clear();
            foreach (Sotrud sotr in Program.KPDB.Sotrud)
            {
                string[] item = { sotr.Id.ToString() + ".", sotr.FirstName, sotr.LastName };
                comboBoxFirstSotr.Items.Add(string.Join(" ", item));
                comboBoxSecondSotr.Items.Add(string.Join(" ", item));
            }
        }
        public void ShowObor()
        {
            comboBoxOborud.Items.Clear();
            foreach (Oborud ob in Program.KPDB.Oborud)
            {
                string[] item = { ob.Id.ToString() + ".", ob.Name };
                comboBoxOborud.Items.Add(string.Join(" ", item));
            }
        }
        public void ShowPeredacha()
        {
            listViewPeredacha.Items.Clear();
            foreach (PeredachaOborud po in Program.KPDB.PeredachaOborud)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    po.IdFirstSotr.ToString(),
                    po.Sotrud.FirstName + " " + po.Sotrud.LastName,
                    po.IdSecondSotr.ToString(),
                    po.Sotrud.FirstName  + " " + po.Sotrud.LastName,
                    po.IdObor.ToString(),
                    po.Oborud.Name,
                    po.PurposePeredacha
                });
                item.Tag = po;
                listViewPeredacha.Items.Add(item);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PeredachaOborud po = new PeredachaOborud();
            po.IdFirstSotr = Convert.ToInt32(comboBoxFirstSotr.SelectedItem.ToString().Split('.')[0]);
            po.IdSecondSotr = Convert.ToInt32(comboBoxSecondSotr.SelectedItem.ToString().Split('.')[0]);
            po.IdObor = Convert.ToInt32(comboBoxOborud.SelectedItem.ToString().Split('.')[0]);
            po.PurposePeredacha = textBoxPurposePeredacha.Text;
            Program.KPDB.PeredachaOborud.Add(po);
            Program.KPDB.SaveChanges();
            ShowPeredacha();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPeredacha.SelectedItems.Count == 1)
            {
                PeredachaOborud po = listViewPeredacha.SelectedItems[0].Tag as PeredachaOborud;
                po.IdFirstSotr = Convert.ToInt32(comboBoxFirstSotr.SelectedItem.ToString().Split('.')[0]);
                po.IdSecondSotr = Convert.ToInt32(comboBoxSecondSotr.SelectedItem.ToString().Split('.')[0]);
                po.IdObor = Convert.ToInt32(comboBoxOborud.SelectedItem.ToString().Split('.')[0]);
                po.PurposePeredacha = textBoxPurposePeredacha.Text;
                Program.KPDB.SaveChanges();
                ShowPeredacha();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPeredacha.SelectedItems.Count == 1)
                {
                    PeredachaOborud po = listViewPeredacha.SelectedItems[0].Tag as PeredachaOborud;
                    Program.KPDB.PeredachaOborud.Remove(po);
                    Program.KPDB.SaveChanges();
                    ShowPeredacha();
                }
                comboBoxFirstSotr.SelectedItem = null;
                comboBoxSecondSotr.SelectedItem = null;
                comboBoxOborud.SelectedItem = null;
                textBoxPurposePeredacha.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            listViewPeredacha.Items.Clear();
        }

        private void listViewPeredacha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPeredacha.SelectedItems.Count == 1)
            {
                PeredachaOborud po = listViewPeredacha.SelectedItems[0].Tag as PeredachaOborud;
                comboBoxFirstSotr.SelectedIndex = comboBoxFirstSotr.FindString(po.IdFirstSotr.ToString());
                comboBoxSecondSotr.SelectedIndex = comboBoxSecondSotr.FindString(po.IdSecondSotr.ToString());
                comboBoxOborud.SelectedIndex = comboBoxOborud.FindString(po.IdObor.ToString());
                textBoxPurposePeredacha.Text = po.PurposePeredacha;
            }
            else
            {
                comboBoxFirstSotr.SelectedItem = null;
                comboBoxSecondSotr.SelectedItem = null;
                comboBoxOborud.SelectedItem = null;
                textBoxPurposePeredacha.Text = "";
            }
        }
    }
}
