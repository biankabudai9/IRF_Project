namespace beadando
{
    partial class Start_uc
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
            this.Register = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.ComboBox();
            this.color2 = new System.Windows.Forms.ComboBox();
            this.incorrect_message = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pw1 = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.pw2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cancel = new beadando.Mybutton();
            this.Go = new beadando.Mybutton();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Cyan;
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Register.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.Register.ForeColor = System.Drawing.Color.Black;
            this.Register.Location = new System.Drawing.Point(633, 529);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(200, 54);
            this.Register.TabIndex = 12;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.color1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.color1.ForeColor = System.Drawing.Color.Black;
            this.color1.FormattingEnabled = true;
            this.color1.Location = new System.Drawing.Point(188, 244);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(200, 35);
            this.color1.TabIndex = 15;
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.color2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.color2.ForeColor = System.Drawing.Color.Black;
            this.color2.FormattingEnabled = true;
            this.color2.Location = new System.Drawing.Point(666, 245);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(200, 35);
            this.color2.TabIndex = 16;
            // 
            // incorrect_message
            // 
            this.incorrect_message.AutoSize = true;
            this.incorrect_message.BackColor = System.Drawing.Color.Transparent;
            this.incorrect_message.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.incorrect_message.ForeColor = System.Drawing.Color.Red;
            this.incorrect_message.Location = new System.Drawing.Point(253, 327);
            this.incorrect_message.Name = "incorrect_message";
            this.incorrect_message.Size = new System.Drawing.Size(395, 28);
            this.incorrect_message.TabIndex = 17;
            this.incorrect_message.Text = "Incorrect username or password!";
            this.incorrect_message.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(537, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "Player 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(500, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 34);
            this.label4.TabIndex = 23;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(85, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 34);
            this.label5.TabIndex = 24;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(562, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 34);
            this.label6.TabIndex = 25;
            this.label6.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 34);
            this.label7.TabIndex = 26;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(511, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 34);
            this.label8.TabIndex = 27;
            this.label8.Text = "Password";
            // 
            // pw1
            // 
            this.pw1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pw1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.pw1.Location = new System.Drawing.Point(188, 166);
            this.pw1.MaxLength = 20;
            this.pw1.Name = "pw1";
            this.pw1.PasswordChar = '•';
            this.pw1.Size = new System.Drawing.Size(200, 36);
            this.pw1.TabIndex = 28;
            this.pw1.TextChanged += new System.EventHandler(this.pw1_TextChanged);
            // 
            // name1
            // 
            this.name1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.name1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.name1.Location = new System.Drawing.Point(188, 99);
            this.name1.MaxLength = 30;
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(200, 36);
            this.name1.TabIndex = 29;
            this.name1.TextChanged += new System.EventHandler(this.name1_TextChanged);
            // 
            // name2
            // 
            this.name2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.name2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.name2.Location = new System.Drawing.Point(666, 100);
            this.name2.MaxLength = 30;
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(200, 36);
            this.name2.TabIndex = 30;
            this.name2.TextChanged += new System.EventHandler(this.name2_TextChanged);
            // 
            // pw2
            // 
            this.pw2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pw2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.pw2.Location = new System.Drawing.Point(666, 167);
            this.pw2.MaxLength = 20;
            this.pw2.Name = "pw2";
            this.pw2.PasswordChar = '•';
            this.pw2.Size = new System.Drawing.Size(200, 36);
            this.pw2.TabIndex = 31;
            this.pw2.TextChanged += new System.EventHandler(this.pw2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(625, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 34);
            this.label9.TabIndex = 32;
            this.label9.Text = "First time here?";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(58, 529);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(177, 54);
            this.cancel.TabIndex = 18;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.Go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Go.Enabled = false;
            this.Go.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Go.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.Go.ForeColor = System.Drawing.Color.White;
            this.Go.Location = new System.Drawing.Point(350, 393);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(167, 69);
            this.Go.TabIndex = 11;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Start_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pw2);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.pw1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.incorrect_message);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Go);
            this.Name = "Start_uc";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

       
        private Mybutton Go;
        private System.Windows.Forms.Button Register;
       
        private System.Windows.Forms.ComboBox color1;
        private System.Windows.Forms.ComboBox color2;
        private System.Windows.Forms.Label incorrect_message;
        private Mybutton cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pw1;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.TextBox pw2;
        private System.Windows.Forms.Label label9;
    }
}
