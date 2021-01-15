using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Disconnectd_Approach
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-B77S1AJ;Initial Catalog=OrderManagmentSystem;Integrated Security=True");

        private void Customer_Load(object sender, EventArgs e)
        {
            Refreshgridview();
        }

        private void Refreshgridview()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter("Select * from Customer", conn);

            adpt.Fill(ds, "Customer");
            dataGridView1.DataSource = ds.Tables["Customer"];

            Customer_List.DataSource = ds.Tables["Customer"];
            Customer_List.DisplayMember = "Name";
            Customer_List.ValueMember = "Id";

            cbCustomerNames.DataSource = ds.Tables["Customer"];
            cbCustomerNames.DisplayMember = "Name";
            cbCustomerNames.ValueMember = "Id";
        }

       

        private void txtAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = new DataSet();
                var adpt = new SqlDataAdapter("Select * from Customer", conn);
                adpt.Fill(ds, "Customer");

                DataRow dr = ds.Tables["Customer"].NewRow();

                dr["Name"] = txtCustomername.Text;
                dr["ContactNo"] = txtCustomercontact.Text;
                dr["DOF"] = txtdateTimePicker1.Value;
                dr["Email"] = txtcustomerEmail.Text;

                ds.Tables["Customer"].Rows.Add(dr);

                var buil = new SqlCommandBuilder(adpt);
                adpt.Update(ds, "Customer");


                Refreshgridview();
                panel_Customer.Visible = false;
                txtCustomername.Text = txtCustomercontact.Text = txtcustomerEmail.Text = "";
                txtdateTimePicker1.Value = System.DateTime.Now;
                txtbuttnaddcustomer.Enabled = true;
                MessageBox.Show("Customer Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            txtCustomercontact.Text = txtcustomerEmail.Text = txtCustomername.Text = "";
            txtdateTimePicker1.Value = System.DateTime.Now;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Update_Panel.Visible = false;
          
        }

        private void txtbuttnaddcustomer_Click(object sender, EventArgs e)
        {
           panel_Customer.Visible = true;
           Update_Panel.Visible = false;
           Delete_Panel.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            textcustomercontactupdate.Text = textid.Text = textcustomeremailupdate.Text = txtcustomername2update.Text = "";
            txtdateTimePicker1update.Value = System.DateTime.Now;
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Update_Panel.Visible = true;
            panel_Customer.Visible = false;
            Delete_Panel.Visible = false;

        }

        private void updatepanel_Click(object sender, EventArgs e)
        {
            try
            {
                Updatebutton.Enabled = true;

                var ds = new DataSet();
                var adpt = new SqlDataAdapter("Select * from Customer where Id=" + Customer_List.SelectedValue, conn);
                adpt.Fill(ds, "Customer");

                foreach (DataRow dr in ds.Tables["Customer"].Rows)
                {
                    dr["Name"] = txtcustomername2update.Text;
                    dr["ContactNo"] = textcustomercontactupdate.Text;
                    dr["Email"] = textcustomeremailupdate.Text;
                    dr["DOF"] = txtdateTimePicker1update.Text;
                }

                var buil = new SqlCommandBuilder(adpt);
                adpt.Update(ds, "Customer");

                Refreshgridview();

                MessageBox.Show("Customer Updated Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_Panel_Paint(object sender, PaintEventArgs e)
        {
           
            panel_Customer.Visible = false;
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //textid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //txtcustomername2update.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //textcustomercontactupdate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //textcustomeremailupdate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //txtdateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        

        }

        private void Customer_List_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var adpt = new SqlDataAdapter("Select * from Customer where Id=" + Customer_List.SelectedValue, conn);
            adpt.Fill(ds, "Customer");

            foreach (DataRow dr in ds.Tables["Customer"].Rows)
            {
                textid.Text = dr["Id"].ToString();
                txtcustomername2update.Text = dr["Name"].ToString();
                textcustomercontactupdate.Text = dr["ContactNo"].ToString();
                textcustomeremailupdate.Text = dr["Email"].ToString();
                txtdateTimePicker1update.Text = dr["DOF"].ToString();
                //txtdateTimePicker1update.Value = Convert.ToDateTime(dr["DOB"]);
            }



        }

        private void Delete_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            Delete_Panel.Visible = true;
            Update_Panel.Visible = false;
            panel_Customer.Visible = false;
        }

        private void button1Deletebutton_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Are you Sure!", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var ds = new DataSet();
                    var adpt = new SqlDataAdapter("Select * from Customer where Id=" + cbCustomerNames.SelectedValue, conn);
                    adpt.Fill(ds, "Customer");

                    foreach (DataRow dr in ds.Tables["Customer"].Rows)
                    {
                        dr.Delete();
                    }

                    var buil = new SqlCommandBuilder(adpt);
                    adpt.Update(ds, "Customer");

                    Refreshgridview();
                    MessageBox.Show("Customer Deleted Successfully");
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customer_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

       
      
    }
}
