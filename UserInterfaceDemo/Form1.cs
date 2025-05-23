using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceDemo
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSurname.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isDark = rbtnDarkTheme.Checked;
            ApplyTheme(isDark);
        }

        private void ApplyTheme(bool dark)
        {
            Color back = dark ? Color.Black : Color.White;
            Color fore = dark ? Color.White : Color.Black;

            this.BackColor = back;
            foreach (Control c in this.Controls)
            {
                c.BackColor = back;
                c.ForeColor = fore;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нет");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Не надо");
        }
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Файлы изображений|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(ofd.FileName);
            }

        }

        private void picPhoto_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
