namespace beadando
{
    partial class Welcome_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Form));
            this.results = new beadando.Mybutton();
            this.newgame = new beadando.Mybutton();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.results.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.results.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.results.ForeColor = System.Drawing.Color.White;
            this.results.Location = new System.Drawing.Point(514, 450);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(250, 80);
            this.results.TabIndex = 1;
            this.results.Text = "Results";
            this.results.UseVisualStyleBackColor = false;
            this.results.Click += new System.EventHandler(this.results_Click);
            // 
            // newgame
            // 
            this.newgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.newgame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newgame.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.newgame.ForeColor = System.Drawing.Color.White;
            this.newgame.Location = new System.Drawing.Point(514, 297);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(250, 80);
            this.newgame.TabIndex = 0;
            this.newgame.Text = "New game";
            this.newgame.UseVisualStyleBackColor = false;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 640);
            this.Controls.Add(this.results);
            this.Controls.Add(this.newgame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome_Form";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private Mybutton newgame;
        private Mybutton results;
    }
}

