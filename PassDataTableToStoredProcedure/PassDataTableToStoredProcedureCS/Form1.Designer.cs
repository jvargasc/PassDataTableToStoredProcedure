namespace PassDataTableToStoredProcedureCS
{
    partial class Form1
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
            this.BtnClear = new System.Windows.Forms.Button();
            this.DtgClients = new System.Windows.Forms.DataGridView();
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClients)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(317, 12);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // DtgClients
            // 
            this.DtgClients.AllowUserToAddRows = false;
            this.DtgClients.AllowUserToDeleteRows = false;
            this.DtgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgClients.Location = new System.Drawing.Point(15, 45);
            this.DtgClients.Name = "DtgClients";
            this.DtgClients.ReadOnly = true;
            this.DtgClients.Size = new System.Drawing.Size(1251, 314);
            this.DtgClients.TabIndex = 12;
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.Location = new System.Drawing.Point(117, 15);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(100, 20);
            this.TxtCustomer.TabIndex = 0;
            this.TxtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCustomer_KeyDown);
            // 
            // LblCustomer
            // 
            this.LblCustomer.Location = new System.Drawing.Point(12, 15);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(100, 23);
            this.LblCustomer.TabIndex = 10;
            this.LblCustomer.Text = "Customer Code";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(236, 12);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 371);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.DtgClients);
            this.Controls.Add(this.TxtCustomer);
            this.Controls.Add(this.LblCustomer);
            this.Controls.Add(this.BtnSearch);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DataTable To Stored Procedure Example";
            ((System.ComponentModel.ISupportInitialize)(this.DtgClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnClear;
        internal System.Windows.Forms.DataGridView DtgClients;
        internal System.Windows.Forms.TextBox TxtCustomer;
        internal System.Windows.Forms.Label LblCustomer;
        internal System.Windows.Forms.Button BtnSearch;
    }
}

