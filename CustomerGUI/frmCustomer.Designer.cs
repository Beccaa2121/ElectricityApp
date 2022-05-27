
namespace CustomerGUI
{
    partial class frmCustomer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblkWhUsed = new System.Windows.Forms.Label();
            this.lblNewCustomer = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtkWhUsed = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lblNoCust = new System.Windows.Forms.Label();
            this.lblTotalkWh = new System.Windows.Forms.Label();
            this.lblAvgBill = new System.Windows.Forms.Label();
            this.txtNoCust = new System.Windows.Forms.TextBox();
            this.txtTotalkWh = new System.Windows.Forms.TextBox();
            this.txtAvgBill = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(51, 47);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(89, 21);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(51, 95);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(87, 21);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name:";
            // 
            // lblkWhUsed
            // 
            this.lblkWhUsed.AutoSize = true;
            this.lblkWhUsed.Location = new System.Drawing.Point(51, 145);
            this.lblkWhUsed.Name = "lblkWhUsed";
            this.lblkWhUsed.Size = new System.Drawing.Size(84, 21);
            this.lblkWhUsed.TabIndex = 3;
            this.lblkWhUsed.Text = "kWh Used:";
            // 
            // lblNewCustomer
            // 
            this.lblNewCustomer.AutoSize = true;
            this.lblNewCustomer.Location = new System.Drawing.Point(125, 9);
            this.lblNewCustomer.Name = "lblNewCustomer";
            this.lblNewCustomer.Size = new System.Drawing.Size(146, 21);
            this.lblNewCustomer.TabIndex = 4;
            this.lblNewCustomer.Text = "Add New Customer";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(78, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 33);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(204, 209);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 33);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtkWhUsed
            // 
            this.txtkWhUsed.Location = new System.Drawing.Point(147, 142);
            this.txtkWhUsed.Name = "txtkWhUsed";
            this.txtkWhUsed.Size = new System.Drawing.Size(100, 29);
            this.txtkWhUsed.TabIndex = 8;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(147, 92);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(141, 29);
            this.txtLName.TabIndex = 9;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(147, 47);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(142, 29);
            this.txtFName.TabIndex = 10;
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 21;
            this.lstCustomers.Location = new System.Drawing.Point(392, 12);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(303, 256);
            this.lstCustomers.TabIndex = 11;
            // 
            // lblNoCust
            // 
            this.lblNoCust.AutoSize = true;
            this.lblNoCust.Location = new System.Drawing.Point(63, 293);
            this.lblNoCust.Name = "lblNoCust";
            this.lblNoCust.Size = new System.Drawing.Size(131, 21);
            this.lblNoCust.TabIndex = 12;
            this.lblNoCust.Text = "No of Customers:";
            // 
            // lblTotalkWh
            // 
            this.lblTotalkWh.AutoSize = true;
            this.lblTotalkWh.Location = new System.Drawing.Point(294, 293);
            this.lblTotalkWh.Name = "lblTotalkWh";
            this.lblTotalkWh.Size = new System.Drawing.Size(118, 21);
            this.lblTotalkWh.TabIndex = 13;
            this.lblTotalkWh.Text = "Total kWh used:";
            // 
            // lblAvgBill
            // 
            this.lblAvgBill.AutoSize = true;
            this.lblAvgBill.Location = new System.Drawing.Point(518, 293);
            this.lblAvgBill.Name = "lblAvgBill";
            this.lblAvgBill.Size = new System.Drawing.Size(95, 21);
            this.lblAvgBill.TabIndex = 14;
            this.lblAvgBill.Text = "Average Bill:";
            // 
            // txtNoCust
            // 
            this.txtNoCust.Location = new System.Drawing.Point(200, 290);
            this.txtNoCust.Name = "txtNoCust";
            this.txtNoCust.ReadOnly = true;
            this.txtNoCust.Size = new System.Drawing.Size(88, 29);
            this.txtNoCust.TabIndex = 15;
            // 
            // txtTotalkWh
            // 
            this.txtTotalkWh.Location = new System.Drawing.Point(418, 290);
            this.txtTotalkWh.Name = "txtTotalkWh";
            this.txtTotalkWh.ReadOnly = true;
            this.txtTotalkWh.Size = new System.Drawing.Size(88, 29);
            this.txtTotalkWh.TabIndex = 16;
            // 
            // txtAvgBill
            // 
            this.txtAvgBill.Location = new System.Drawing.Point(619, 290);
            this.txtAvgBill.Name = "txtAvgBill";
            this.txtAvgBill.ReadOnly = true;
            this.txtAvgBill.Size = new System.Drawing.Size(88, 29);
            this.txtAvgBill.TabIndex = 17;
            // 
            // frmCustomer
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(778, 338);
            this.Controls.Add(this.txtAvgBill);
            this.Controls.Add(this.txtTotalkWh);
            this.Controls.Add(this.txtNoCust);
            this.Controls.Add(this.lblAvgBill);
            this.Controls.Add(this.lblTotalkWh);
            this.Controls.Add(this.lblNoCust);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtkWhUsed);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNewCustomer);
            this.Controls.Add(this.lblkWhUsed);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomer";
            this.Text = "Customer Electrical Bill Information";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblkWhUsed;
        private System.Windows.Forms.Label lblNewCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtkWhUsed;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblNoCust;
        private System.Windows.Forms.Label lblTotalkWh;
        private System.Windows.Forms.Label lblAvgBill;
        private System.Windows.Forms.TextBox txtNoCust;
        private System.Windows.Forms.TextBox txtTotalkWh;
        private System.Windows.Forms.TextBox txtAvgBill;
    }
}

