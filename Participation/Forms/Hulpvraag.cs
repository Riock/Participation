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
    public partial class Hulpvraag : Form
    {
        public Hulpvraag(string title, List<string> tags, DateTime date, Repeat repeat, string text)
        {
            InitializeComponent();
            tbTitle.Text = title;
            dtDate.Value = date;
            cbRepeat.Text = repeat.ToString();
            tbDescription.Text = text;

            string ret = "";
            foreach (string s in tags)
            {
                ret += ", " + s;
            }

            tbTags.Text = ret;
        }
    }
}
