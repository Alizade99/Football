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
    public partial class Reservation : Form
    {
        FootballEntities db = new FootballEntities();
       reservation activereserv { get; set; }
        public Reservation()
        {
            InitializeComponent();
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string surname = txtsurname.Text;
            string phone = txtnumber.Text;
            //bool allEmpty = Extention.isNotEmpty(new string[] {
            //    name,surname,phone }, String.Empty);
            //if (allEmpty)
            //{
            //    reservation name = db.Clients.FirstOrDefault(a => a.First_Name == name);
            //    reservation rsv = new reservation();
            //    {
            //        rsv.= FirstName,
            //        pt.= LastName,
            //        Price = Phone,
            //        db.Clients.Add(pt);
            //        db.SaveChanges();
            //    }
            //    else
            //    {
            //        lblError.Visible = true;
            //        lblError.Text = "Please,field input";
            //    }
            //}
        }
        private void FillcmbPitchName()
        {
            cmbname.Items.AddRange(db.Pitches.Select(pn => pn.Pitch_Name).ToArray());
        }
        private void FillcmbPitchNumber()
        {
            cmbnumber.Items.AddRange(db.Pitches.Select(a => a.Pitch_Number).ToArray());
        }

        private void Reservation_Load_1(object sender, EventArgs e)
        {
            FillcmbPitchName();
            FillcmbPitchNumber();
        }
    }
}
