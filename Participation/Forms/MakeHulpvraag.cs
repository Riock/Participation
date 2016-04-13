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
using Participation.Logic;
using Participation.Data;

namespace ParticipationUI
{
    public partial class MakeHulpvraag : Form
    {
        RequestRepository repo = new RequestRepository(new RequestSQLContext());

        public MakeHulpvraag()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbDescription.Text) && !string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                GlobalVariables.ActiveClient = repo.GetClientByID(GlobalVariables.ActiveAccount);

                DateTime till = dtDate.Value;
                Repeat ret = Repeat.Never;

                if (cbRepeat.SelectedText == "Dagelijks")
                {
                    till.AddDays(1);
                    ret = Repeat.Daily;
                }
                else if (cbRepeat.SelectedText == "Wekenlijks")
                {
                    till.AddDays(7);
                    ret = Repeat.Weekly;
                }
                else if (cbRepeat.SelectedText == "Maandenlijks")
                {
                    till.AddDays(7);
                    ret = Repeat.Monthly;
                }
                else if (cbRepeat.SelectedText == "Nooit")
                {
                    till.AddDays(-1);
                    ret = Repeat.Never;
                }

                repo.Insert(GlobalVariables.ActiveAccount, tbTitle.Text, tbDescription.Text, tbLocation.Text, dtDate.Value, till, cbUrgent.Checked, ret);
            }
            else
            {
                MessageBox.Show("Vul aub alle verplichte velden in");
            }
        }
    }
}
