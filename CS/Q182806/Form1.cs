using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Q182806
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'issueListDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.issueListDataSet.Users);
            itemsTableAdapter1.Fill(issueListDataSet.Items);
            projectsTableAdapter1.Fill(issueListDataSet.Projects);
            schedulerTableAdapter1.Fill(issueListDataSet.Scheduler);
        }
    }
}