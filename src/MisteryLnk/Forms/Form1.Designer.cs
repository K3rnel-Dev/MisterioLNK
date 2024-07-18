namespace MisteryLnk
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LogotypeProgram = new System.Windows.Forms.PictureBox();
            this.ProgramLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UrlPayload_Box = new System.Windows.Forms.TextBox();
            this.MethodDrop_Menu = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BuildBtn = new System.Windows.Forms.Button();
            this.ObfuscateChk = new System.Windows.Forms.CheckBox();
            this.IconSelectBtn = new System.Windows.Forms.Button();
            this.LnkIcon = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimazeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogotypeProgram)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LnkIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LogotypeProgram
            // 
            this.LogotypeProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogotypeProgram.Image = global::MisteryLnk.Properties.Resources._new;
            this.LogotypeProgram.Location = new System.Drawing.Point(8, 29);
            this.LogotypeProgram.Name = "LogotypeProgram";
            this.LogotypeProgram.Size = new System.Drawing.Size(86, 78);
            this.LogotypeProgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogotypeProgram.TabIndex = 0;
            this.LogotypeProgram.TabStop = false;
            this.LogotypeProgram.Click += new System.EventHandler(this.LogotypeProgram_Click);
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.AutoSize = true;
            this.ProgramLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramLabel.ForeColor = System.Drawing.Color.White;
            this.ProgramLabel.Location = new System.Drawing.Point(-3, 1);
            this.ProgramLabel.Name = "ProgramLabel";
            this.ProgramLabel.Size = new System.Drawing.Size(217, 28);
            this.ProgramLabel.TabIndex = 1;
            this.ProgramLabel.Text = "Misterio - Dropper";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UrlPayload_Box);
            this.groupBox1.Controls.Add(this.MethodDrop_Menu);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dropper Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "URL-Payload";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Method for Dropping";
            // 
            // UrlPayload_Box
            // 
            this.UrlPayload_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(67)))));
            this.UrlPayload_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlPayload_Box.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.UrlPayload_Box.Location = new System.Drawing.Point(4, 37);
            this.UrlPayload_Box.Name = "UrlPayload_Box";
            this.UrlPayload_Box.Size = new System.Drawing.Size(342, 20);
            this.UrlPayload_Box.TabIndex = 1;
            this.UrlPayload_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MethodDrop_Menu
            // 
            this.MethodDrop_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(67)))));
            this.MethodDrop_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethodDrop_Menu.ForeColor = System.Drawing.Color.White;
            this.MethodDrop_Menu.FormattingEnabled = true;
            this.MethodDrop_Menu.Items.AddRange(new object[] {
            "BAT",
            "CMD",
            "HTA",
            "LNK",
            "VBS"});
            this.MethodDrop_Menu.Location = new System.Drawing.Point(192, 71);
            this.MethodDrop_Menu.Name = "MethodDrop_Menu";
            this.MethodDrop_Menu.Size = new System.Drawing.Size(158, 21);
            this.MethodDrop_Menu.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BuildBtn);
            this.groupBox2.Controls.Add(this.ObfuscateChk);
            this.groupBox2.Controls.Add(this.IconSelectBtn);
            this.groupBox2.Controls.Add(this.LnkIcon);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(14, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Settings";
            // 
            // BuildBtn
            // 
            this.BuildBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(67)))));
            this.BuildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildBtn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildBtn.ForeColor = System.Drawing.Color.White;
            this.BuildBtn.Location = new System.Drawing.Point(6, 19);
            this.BuildBtn.Name = "BuildBtn";
            this.BuildBtn.Size = new System.Drawing.Size(218, 102);
            this.BuildBtn.TabIndex = 8;
            this.BuildBtn.Text = "Build Dropper";
            this.BuildBtn.UseVisualStyleBackColor = false;
            this.BuildBtn.Click += new System.EventHandler(this.BuildBtn_Click);
            // 
            // ObfuscateChk
            // 
            this.ObfuscateChk.AutoSize = true;
            this.ObfuscateChk.Location = new System.Drawing.Point(7, 127);
            this.ObfuscateChk.Name = "ObfuscateChk";
            this.ObfuscateChk.Size = new System.Drawing.Size(224, 17);
            this.ObfuscateChk.TabIndex = 7;
            this.ObfuscateChk.Text = "Obfuscate(Available: bat,cmd,vbs)";
            this.ObfuscateChk.UseVisualStyleBackColor = true;
            // 
            // IconSelectBtn
            // 
            this.IconSelectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(67)))));
            this.IconSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconSelectBtn.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IconSelectBtn.ForeColor = System.Drawing.Color.White;
            this.IconSelectBtn.Location = new System.Drawing.Point(237, 113);
            this.IconSelectBtn.Name = "IconSelectBtn";
            this.IconSelectBtn.Size = new System.Drawing.Size(110, 31);
            this.IconSelectBtn.TabIndex = 6;
            this.IconSelectBtn.Text = "SELECT ICON";
            this.IconSelectBtn.UseVisualStyleBackColor = false;
            this.IconSelectBtn.Click += new System.EventHandler(this.IconSelectBtn_Click);
            // 
            // LnkIcon
            // 
            this.LnkIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LnkIcon.Location = new System.Drawing.Point(237, 19);
            this.LnkIcon.Name = "LnkIcon";
            this.LnkIcon.Size = new System.Drawing.Size(111, 88);
            this.LnkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LnkIcon.TabIndex = 0;
            this.LnkIcon.TabStop = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(67)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(341, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(37, 23);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimazeBtn
            // 
            this.MinimazeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(67)))));
            this.MinimazeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimazeBtn.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimazeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimazeBtn.Location = new System.Drawing.Point(298, 2);
            this.MinimazeBtn.Name = "MinimazeBtn";
            this.MinimazeBtn.Size = new System.Drawing.Size(37, 23);
            this.MinimazeBtn.TabIndex = 5;
            this.MinimazeBtn.Text = "-";
            this.MinimazeBtn.UseVisualStyleBackColor = false;
            this.MinimazeBtn.Click += new System.EventHandler(this.MinimazeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(96, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 68);
            this.label3.TabIndex = 6;
            this.label3.Text = "Credists:\r\nAuthor: K3rnel-Dev\r\nGithub: https://k3rnel-dev\r\nTelegram: @k666_dev";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(380, 388);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinimazeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProgramLabel);
            this.Controls.Add(this.LogotypeProgram);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Misterio - [ MAIN ]";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.LogotypeProgram)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LnkIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogotypeProgram;
        private System.Windows.Forms.Label ProgramLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimazeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UrlPayload_Box;
        private System.Windows.Forms.ComboBox MethodDrop_Menu;
        private System.Windows.Forms.CheckBox ObfuscateChk;
        private System.Windows.Forms.Button IconSelectBtn;
        private System.Windows.Forms.PictureBox LnkIcon;
        private System.Windows.Forms.Button BuildBtn;
        private System.Windows.Forms.Label label3;
    }
}

