using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Participation.Classes;

namespace ParticipationUI
{
    public partial class MakeHulpvraag : Form
    {
        public MakeHulpvraag()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbDescription.Text) && !string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                
            }
            else
            {
                MessageBox.Show("Vul aub alle verplichte velden in");
            }
        }
    }
}
