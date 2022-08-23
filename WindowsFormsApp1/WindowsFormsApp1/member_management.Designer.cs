namespace WindowsFormsApp1
{
    partial class member_management
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
            this.label7 = new System.Windows.Forms.Label();
            this.female_chb = new System.Windows.Forms.CheckBox();
            this.dgv_member = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.show_btn = new System.Windows.Forms.Button();
            this.id_txb = new System.Windows.Forms.TextBox();
            this.name_txb = new System.Windows.Forms.TextBox();
            this.phone_txb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mail_txb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_member)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(254, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEMBER MANAGEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(157, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(132, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(129, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(81, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(132, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(121, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender";
            // 
            // female_chb
            // 
            this.female_chb.AutoSize = true;
            this.female_chb.Location = new System.Drawing.Point(238, 311);
            this.female_chb.Name = "female_chb";
            this.female_chb.Size = new System.Drawing.Size(75, 20);
            this.female_chb.TabIndex = 7;
            this.female_chb.Text = "Female";
            this.female_chb.UseVisualStyleBackColor = true;
            // 
            // dgv_member
            // 
            this.dgv_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_member.Location = new System.Drawing.Point(53, 361);
            this.dgv_member.Name = "dgv_member";
            this.dgv_member.RowHeadersWidth = 51;
            this.dgv_member.RowTemplate.Height = 24;
            this.dgv_member.Size = new System.Drawing.Size(828, 255);
            this.dgv_member.TabIndex = 8;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(628, 100);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(107, 54);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(628, 253);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(107, 54);
            this.del_btn.TabIndex = 10;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(628, 176);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(107, 54);
            this.show_btn.TabIndex = 11;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // id_txb
            // 
            this.id_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.id_txb.Location = new System.Drawing.Point(238, 95);
            this.id_txb.Name = "id_txb";
            this.id_txb.Size = new System.Drawing.Size(187, 26);
            this.id_txb.TabIndex = 12;
            // 
            // name_txb
            // 
            this.name_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.name_txb.Location = new System.Drawing.Point(238, 134);
            this.name_txb.Name = "name_txb";
            this.name_txb.Size = new System.Drawing.Size(187, 26);
            this.name_txb.TabIndex = 13;
            // 
            // phone_txb
            // 
            this.phone_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phone_txb.Location = new System.Drawing.Point(238, 176);
            this.phone_txb.Name = "phone_txb";
            this.phone_txb.Size = new System.Drawing.Size(187, 26);
            this.phone_txb.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // mail_txb
            // 
            this.mail_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mail_txb.Location = new System.Drawing.Point(238, 265);
            this.mail_txb.Name = "mail_txb";
            this.mail_txb.Size = new System.Drawing.Size(187, 26);
            this.mail_txb.TabIndex = 16;
            // 
            // member_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 646);
            this.Controls.Add(this.mail_txb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.phone_txb);
            this.Controls.Add(this.name_txb);
            this.Controls.Add(this.id_txb);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dgv_member);
            this.Controls.Add(this.female_chb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "member_management";
            this.Text = "member_management";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_member)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox female_chb;
        private System.Windows.Forms.DataGridView dgv_member;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.TextBox id_txb;
        private System.Windows.Forms.TextBox name_txb;
        private System.Windows.Forms.TextBox phone_txb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox mail_txb;
    }
}