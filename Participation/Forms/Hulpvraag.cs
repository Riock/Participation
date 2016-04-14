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
    public partial class Hulpvraag : Form
    {
        RequestRepository repo = new RequestRepository(new RequestSQLContext());
        private Request request;

        public Hulpvraag(Request request)
        {
            InitializeComponent();
            tbTitle.Text = request.Title;
            dtDate.Value = request.Date;
            cbRepeat.Text = request.GetRepeat.ToString();
            tbDescription.Text = request.Description;
            lbReaction.Items.Clear();
            this.request = request;

            string ret = "";
            foreach (string s in request.Tags)
            {
                ret += ", " + s;
            }

            tbTags.Text = ret;

            refresh();
        }

        private void refresh()
        {
            List<Response> response = repo.GetResponses(this.request);

            foreach (Response r in response)
            {
                response.ToString();
            }
        }
    }
}
