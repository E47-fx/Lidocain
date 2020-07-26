namespace Lidocain
{
    partial class dumpsize
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
            this.dumpsizeval = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dmpbtn = new System.Windows.Forms.Button();
            this.startaddr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dumpsizeval)).BeginInit();
            this.SuspendLayout();
            // 
            // dumpsizeval
            // 
            this.dumpsizeval.Location = new System.Drawing.Point(12, 12);
            this.dumpsizeval.Maximum = 256;
            this.dumpsizeval.Minimum = 1;
            this.dumpsizeval.Name = "dumpsizeval";
            this.dumpsizeval.Size = new System.Drawing.Size(557, 45);
            this.dumpsizeval.TabIndex = 0;
            this.dumpsizeval.Value = 1;
            this.dumpsizeval.Scroll += new System.EventHandler(this.dumpsizeval_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dump Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(96, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "1 Megabyte";
            // 
            // dmpbtn
            // 
            this.dmpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dmpbtn.Location = new System.Drawing.Point(434, 59);
            this.dmpbtn.Name = "dmpbtn";
            this.dmpbtn.Size = new System.Drawing.Size(135, 23);
            this.dmpbtn.TabIndex = 3;
            this.dmpbtn.Text = "Dump To Computer";
            this.dmpbtn.UseVisualStyleBackColor = true;
            this.dmpbtn.Click += new System.EventHandler(this.dmpbtn_Click);
            // 
            // startaddr
            // 
            this.startaddr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.startaddr.ForeColor = System.Drawing.Color.Green;
            this.startaddr.Location = new System.Drawing.Point(13, 59);
            this.startaddr.Name = "startaddr";
            this.startaddr.Size = new System.Drawing.Size(163, 21);
            this.startaddr.TabIndex = 4;
            this.startaddr.Text = "Start Address";
            // 
            // dumpsize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(581, 111);
            this.Controls.Add(this.startaddr);
            this.Controls.Add(this.dmpbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dumpsizeval);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dumpsize";
            this.Text = "Specify Dump Size";
            ((System.ComponentModel.ISupportInitialize)(this.dumpsizeval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar dumpsizeval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dmpbtn;
        private System.Windows.Forms.TextBox startaddr;
    }
}