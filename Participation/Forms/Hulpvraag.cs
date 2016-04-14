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

namespace Participation
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
        public Hulpvraag()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            List<Response> response = repo.GetResponses(this.request);

            foreach (Response r in response)
            {
                response.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            repo.Insert(new Account(4, "test", "test@ggf", "hunter12"), "title", "text", "location", dtDate.Value, dtTill.Value, true, Repeat.Monthly);
        }
    }
}
