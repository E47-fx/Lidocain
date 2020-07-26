namespace Lidocain
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ps3mapi = new System.Windows.Forms.RadioButton();
            this.ccapi = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.ipbox = new System.Windows.Forms.TextBox();
            this.cnnctbtn = new System.Windows.Forms.Button();
            this.dumplv1btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dumpcstsize = new System.Windows.Forms.Button();
            this.dumpmemfull = new System.Windows.Forms.Button();
            this.dumprsxbtn = new System.Windows.Forms.Button();
            this.dumplv2btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.rbt = new System.Windows.Forms.CheckBox();
            this.sftrbt = new System.Windows.Forms.RadioButton();
            this.hrdrbt = new System.Windows.Forms.RadioButton();
            this.qckrbt = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ps3mapi);
            this.groupBox1.Controls.Add(this.ccapi);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ipbox);
            this.groupBox1.Controls.Add(this.cnnctbtn);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // ps3mapi
            // 
            this.ps3mapi.AutoSize = true;
            this.ps3mapi.Location = new System.Drawing.Point(152, 51);
            this.ps3mapi.Name = "ps3mapi";
            this.ps3mapi.Size = new System.Drawing.Size(68, 17);
            this.ps3mapi.TabIndex = 5;
            this.ps3mapi.TabStop = true;
            this.ps3mapi.Text = "PS3MAPI";
            this.ps3mapi.UseVisualStyleBackColor = true;
            // 
            // ccapi
            // 
            this.ccapi.AutoSize = true;
            this.ccapi.Location = new System.Drawing.Point(7, 51);
            this.ccapi.Name = "ccapi";
            this.ccapi.Size = new System.Drawing.Size(56, 17);
            this.ccapi.TabIndex = 4;
            this.ccapi.TabStop = true;
            this.ccapi.Text = "CCAPI";
            this.ccapi.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(6, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Disconnect From PS3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ipbox
            // 
            this.ipbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ipbox.ForeColor = System.Drawing.Color.Green;
            this.ipbox.Location = new System.Drawing.Point(6, 25);
            this.ipbox.Name = "ipbox";
            this.ipbox.Size = new System.Drawing.Size(217, 21);
            this.ipbox.TabIndex = 2;
            this.ipbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cnnctbtn
            // 
            this.cnnctbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnnctbtn.ForeColor = System.Drawing.Color.Green;
            this.cnnctbtn.Location = new System.Drawing.Point(6, 73);
            this.cnnctbtn.Name = "cnnctbtn";
            this.cnnctbtn.Size = new System.Drawing.Size(217, 23);
            this.cnnctbtn.TabIndex = 0;
            this.cnnctbtn.Text = "Connect To PS3";
            this.cnnctbtn.UseVisualStyleBackColor = true;
            this.cnnctbtn.Click += new System.EventHandler(this.cnnctbtn_Click);
            // 
            // dumplv1btn
            // 
            this.dumplv1btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumplv1btn.ForeColor = System.Drawing.Color.Green;
            this.dumplv1btn.Location = new System.Drawing.Point(6, 19);
            this.dumplv1btn.Name = "dumplv1btn";
            this.dumplv1btn.Size = new System.Drawing.Size(217, 23);
            this.dumplv1btn.TabIndex = 1;
            this.dumplv1btn.Text = "Dump LV1 Memory";
            this.dumplv1btn.UseVisualStyleBackColor = true;
            this.dumplv1btn.Click += new System.EventHandler(this.dumplv1btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dumpcstsize);
            this.groupBox2.Controls.Add(this.dumpmemfull);
            this.groupBox2.Controls.Add(this.dumprsxbtn);
            this.groupBox2.Controls.Add(this.dumplv2btn);
            this.groupBox2.Controls.Add(this.dumplv1btn);
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 171);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dump File To Computer";
            // 
            // dumpcstsize
            // 
            this.dumpcstsize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumpcstsize.ForeColor = System.Drawing.Color.Green;
            this.dumpcstsize.Location = new System.Drawing.Point(6, 135);
            this.dumpcstsize.Name = "dumpcstsize";
            this.dumpcstsize.Size = new System.Drawing.Size(217, 23);
            this.dumpcstsize.TabIndex = 5;
            this.dumpcstsize.Text = "Specify Dump Size";
            this.dumpcstsize.UseVisualStyleBackColor = true;
            this.dumpcstsize.Click += new System.EventHandler(this.dumpcstsize_Click);
            // 
            // dumpmemfull
            // 
            this.dumpmemfull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumpmemfull.ForeColor = System.Drawing.Color.Green;
            this.dumpmemfull.Location = new System.Drawing.Point(6, 106);
            this.dumpmemfull.Name = "dumpmemfull";
            this.dumpmemfull.Size = new System.Drawing.Size(217, 23);
            this.dumpmemfull.TabIndex = 4;
            this.dumpmemfull.Text = "Dump Entire Memory";
            this.dumpmemfull.UseVisualStyleBackColor = true;
            this.dumpmemfull.Click += new System.EventHandler(this.dumpmemfull_Click);
            // 
            // dumprsxbtn
            // 
            this.dumprsxbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumprsxbtn.ForeColor = System.Drawing.Color.Green;
            this.dumprsxbtn.Location = new System.Drawing.Point(7, 77);
            this.dumprsxbtn.Name = "dumprsxbtn";
            this.dumprsxbtn.Size = new System.Drawing.Size(216, 23);
            this.dumprsxbtn.TabIndex = 3;
            this.dumprsxbtn.Text = "Dump RSX Memory";
            this.dumprsxbtn.UseVisualStyleBackColor = true;
            this.dumprsxbtn.Click += new System.EventHandler(this.dumprsxbtn_Click);
            // 
            // dumplv2btn
            // 
            this.dumplv2btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumplv2btn.ForeColor = System.Drawing.Color.Green;
            this.dumplv2btn.Location = new System.Drawing.Point(6, 48);
            this.dumplv2btn.Name = "dumplv2btn";
            this.dumplv2btn.Size = new System.Drawing.Size(217, 23);
            this.dumplv2btn.TabIndex = 2;
            this.dumplv2btn.Text = "Dump LV2 Memory";
            this.dumplv2btn.UseVisualStyleBackColor = true;
            this.dumplv2btn.Click += new System.EventHandler(this.dumplv2btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.qckrbt);
            this.groupBox3.Controls.Add(this.hrdrbt);
            this.groupBox3.Controls.Add(this.sftrbt);
            this.groupBox3.Controls.Add(this.rbt);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(12, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 77);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(167, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Credits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(9, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Status:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.Crimson;
            this.status.Location = new System.Drawing.Point(48, 412);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(25, 13);
            this.status.TabIndex = 6;
            this.status.Text = "Idle";
            // 
            // rbt
            // 
            this.rbt.AutoSize = true;
            this.rbt.Location = new System.Drawing.Point(7, 20);
            this.rbt.Name = "rbt";
            this.rbt.Size = new System.Drawing.Size(160, 17);
            this.rbt.TabIndex = 4;
            this.rbt.Text = "Reboot Console After Dump";
            this.rbt.UseVisualStyleBackColor = true;
            // 
            // sftrbt
            // 
            this.sftrbt.AutoSize = true;
            this.sftrbt.Location = new System.Drawing.Point(7, 49);
            this.sftrbt.Name = "sftrbt";
            this.sftrbt.Size = new System.Drawing.Size(45, 17);
            this.sftrbt.TabIndex = 6;
            this.sftrbt.TabStop = true;
            this.sftrbt.Text = "Soft";
            this.sftrbt.UseVisualStyleBackColor = true;
            // 
            // hrdrbt
            // 
            this.hrdrbt.AutoSize = true;
            this.hrdrbt.Location = new System.Drawing.Point(82, 49);
            this.hrdrbt.Name = "hrdrbt";
            this.hrdrbt.Size = new System.Drawing.Size(48, 17);
            this.hrdrbt.TabIndex = 7;
            this.hrdrbt.TabStop = true;
            this.hrdrbt.Text = "Hard";
            this.hrdrbt.UseVisualStyleBackColor = true;
            // 
            // qckrbt
            // 
            this.qckrbt.AutoSize = true;
            this.qckrbt.Location = new System.Drawing.Point(169, 49);
            this.qckrbt.Name = "qckrbt";
            this.qckrbt.Size = new System.Drawing.Size(51, 17);
            this.qckrbt.TabIndex = 8;
            this.qckrbt.TabStop = true;
            this.qckrbt.Text = "Quick";
            this.qckrbt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(253, 434);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lidocain by E-47";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ipbox;
        private System.Windows.Forms.Button cnnctbtn;
        private System.Windows.Forms.Button dumplv1btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dumpcstsize;
        private System.Windows.Forms.Button dumpmemfull;
        private System.Windows.Forms.Button dumprsxbtn;
        private System.Windows.Forms.Button dumplv2btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton ps3mapi;
        private System.Windows.Forms.RadioButton ccapi;
        private System.Windows.Forms.RadioButton qckrbt;
        private System.Windows.Forms.RadioButton hrdrbt;
        private System.Windows.Forms.RadioButton sftrbt;
        private System.Windows.Forms.CheckBox rbt;
    }
}

