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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.results.Cursor = System.Windows.Forms.Cursors.Hand;
            this.results.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.results.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.results.ForeColor = System.Drawing.Color.White;
            this.results.Location = new System.Drawing.Point(769, 465);
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
            this.newgame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newgame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newgame.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.newgame.ForeColor = System.Drawing.Color.White;
            this.newgame.Location = new System.Drawing.Point(769, 271);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(250, 80);
            this.newgame.TabIndex = 0;
            this.newgame.Text = "New game";
            this.newgame.UseVisualStyleBackColor = false;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(754, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(283, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome!";
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.results);
            this.Controls.Add(this.newgame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Welcome_Form";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mybutton newgame;
        private Mybutton results;
        private System.Windows.Forms.Label label1;
    }
}

