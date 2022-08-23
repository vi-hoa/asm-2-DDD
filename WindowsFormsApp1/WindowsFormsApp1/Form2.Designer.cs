namespace WindowsFormsApp1
{
    partial class frm_management
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bookID_txb = new System.Windows.Forms.TextBox();
            this.bookname_txb = new System.Windows.Forms.TextBox();
            this.author_txb = new System.Windows.Forms.TextBox();
            this.language_txb = new System.Windows.Forms.TextBox();
            this.publisher_txb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.show_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.format_txb = new System.Windows.Forms.TextBox();
            this.member_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(192, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRARY MANAGEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Language";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Publisher";
            // 
            // bookID_txb
            // 
            this.bookID_txb.Location = new System.Drawing.Point(148, 74);
            this.bookID_txb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookID_txb.Name = "bookID_txb";
            this.bookID_txb.Size = new System.Drawing.Size(134, 20);
            this.bookID_txb.TabIndex = 6;
            // 
            // bookname_txb
            // 
            this.bookname_txb.Location = new System.Drawing.Point(148, 105);
            this.bookname_txb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookname_txb.Name = "bookname_txb";
            this.bookname_txb.Size = new System.Drawing.Size(134, 20);
            this.bookname_txb.TabIndex = 7;
            // 
            // author_txb
            // 
            this.author_txb.Location = new System.Drawing.Point(148, 135);
            this.author_txb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.author_txb.Name = "author_txb";
            this.author_txb.Size = new System.Drawing.Size(134, 20);
            this.author_txb.TabIndex = 8;
            // 
            // language_txb
            // 
            this.language_txb.Location = new System.Drawing.Point(148, 198);
            this.language_txb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.language_txb.Name = "language_txb";
            this.language_txb.Size = new System.Drawing.Size(134, 20);
            this.language_txb.TabIndex = 9;
            // 
            // publisher_txb
            // 
            this.publisher_txb.Location = new System.Drawing.Point(148, 167);
            this.publisher_txb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.publisher_txb.Name = "publisher_txb";
            this.publisher_txb.Size = new System.Drawing.Size(134, 20);
            this.publisher_txb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 101);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 12;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(316, 162);
            this.add_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(67, 30);
            this.add_btn.TabIndex = 13;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(410, 162);
            this.show_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(67, 30);
            this.show_btn.TabIndex = 14;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(501, 163);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(67, 30);
            this.delete_btn.TabIndex = 15;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 278);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 186);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 232);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Format";
            // 
            // format_txb
            // 
            this.format_txb.Location = new System.Drawing.Point(148, 232);
            this.format_txb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.format_txb.Name = "format_txb";
            this.format_txb.Size = new System.Drawing.Size(134, 20);
            this.format_txb.TabIndex = 18;
            // 
            // member_btn
            // 
            this.member_btn.Location = new System.Drawing.Point(410, 215);
            this.member_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.member_btn.Name = "member_btn";
            this.member_btn.Size = new System.Drawing.Size(67, 30);
            this.member_btn.TabIndex = 19;
            this.member_btn.Text = "Member";
            this.member_btn.UseVisualStyleBackColor = true;
            this.member_btn.Click += new System.EventHandler(this.Member);
            // 
            // frm_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 483);
            this.Controls.Add(this.member_btn);
            this.Controls.Add(this.format_txb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.publisher_txb);
            this.Controls.Add(this.language_txb);
            this.Controls.Add(this.author_txb);
            this.Controls.Add(this.bookname_txb);
            this.Controls.Add(this.bookID_txb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frm_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bookID_txb;
        private System.Windows.Forms.TextBox bookname_txb;
        private System.Windows.Forms.TextBox author_txb;
        private System.Windows.Forms.TextBox language_txb;
        private System.Windows.Forms.TextBox publisher_txb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox format_txb;
        private System.Windows.Forms.Button member_btn;
    }
}