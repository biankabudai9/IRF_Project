namespace beadando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newgame = new System.Windows.Forms.Button();
            this.eredmenyek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newgame
            // 
            this.newgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.newgame.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newgame.Location = new System.Drawing.Point(723, 278);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(184, 72);
            this.newgame.TabIndex = 0;
            this.newgame.Text = "Új játék";
            this.newgame.UseVisualStyleBackColor = false;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // eredmenyek
            // 
            this.eredmenyek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eredmenyek.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eredmenyek.Location = new System.Drawing.Point(759, 419);
            this.eredmenyek.Name = "eredmenyek";
            this.eredmenyek.Size = new System.Drawing.Size(234, 72);
            this.eredmenyek.TabIndex = 2;
            this.eredmenyek.Text = "Eredmények";
            this.eredmenyek.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1066, 585);
            this.Controls.Add(this.eredmenyek);
            this.Controls.Add(this.newgame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newgame;
        private System.Windows.Forms.Button eredmenyek;
    }
}

