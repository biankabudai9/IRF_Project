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
            this.colorlist1 = new System.Windows.Forms.ComboBox();
            this.colorlist2 = new System.Windows.Forms.ComboBox();
            this.go = new System.Windows.Forms.Button();
            this.hint_button1 = new beadando.Hint_button();
            this.SuspendLayout();
            // 
            // colorlist1
            // 
            this.colorlist1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorlist1.FormattingEnabled = true;
            this.colorlist1.Location = new System.Drawing.Point(514, 80);
            this.colorlist1.Name = "colorlist1";
            this.colorlist1.Size = new System.Drawing.Size(121, 24);
            this.colorlist1.TabIndex = 4;
            // 
            // colorlist2
            // 
            this.colorlist2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorlist2.FormattingEnabled = true;
            this.colorlist2.Location = new System.Drawing.Point(514, 213);
            this.colorlist2.Name = "colorlist2";
            this.colorlist2.Size = new System.Drawing.Size(121, 24);
            this.colorlist2.TabIndex = 5;
            // 
            // go
            // 
            this.go.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.go.Location = new System.Drawing.Point(796, 392);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(111, 51);
            this.go.TabIndex = 8;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // hint_button1
            // 
            this.hint_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.hint_button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hint_button1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.hint_button1.ForeColor = System.Drawing.Color.White;
            this.hint_button1.Location = new System.Drawing.Point(182, 262);
            this.hint_button1.Name = "hint_button1";
            this.hint_button1.Size = new System.Drawing.Size(35, 35);
            this.hint_button1.TabIndex = 9;
            this.hint_button1.Text = "hint_button1";
            this.hint_button1.UseVisualStyleBackColor = false;
            // 
            // Start_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hint_button1);
            this.Controls.Add(this.go);
            this.Controls.Add(this.colorlist2);
            this.Controls.Add(this.colorlist1);
            this.Name = "Start_uc";
            this.Size = new System.Drawing.Size(1175, 619);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox colorlist1;
        private System.Windows.Forms.ComboBox colorlist2;
        private System.Windows.Forms.Button go;
        private Hint_button hint_button1;
    }
}
