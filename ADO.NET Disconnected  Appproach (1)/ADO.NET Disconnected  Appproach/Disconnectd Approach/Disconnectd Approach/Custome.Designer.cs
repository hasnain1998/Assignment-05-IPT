﻿namespace Disconnectd_Approach
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_Customer = new System.Windows.Forms.Panel();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtCustomername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomercontact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcustomerEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuttnaddcustomer = new System.Windows.Forms.Button();
            this.Update_Panel = new System.Windows.Forms.Panel();
            this.Customer_List = new System.Windows.Forms.ListBox();
            this.updatepanel = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.txtdateTimePicker1update = new System.Windows.Forms.DateTimePicker();
            this.textid = new System.Windows.Forms.TextBox();
            this.txtcustomername2update = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textcustomercontactupdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textcustomeremailupdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Delete_Panel = new System.Windows.Forms.Panel();
            this.button2Cancelbutton = new System.Windows.Forms.Button();
            this.button1Deletebutton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCustomerNames = new System.Windows.Forms.ComboBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_Customer.SuspendLayout();
            this.Update_Panel.SuspendLayout();
            this.Delete_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 478);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(836, 140);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // panel_Customer
            // 
            this.panel_Customer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Customer.Controls.Add(this.buttonAddCustomer);
            this.panel_Customer.Controls.Add(this.Cancelbutton);
            this.panel_Customer.Controls.Add(this.button3);
            this.panel_Customer.Controls.Add(this.txtdateTimePicker1);
            this.panel_Customer.Controls.Add(this.txtid);
            this.panel_Customer.Controls.Add(this.txtCustomername);
            this.panel_Customer.Controls.Add(this.label2);
            this.panel_Customer.Controls.Add(this.label5);
            this.panel_Customer.Controls.Add(this.txtCustomercontact);
            this.panel_Customer.Controls.Add(this.label3);
            this.panel_Customer.Controls.Add(this.label4);
            this.panel_Customer.Controls.Add(this.txtcustomerEmail);
            this.panel_Customer.Controls.Add(this.label1);
            this.panel_Customer.Location = new System.Drawing.Point(13, 65);
            this.panel_Customer.Name = "panel_Customer";
            this.panel_Customer.Size = new System.Drawing.Size(836, 390);
            this.panel_Customer.TabIndex = 1;
            this.panel_Customer.Visible = false;
            this.panel_Customer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.Location = new System.Drawing.Point(461, 339);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(128, 51);
            this.buttonAddCustomer.TabIndex = 5;
            this.buttonAddCustomer.Text = "Add New Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.txtAddCustomer_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbutton.Location = new System.Drawing.Point(337, 339);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(99, 20);
            this.Cancelbutton.TabIndex = 16;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(337, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 24);
            this.button3.TabIndex = 13;
            this.button3.Text = "Reset All Box";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtdateTimePicker1
            // 
            this.txtdateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateTimePicker1.Location = new System.Drawing.Point(299, 289);
            this.txtdateTimePicker1.Name = "txtdateTimePicker1";
            this.txtdateTimePicker1.Size = new System.Drawing.Size(454, 22);
            this.txtdateTimePicker1.TabIndex = 12;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(314, 43);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(382, 22);
            this.txtid.TabIndex = 8;
            // 
            // txtCustomername
            // 
            this.txtCustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomername.Location = new System.Drawing.Point(314, 103);
            this.txtCustomername.Name = "txtCustomername";
            this.txtCustomername.Size = new System.Drawing.Size(382, 22);
            this.txtCustomername.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer_Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Customer Name";
            // 
            // txtCustomercontact
            // 
            this.txtCustomercontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomercontact.Location = new System.Drawing.Point(314, 161);
            this.txtCustomercontact.Name = "txtCustomercontact";
            this.txtCustomercontact.Size = new System.Drawing.Size(382, 22);
            this.txtCustomercontact.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Customer contact_No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Customer DOB";
            // 
            // txtcustomerEmail
            // 
            this.txtcustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerEmail.Location = new System.Drawing.Point(314, 223);
            this.txtcustomerEmail.Name = "txtcustomerEmail";
            this.txtcustomerEmail.Size = new System.Drawing.Size(382, 22);
            this.txtcustomerEmail.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Customer Email";
            // 
            // txtbuttnaddcustomer
            // 
            this.txtbuttnaddcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuttnaddcustomer.Location = new System.Drawing.Point(13, 12);
            this.txtbuttnaddcustomer.Name = "txtbuttnaddcustomer";
            this.txtbuttnaddcustomer.Size = new System.Drawing.Size(151, 47);
            this.txtbuttnaddcustomer.TabIndex = 4;
            this.txtbuttnaddcustomer.Text = "Add New Customer";
            this.txtbuttnaddcustomer.UseVisualStyleBackColor = true;
            this.txtbuttnaddcustomer.Click += new System.EventHandler(this.txtbuttnaddcustomer_Click);
            // 
            // Update_Panel
            // 
            this.Update_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Update_Panel.Controls.Add(this.Customer_List);
            this.Update_Panel.Controls.Add(this.updatepanel);
            this.Update_Panel.Controls.Add(this.Resetbutton);
            this.Update_Panel.Controls.Add(this.buttonCancel);
            this.Update_Panel.Controls.Add(this.txtdateTimePicker1update);
            this.Update_Panel.Controls.Add(this.textid);
            this.Update_Panel.Controls.Add(this.txtcustomername2update);
            this.Update_Panel.Controls.Add(this.label6);
            this.Update_Panel.Controls.Add(this.label7);
            this.Update_Panel.Controls.Add(this.textcustomercontactupdate);
            this.Update_Panel.Controls.Add(this.label8);
            this.Update_Panel.Controls.Add(this.label9);
            this.Update_Panel.Controls.Add(this.textcustomeremailupdate);
            this.Update_Panel.Controls.Add(this.label10);
            this.Update_Panel.Location = new System.Drawing.Point(16, 65);
            this.Update_Panel.Name = "Update_Panel";
            this.Update_Panel.Size = new System.Drawing.Size(1149, 400);
            this.Update_Panel.TabIndex = 5;
            this.Update_Panel.Visible = false;
            this.Update_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Update_Panel_Paint);
            // 
            // Customer_List
            // 
            this.Customer_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_List.FormattingEnabled = true;
            this.Customer_List.ItemHeight = 31;
            this.Customer_List.Location = new System.Drawing.Point(9, 11);
            this.Customer_List.Name = "Customer_List";
            this.Customer_List.Size = new System.Drawing.Size(348, 345);
            this.Customer_List.TabIndex = 27;
            this.Customer_List.Click += new System.EventHandler(this.Customer_List_Click);
            this.Customer_List.SelectedIndexChanged += new System.EventHandler(this.Customer_List_SelectedIndexChanged);
            // 
            // updatepanel
            // 
            this.updatepanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatepanel.Location = new System.Drawing.Point(790, 339);
            this.updatepanel.Name = "updatepanel";
            this.updatepanel.Size = new System.Drawing.Size(114, 39);
            this.updatepanel.TabIndex = 26;
            this.updatepanel.Text = "Update";
            this.updatepanel.UseVisualStyleBackColor = true;
            this.updatepanel.Click += new System.EventHandler(this.updatepanel_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbutton.Location = new System.Drawing.Point(665, 366);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(99, 24);
            this.Resetbutton.TabIndex = 25;
            this.Resetbutton.Text = "Reset All Box";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(665, 335);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 24);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // txtdateTimePicker1update
            // 
            this.txtdateTimePicker1update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateTimePicker1update.Location = new System.Drawing.Point(665, 270);
            this.txtdateTimePicker1update.Name = "txtdateTimePicker1update";
            this.txtdateTimePicker1update.Size = new System.Drawing.Size(454, 22);
            this.txtdateTimePicker1update.TabIndex = 22;
            // 
            // textid
            // 
            this.textid.Enabled = false;
            this.textid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textid.Location = new System.Drawing.Point(680, 24);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(382, 22);
            this.textid.TabIndex = 18;
            // 
            // txtcustomername2update
            // 
            this.txtcustomername2update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomername2update.Location = new System.Drawing.Point(680, 84);
            this.txtcustomername2update.Name = "txtcustomername2update";
            this.txtcustomername2update.Size = new System.Drawing.Size(382, 22);
            this.txtcustomername2update.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customer_Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(401, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Enter Customer Name";
            // 
            // textcustomercontactupdate
            // 
            this.textcustomercontactupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcustomercontactupdate.Location = new System.Drawing.Point(680, 142);
            this.textcustomercontactupdate.Name = "textcustomercontactupdate";
            this.textcustomercontactupdate.Size = new System.Drawing.Size(382, 22);
            this.textcustomercontactupdate.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Enter Customer contact_No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(401, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Enter Customer DOB";
            // 
            // textcustomeremailupdate
            // 
            this.textcustomeremailupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcustomeremailupdate.Location = new System.Drawing.Point(680, 204);
            this.textcustomeremailupdate.Name = "textcustomeremailupdate";
            this.textcustomeremailupdate.Size = new System.Drawing.Size(382, 22);
            this.textcustomeremailupdate.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(401, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Enter Customer Email";
            // 
            // Updatebutton
            // 
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(170, 12);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(181, 46);
            this.Updatebutton.TabIndex = 7;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Delete_Panel
            // 
            this.Delete_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Delete_Panel.Controls.Add(this.button2Cancelbutton);
            this.Delete_Panel.Controls.Add(this.button1Deletebutton);
            this.Delete_Panel.Controls.Add(this.label11);
            this.Delete_Panel.Controls.Add(this.cbCustomerNames);
            this.Delete_Panel.Location = new System.Drawing.Point(4, 68);
            this.Delete_Panel.Name = "Delete_Panel";
            this.Delete_Panel.Size = new System.Drawing.Size(608, 388);
            this.Delete_Panel.TabIndex = 8;
            this.Delete_Panel.Visible = false;
            this.Delete_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Delete_Panel_Paint);
            // 
            // button2Cancelbutton
            // 
            this.button2Cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Cancelbutton.Location = new System.Drawing.Point(275, 288);
            this.button2Cancelbutton.Name = "button2Cancelbutton";
            this.button2Cancelbutton.Size = new System.Drawing.Size(102, 43);
            this.button2Cancelbutton.TabIndex = 3;
            this.button2Cancelbutton.Text = "Cancel";
            this.button2Cancelbutton.UseVisualStyleBackColor = true;
            this.button2Cancelbutton.Click += new System.EventHandler(this.button2Cancelbutton_Click);
            // 
            // button1Deletebutton
            // 
            this.button1Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Deletebutton.Location = new System.Drawing.Point(78, 290);
            this.button1Deletebutton.Name = "button1Deletebutton";
            this.button1Deletebutton.Size = new System.Drawing.Size(96, 41);
            this.button1Deletebutton.TabIndex = 2;
            this.button1Deletebutton.Text = "Delete";
            this.button1Deletebutton.UseVisualStyleBackColor = true;
            this.button1Deletebutton.Click += new System.EventHandler(this.button1Deletebutton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(408, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Choose The Customer whom you want to remove.!";
            // 
            // cbCustomerNames
            // 
            this.cbCustomerNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerNames.FormattingEnabled = true;
            this.cbCustomerNames.Location = new System.Drawing.Point(78, 169);
            this.cbCustomerNames.Name = "cbCustomerNames";
            this.cbCustomerNames.Size = new System.Drawing.Size(299, 37);
            this.cbCustomerNames.TabIndex = 0;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(377, 12);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(195, 47);
            this.Deletebutton.TabIndex = 8;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 642);
            this.Controls.Add(this.Delete_Panel);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Update_Panel);
            this.Controls.Add(this.txtbuttnaddcustomer);
            this.Controls.Add(this.panel_Customer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_Customer.ResumeLayout(false);
            this.panel_Customer.PerformLayout();
            this.Update_Panel.ResumeLayout(false);
            this.Update_Panel.PerformLayout();
            this.Delete_Panel.ResumeLayout(false);
            this.Delete_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_Customer;
        private System.Windows.Forms.DateTimePicker txtdateTimePicker1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtCustomername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomercontact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcustomerEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button txtbuttnaddcustomer;
        private System.Windows.Forms.Panel Update_Panel;
        private System.Windows.Forms.DateTimePicker txtdateTimePicker1update;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox txtcustomername2update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textcustomercontactupdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textcustomeremailupdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button updatepanel;
        private System.Windows.Forms.ListBox Customer_List;
        private System.Windows.Forms.Panel Delete_Panel;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCustomerNames;
        private System.Windows.Forms.Button button2Cancelbutton;
        private System.Windows.Forms.Button button1Deletebutton;
    }
}