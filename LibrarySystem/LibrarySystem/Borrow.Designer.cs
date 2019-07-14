namespace LibrarySystem
{
    partial class Borrow
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
            this.optboth = new System.Windows.Forms.RadioButton();
            this.optauthor = new System.Windows.Forms.RadioButton();
            this.opttitle = new System.Windows.Forms.RadioButton();
            this.admBookSearchLblSearch = new System.Windows.Forms.Label();
            this.dtgDatalist = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatalist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.button2);
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
            this.panel1.Controls.Add(this.optboth);
            this.panel1.Controls.Add(this.optauthor);
            this.panel1.Controls.Add(this.opttitle);
            this.panel1.Controls.Add(this.admBookSearchLblSearch);
            this.panel1.Controls.Add(this.dtgDatalist);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 1042);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button1.Location = new System.Drawing.Point(1194, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 61);
            this.button1.TabIndex = 85;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnissue
            // 
            this.btnissue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnissue.Location = new System.Drawing.Point(962, 256);
            this.btnissue.Margin = new System.Windows.Forms.Padding(6);
            this.btnissue.Name = "btnissue";
            this.btnissue.Size = new System.Drawing.Size(184, 61);
            this.btnissue.TabIndex = 84;
            this.btnissue.Text = "Borrow";
            this.btnissue.UseVisualStyleBackColor = true;
            this.btnissue.Click += new System.EventHandler(this.Btnissue_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtUserID.Location = new System.Drawing.Point(359, 270);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(6);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(492, 55);
            this.txtUserID.TabIndex = 83;
            // 
            // txtbookID
            // 
            this.txtbookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtbookID.Location = new System.Drawing.Point(359, 182);
            this.txtbookID.Margin = new System.Windows.Forms.Padding(6);
            this.txtbookID.Name = "txtbookID";
            this.txtbookID.Size = new System.Drawing.Size(492, 55);
            this.txtbookID.TabIndex = 82;
            // 
            // admIssueLblUserID
            // 
            this.admIssueLblUserID.AutoSize = true;
            this.admIssueLblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admIssueLblUserID.Location = new System.Drawing.Point(79, 269);
            this.admIssueLblUserID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.admIssueLblUserID.Name = "admIssueLblUserID";
            this.admIssueLblUserID.Size = new System.Drawing.Size(249, 48);
            this.admIssueLblUserID.TabIndex = 81;
            this.admIssueLblUserID.Text = "Member ID: ";
            // 
            // admIssueLblBookID
            // 
            this.admIssueLblBookID.AutoSize = true;
            this.admIssueLblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueLblBookID.Location = new System.Drawing.Point(137, 187);
            this.admIssueLblBookID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.admIssueLblBookID.Name = "admIssueLblBookID";
            this.admIssueLblBookID.Size = new System.Drawing.Size(191, 48);
            this.admIssueLblBookID.TabIndex = 80;
            this.admIssueLblBookID.Text = "Book ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 517);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 79;
            this.label1.Text = "(Book Avalrible)";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(844, 402);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(190, 61);
            this.btnsearch.TabIndex = 78;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.Btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(359, 402);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(426, 38);
            this.txtsearch.TabIndex = 77;
            // 
            // optboth
            // 
            this.optboth.AutoSize = true;
            this.optboth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optboth.Location = new System.Drawing.Point(546, 457);
            this.optboth.Margin = new System.Windows.Forms.Padding(6);
            this.optboth.Name = "optboth";
            this.optboth.Size = new System.Drawing.Size(114, 41);
            this.optboth.TabIndex = 76;
            this.optboth.TabStop = true;
            this.optboth.Text = "Both";
            this.optboth.UseVisualStyleBackColor = true;
            // 
            // optauthor
            // 
            this.optauthor.AutoSize = true;
            this.optauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optauthor.Location = new System.Drawing.Point(384, 457);
            this.optauthor.Margin = new System.Windows.Forms.Padding(6);
            this.optauthor.Name = "optauthor";
            this.optauthor.Size = new System.Drawing.Size(144, 41);
            this.optauthor.TabIndex = 75;
            this.optauthor.TabStop = true;
            this.optauthor.Text = "Author";
            this.optauthor.UseVisualStyleBackColor = true;
            // 
            // opttitle
            // 
            this.opttitle.AutoSize = true;
            this.opttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opttitle.Location = new System.Drawing.Point(260, 457);
            this.opttitle.Margin = new System.Windows.Forms.Padding(6);
            this.opttitle.Name = "opttitle";
            this.opttitle.Size = new System.Drawing.Size(108, 41);
            this.opttitle.TabIndex = 74;
            this.opttitle.TabStop = true;
            this.opttitle.Text = "Title";
            this.opttitle.UseVisualStyleBackColor = true;
            // 
            // admBookSearchLblSearch
            // 
            this.admBookSearchLblSearch.AutoSize = true;
            this.admBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchLblSearch.Location = new System.Drawing.Point(146, 402);
            this.admBookSearchLblSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.admBookSearchLblSearch.Name = "admBookSearchLblSearch";
            this.admBookSearchLblSearch.Size = new System.Drawing.Size(127, 37);
            this.admBookSearchLblSearch.TabIndex = 73;
            this.admBookSearchLblSearch.Text = "Search:";
            // 
            // dtgDatalist
            // 
            this.dtgDatalist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDatalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatalist.Location = new System.Drawing.Point(0, 573);
            this.dtgDatalist.Margin = new System.Windows.Forms.Padding(6);
            this.dtgDatalist.Name = "dtgDatalist";
            this.dtgDatalist.Size = new System.Drawing.Size(1416, 469);
            this.dtgDatalist.TabIndex = 72;
            this.dtgDatalist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatalist_CellClick);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(2, 368);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1408, 28);
            this.label7.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 102);
            this.label2.TabIndex = 86;
            this.label2.Text = "Borrow";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1300, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 41);
            this.button2.TabIndex = 87;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 1042);
            this.Controls.Add(this.panel1);
            this.Name = "Borrow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatalist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.RadioButton optboth;
        private System.Windows.Forms.RadioButton optauthor;
        private System.Windows.Forms.RadioButton opttitle;
        private System.Windows.Forms.Label admBookSearchLblSearch;
        private System.Windows.Forms.DataGridView dtgDatalist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnissue;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtbookID;
        private System.Windows.Forms.Label admIssueLblUserID;
        private System.Windows.Forms.Label admIssueLblBookID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}