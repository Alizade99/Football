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
    public partial class Dashboard : Form
    {
        FootballEntities db = new FootballEntities();
        Pitch selecetedPitch;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Btnrezerv_Click(object sender, EventArgs e)
        { 
                Reservation rvDemo = new Reservation();
                rvDemo.ShowDialog();
        }
 
    
        private void FilldtgViewPitches()
        {
            dtgViewPitchs.DataSource = db.Pitches.Where(st => st.Status == 1).Select(a => new
            {
                a.Id,
                Name = a.Pitch_Name,
                Number = a.Pitch_Number,
                Price = a.Price,
                Mode = a.Status == 0 ? "Empty" : "Full"

            }).ToList();
            dtgViewPitchs.Columns[0].Visible = false;
        }

        private void BtnPitchs_Click_1(object sender, EventArgs e)
        {
            FilldtgViewPitches();
            panelPitch.Visible = true;
            pictureBox1.Visible = false;
          
        }
        private void ChangeMode(string mode)
        {
            if (mode == "edit")
            {
                btnAddPitch.Visible = false;
                btnPitchEdit.Visible = true;
                btnPitchDelete.Visible = true;
            }
            else
            {
                btnAddPitch.Visible = true;
                btnPitchEdit.Visible = false;
                btnPitchDelete.Visible = false;
            }
        }
        private void BtnAddPitch_Click(object sender, EventArgs e)
        {
            string PitchName = pitchname.Text;
            string PitchNumber = pitchnumber.Text;
            decimal PitchPrice = numprice.Value;
            if (PitchName != string.Empty && PitchNumber != string.Empty && PitchPrice != 0)
            {
                Pitch pt = null;
                pt = new Pitch
                {
                    Pitch_Name = PitchName,
                    Pitch_Number = PitchNumber,
                    Price = PitchPrice,
                    Status = 1
                };
                db.Pitches.Add(pt);
                db.SaveChanges();
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Please filled all input";
            }
            MessageBox.Show("Pitch was added successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FilldtgViewPitches();
        }

        private void Btnhome_Click(object sender, EventArgs e)
        {
            panelPitch.Visible = false;
            pictureBox1.Visible = true;
        }

        private void DtgViewPitchs_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int pitchId = (int)dtgViewPitchs.Rows[e.RowIndex].Cells[0].Value;
            selecetedPitch = db.Pitches.FirstOrDefault(pt => pt.Id == pitchId);
            pitchname.Text = selecetedPitch.Pitch_Name;
            pitchnumber.Text = selecetedPitch.Pitch_Number;
            numprice.Value = selecetedPitch.Price;
            ChangeMode("edit");
        }

        private void BtnPitchEdit_Click(object sender, EventArgs e)
        {
            string PitchName = pitchname.Text;
            string PitchNumber = pitchnumber.Text;
            decimal Price = numprice.Value;
            if (selecetedPitch != null)
            {
                if (PitchName != string.Empty && PitchNumber != string.Empty && Price != 0)
                {
                    selecetedPitch.Pitch_Name = pitchname.Text;
                    selecetedPitch.Pitch_Number = pitchnumber.Text;
                    selecetedPitch.Price = numprice.Value;
                    db.SaveChanges();
                    FilldtgViewPitches();
                    ChangeMode("add");
                }
            }
        }

        private void BtnPitchDelete_Click(object sender, EventArgs e)
        {
            string PitchName = pitchname.Text;
            string PitchNumber = pitchnumber.Text;
            decimal Price = numprice.Value;
            if (selecetedPitch != null)
            {
                if (PitchName != string.Empty && PitchNumber != string.Empty && Price != 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + PitchName + "?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {


                        selecetedPitch.Status = 0;
                        db.SaveChanges();
                        ChangeMode("add");
                        FilldtgViewPitches();
                        pitchname.Text = " ";
                        pitchnumber.Text = " ";
                        numprice.Value = 0;
                    }
                }
            }
        }
    }
}
