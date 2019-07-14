namespace LibrarySystem
{
    partial class Return
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnissue = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtbookID = new System.Windows.Forms.TextBox();
            this.admIssueLblUserID = new System.Windows.Forms.Label();
            this.admIssueLblBookID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.admBookSearchLblSearch = new System.Windows.Forms.Label();
            this.dtgDatalist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatalist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnissue);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.txtbookID);
            this.panel1.Controls.Add(this.admIssueLblUserID);
            this.panel1.Controls.Add(this.admIssueLblBookID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.admBookSearchLblSearch);
            this.panel1.Controls.Add(this.dtgDatalist);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 968);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(980, 219);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 61);
            this.button1.TabIndex = 85;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnissue
            // 
            this.btnissue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnissue.Location = new System.Drawing.Point(786, 219);
            this.btnissue.Margin = new System.Windows.Forms.Padding(6);
            this.btnissue.Name = "btnissue";
            this.btnissue.Size = new System.Drawing.Size(158, 61);
            this.btnissue.TabIndex = 84;
            this.btnissue.Text = "Return";
            this.btnissue.UseVisualStyleBackColor = true;
            this.btnissue.Click += new System.EventHandler(this.Btnissue_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtUserID.Location = new System.Drawing.Point(301, 218);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(6);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(442, 55);
            this.txtUserID.TabIndex = 83;
            // 
            // txtbookID
            // 
            this.txtbookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtbookID.Location = new System.Drawing.Point(301, 130);
            this.txtbookID.Margin = new System.Windows.Forms.Padding(6);
            this.txtbookID.Name = "txtbookID";
            this.txtbookID.Size = new System.Drawing.Size(442, 55);
            this.txtbookID.TabIndex = 82;
            // 
            // admIssueLblUserID
            // 
            this.admIssueLblUserID.AutoSize = true;
            this.admIssueLblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admIssueLblUserID.Location = new System.Drawing.Point(19, 225);
            this.admIssueLblUserID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.admIssueLblUserID.Name = "admIssueLblUserID";
            this.admIssueLblUserID.Size = new System.Drawing.Size(238, 48);
            this.admIssueLblUserID.TabIndex = 81;
            this.admIssueLblUserID.Text = "Member ID:";
            // 
            // admIssueLblBookID
            // 
            this.admIssueLblBookID.AutoSize = true;
            this.admIssueLblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueLblBookID.Location = new System.Drawing.Point(79, 135);
            this.admIssueLblBookID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.admIssueLblBookID.Name = "admIssueLblBookID";
            this.admIssueLblBookID.Size = new System.Drawing.Size(191, 48);
            this.admIssueLblBookID.TabIndex = 80;
            this.admIssueLblBookID.Text = "Book ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 439);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 79;
            this.label1.Text = "( Only books that are not issued )";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(932, 362);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(190, 61);
            this.btnsearch.TabIndex = 78;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.Btnsearch_Click_1);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(335, 362);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(546, 38);
            this.txtsearch.TabIndex = 77;
            // 
            // admBookSearchLblSearch
            // 
            this.admBookSearchLblSearch.AutoSize = true;
            this.admBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchLblSearch.Location = new System.Drawing.Point(16, 363);
            this.admBookSearchLblSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.admBookSearchLblSearch.Name = "admBookSearchLblSearch";
            this.admBookSearchLblSearch.Size = new System.Drawing.Size(315, 37);
            this.admBookSearchLblSearch.TabIndex = 73;
            this.admBookSearchLblSearch.Text = "BookID or MemberID";
            // 
            // dtgDatalist
            // 
            this.dtgDatalist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDatalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatalist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgDatalist.Location = new System.Drawing.Point(0, 507);
            this.dtgDatalist.Margin = new System.Windows.Forms.Padding(6);
            this.dtgDatalist.Name = "dtgDatalist";
            this.dtgDatalist.ReadOnly = true;
            this.dtgDatalist.Size = new System.Drawing.Size(1154, 469);
            this.dtgDatalist.TabIndex = 72;
            this.dtgDatalist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatalist_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nº";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "BookID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 126;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Title";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 98;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "MemberID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 155;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 113;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(9, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1140, 10);
            this.label7.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 89);
            this.label2.TabIndex = 86;
            this.label2.Text = "Return";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1154, 968);
            this.Controls.Add(this.panel1);
            this.Name = "Return";
            this.Text = "Return";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Return_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatalist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnissue;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtbookID;
        private System.Windows.Forms.Label admIssueLblUserID;
        private System.Windows.Forms.Label admIssueLblBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dtgDatalist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label admBookSearchLblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}