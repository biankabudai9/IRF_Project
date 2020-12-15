namespace beadando
{
    partial class Register_uc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addplayer = new beadando.Mybutton();
            this.wrongname = new System.Windows.Forms.Label();
            this.wrongage = new System.Windows.Forms.Label();
            this.wrongpw = new System.Windows.Forms.Label();
            this.cancel = new beadando.Mybutton();
            this.label1 = new System.Windows.Forms.Label();
            this.newname = new System.Windows.Forms.TextBox();
            this.newage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addplayer
            // 
            this.addplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.addplayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addplayer.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.addplayer.ForeColor = System.Drawing.Color.White;
            this.addplayer.Location = new System.Drawing.Point(534, 457);
            this.addplayer.Name = "addplayer";
            this.addplayer.Size = new System.Drawing.Size(250, 80);
            this.addplayer.TabIndex = 9;
            this.addplayer.Text = "Go";
            this.addplayer.UseVisualStyleBackColor = true;
            // 
            // wrongname
            // 
            this.wrongname.AutoSize = true;
            this.wrongname.BackColor = System.Drawing.Color.Transparent;
            this.wrongname.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrongname.ForeColor = System.Drawing.Color.Red;
            this.wrongname.Location = new System.Drawing.Point(530, 166);
            this.wrongname.Name = "wrongname";
            this.wrongname.Size = new System.Drawing.Size(345, 23);
            this.wrongname.TabIndex = 10;
            this.wrongname.Text = "This name should only contain letters";
            this.wrongname.Visible = false;
            // 
            // wrongage
            // 
            this.wrongage.AutoSize = true;
            this.wrongage.BackColor = System.Drawing.Color.Transparent;
            this.wrongage.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrongage.ForeColor = System.Drawing.Color.Red;
            this.wrongage.Location = new System.Drawing.Point(530, 235);
            this.wrongage.Name = "wrongage";
            this.wrongage.Size = new System.Drawing.Size(315, 23);
            this.wrongage.TabIndex = 11;
            this.wrongage.Text = "Age should be between 6 and 99";
            this.wrongage.Visible = false;
            // 
            // wrongpw
            // 
            this.wrongpw.AutoSize = true;
            this.wrongpw.BackColor = System.Drawing.Color.Transparent;
            this.wrongpw.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrongpw.ForeColor = System.Drawing.Color.Red;
            this.wrongpw.Location = new System.Drawing.Point(538, 325);
            this.wrongpw.Name = "wrongpw";
            this.wrongpw.Size = new System.Drawing.Size(307, 69);
            this.wrongpw.TabIndex = 12;
            this.wrongpw.Text = "Your password must be \r\nat least 8 characters long \r\nhaving both numbers and lett" +
    "ers";
            this.wrongpw.Visible = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(109, 457);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(250, 80);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(188, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add your details to begin the game";
            // 
            // newname
            // 
            this.newname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.newname.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.newname.Location = new System.Drawing.Point(292, 159);
            this.newname.MaxLength = 30;
            this.newname.Name = "newname";
            this.newname.Size = new System.Drawing.Size(200, 36);
            this.newname.TabIndex = 33;
            // 
            // newage
            // 
            this.newage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.newage.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.newage.Location = new System.Drawing.Point(292, 226);
            this.newage.MaxLength = 2;
            this.newage.Name = "newage";
            this.newage.Size = new System.Drawing.Size(200, 36);
            this.newage.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(206, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 34);
            this.label7.TabIndex = 31;
            this.label7.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(180, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 34);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(292, 293);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '•';
            this.textBox1.Size = new System.Drawing.Size(200, 36);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(292, 362);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.Size = new System.Drawing.Size(200, 36);
            this.textBox2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(138, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 34);
            this.label3.TabIndex = 36;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 34);
            this.label4.TabIndex = 37;
            this.label4.Text = "Confirm password";
            // 
            // Register_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newname);
            this.Controls.Add(this.newage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.wrongpw);
            this.Controls.Add(this.wrongage);
            this.Controls.Add(this.wrongname);
            this.Controls.Add(this.addplayer);
            this.Name = "Register_uc";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private Mybutton addplayer;
        private System.Windows.Forms.Label wrongname;
        private System.Windows.Forms.Label wrongage;
        private System.Windows.Forms.Label wrongpw;
        private Mybutton cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newname;
        private System.Windows.Forms.TextBox newage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
