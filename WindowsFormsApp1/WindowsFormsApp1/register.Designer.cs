namespace WindowsFormsApp1
{
    partial class frm_register
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
            this.id_txb = new System.Windows.Forms.TextBox();
            this.username_txb = new System.Windows.Forms.TextBox();
            this.pass_txb = new System.Windows.Forms.TextBox();
            this.cfpass_txb = new System.Windows.Forms.TextBox();
            this.create_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm password";
            // 
            // id_txb
            // 
            this.id_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.id_txb.Location = new System.Drawing.Point(352, 105);
            this.id_txb.Name = "id_txb";
            this.id_txb.Size = new System.Drawing.Size(188, 26);
            this.id_txb.TabIndex = 5;
            // 
            // username_txb
            // 
            this.username_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.username_txb.Location = new System.Drawing.Point(352, 148);
            this.username_txb.Name = "username_txb";
            this.username_txb.Size = new System.Drawing.Size(188, 26);
            this.username_txb.TabIndex = 6;
            // 
            // pass_txb
            // 
            this.pass_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pass_txb.Location = new System.Drawing.Point(352, 187);
            this.pass_txb.Name = "pass_txb";
            this.pass_txb.Size = new System.Drawing.Size(188, 26);
            this.pass_txb.TabIndex = 7;
            // 
            // cfpass_txb
            // 
            this.cfpass_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cfpass_txb.Location = new System.Drawing.Point(352, 229);
            this.cfpass_txb.Name = "cfpass_txb";
            this.cfpass_txb.Size = new System.Drawing.Size(188, 26);
            this.cfpass_txb.TabIndex = 8;
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.DarkGray;
            this.create_btn.Location = new System.Drawing.Point(170, 311);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(120, 53);
            this.create_btn.TabIndex = 9;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DarkGray;
            this.login_btn.Location = new System.Drawing.Point(352, 311);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(120, 53);
            this.login_btn.TabIndex = 10;
            this.login_btn.Text = "Back to LogIn";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.DarkGray;
            this.exit_btn.Location = new System.Drawing.Point(528, 311);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(120, 53);
            this.exit_btn.TabIndex = 11;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.cfpass_txb);
            this.Controls.Add(this.pass_txb);
            this.Controls.Add(this.username_txb);
            this.Controls.Add(this.id_txb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_txb;
        private System.Windows.Forms.TextBox username_txb;
        private System.Windows.Forms.TextBox pass_txb;
        private System.Windows.Forms.TextBox cfpass_txb;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}