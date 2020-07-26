namespace Lidocain
{
    partial class HENbox
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
            this.quittoolbtn = new System.Windows.Forms.Button();
            this.okdaddybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(26, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oh shit, it seems like your console is running HEN!\r\nWell, that doesn\'t mean you " +
    "can\'t use this tool,\r\nbut you might run into problems when dumping LV1\r\nas PS3HE" +
    "N doesn\'t have full access to LV1.";
            // 
            // quittoolbtn
            // 
            this.quittoolbtn.BackColor = System.Drawing.Color.White;
            this.quittoolbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quittoolbtn.Location = new System.Drawing.Point(12, 12);
            this.quittoolbtn.Name = "quittoolbtn";
            this.quittoolbtn.Size = new System.Drawing.Size(75, 23);
            this.quittoolbtn.TabIndex = 1;
            this.quittoolbtn.Text = "Quit Tool";
            this.quittoolbtn.UseVisualStyleBackColor = false;
            this.quittoolbtn.Click += new System.EventHandler(this.quittoolbtn_Click);
            // 
            // okdaddybtn
            // 
            this.okdaddybtn.BackColor = System.Drawing.Color.White;
            this.okdaddybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okdaddybtn.Location = new System.Drawing.Point(342, 12);
            this.okdaddybtn.Name = "okdaddybtn";
            this.okdaddybtn.Size = new System.Drawing.Size(75, 23);
            this.okdaddybtn.TabIndex = 2;
            this.okdaddybtn.Text = "OK Daddy";
            this.okdaddybtn.UseVisualStyleBackColor = false;
            this.okdaddybtn.Click += new System.EventHandler(this.okdaddybtn_Click);
            // 
            // HENbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lidocain.Properties.Resources.HENdetected;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 312);
            this.Controls.Add(this.okdaddybtn);
            this.Controls.Add(this.quittoolbtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HENbox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "HEN detected!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quittoolbtn;
        private System.Windows.Forms.Button okdaddybtn;
    }
}