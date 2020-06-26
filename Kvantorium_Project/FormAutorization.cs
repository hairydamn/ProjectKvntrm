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
    public struct User
    {
        public string login;
        public string password;
        public string typeuser;
    }
    public partial class FormAutorization : Form
    {
        public static User autoriz = new User();
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonVoity_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool k = false;
                foreach (Autorization user in Program.KPDB.Autorization)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        k = true;
                        autoriz.login = user.Login;
                        autoriz.password = user.Password;
                        autoriz.typeuser = user.TypeUser;
                    }
                }
                if (!k)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    this.Hide();
                }
            }
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            Form formreg = new FormRegistration();
            formreg.Show();
        }

        private void FormAutorization_Load(object sender, EventArgs e)
        {

        }
    }
}
