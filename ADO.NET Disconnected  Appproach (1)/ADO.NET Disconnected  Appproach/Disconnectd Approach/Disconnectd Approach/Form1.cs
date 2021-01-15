using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnectd_Approach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you can See The File Menu by clicking on the file And See the sub_menu by clicking file menu & you have the right to Add ,Delete ,Edit and Update the member  whatever you want in Sub menu\n If you want to delete Customer then you need to delete Customer_Order firsly then you can delete Customer", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order formOrder = new Order();
            formOrder.MdiParent = this;
            formOrder.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer formCustomer = new Customer();
            formCustomer.MdiParent = this;
            formCustomer.Show();
        }

        private void orderDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_Detail formdetail = new Order_Detail();
            formdetail.MdiParent = this;
            formdetail.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product formproduct = new Product();
            formproduct.MdiParent = this;
            formproduct.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productdetail p_detail = new Productdetail();
            p_detail.MdiParent = this;
            p_detail.Show();
        }

        private void projectReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting reportform = new Reporting();
            reportform.MdiParent = this;
            reportform.Show();
        }

        private void orderStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_status os = new Order_status();
            os.MdiParent = this;
            os.Show();
        }

        private void statusStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status_Statement ss = new Status_Statement();
            ss.MdiParent = this;
            ss.Show();
        }

        private void orderStatusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Status_Report sr = new Status_Report();
            sr.MdiParent = this;
            sr.Show();
        }
    }
}
