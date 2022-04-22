namespace Bookmarket
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.Lc = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.Payfrom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bname,
            this.BType,
            this.BBy,
            this.Bprice});
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(447, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Bname
            // 
            this.Bname.HeaderText = "name";
            this.Bname.Name = "Bname";
            // 
            // BType
            // 
            this.BType.HeaderText = "type";
            this.BType.Name = "BType";
            // 
            // BBy
            // 
            this.BBy.HeaderText = "by";
            this.BBy.Name = "BBy";
            // 
            // Bprice
            // 
            this.Bprice.HeaderText = "price";
            this.Bprice.Name = "Bprice";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 62);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 23);
            this.name.TabIndex = 1;
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Manga",
            "Novel"});
            this.TypeBox.Location = new System.Drawing.Point(118, 62);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 23);
            this.TypeBox.TabIndex = 2;
            // 
            // Lc
            // 
            this.Lc.FormattingEnabled = true;
            this.Lc.Items.AddRange(new object[] {
            "Vibukij",
            "Siam inter Comice",
            "Zenshu",
            "Luckpim",
            "Dex",
            "Phoenix"});
            this.Lc.Location = new System.Drawing.Point(245, 62);
            this.Lc.Name = "Lc";
            this.Lc.Size = new System.Drawing.Size(121, 23);
            this.Lc.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(384, 62);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 63);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(245, 111);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(100, 23);
            this.pricebox.TabIndex = 5;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(272, 509);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(100, 23);
            this.totalBox.TabIndex = 6;
            // 
            // Payfrom
            // 
            this.Payfrom.Location = new System.Drawing.Point(378, 482);
            this.Payfrom.Name = "Payfrom";
            this.Payfrom.Size = new System.Drawing.Size(75, 50);
            this.Payfrom.TabIndex = 7;
            this.Payfrom.Text = "pay";
            this.Payfrom.UseVisualStyleBackColor = true;
            this.Payfrom.Visible = false;
            this.Payfrom.Click += new System.EventHandler(this.Payfrom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 578);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Payfrom);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.Lc);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Bname;
        private DataGridViewTextBoxColumn BType;
        private DataGridViewTextBoxColumn BBy;
        private DataGridViewTextBoxColumn Bprice;
        private TextBox name;
        private ComboBox TypeBox;
        private ComboBox Lc;
        private Button buttonAdd;
        private TextBox pricebox;
        private TextBox totalBox;
        private Button Payfrom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}