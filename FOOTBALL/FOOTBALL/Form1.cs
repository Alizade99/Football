using FOOTBALL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOOTBALL
{
    public partial class Form1 : Form
    {
        FootballEntities db = new FootballEntities();
        public Form1()
        {
            InitializeComponent();
        }   
        private void Btnenter_Click_1(object sender, EventArgs e)
        {
            string Email = txtname.Text;
            string Password = txtpassword.Text;
            bool allempty = Extention.isNotEmpty(new string[] {
                Email,Password
            }, string.Empty);
            if (allempty)
            {
                string adminEmail = db.Admins.First(a => a.Id == 1).Email;
                string adminPassword = db.Admins.First(a => a.Id == 1).Password;
                if (Email == adminEmail && Password == adminPassword)
                {
                    Dashboard dash = new Dashboard();
                    dash.ShowDialog();
                }
            }

        }
    }
}

        

