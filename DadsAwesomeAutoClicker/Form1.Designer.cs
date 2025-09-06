
namespace DadsAwesomeAutoClicker
{
    partial class DadsAutoClicker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            unRegisterKeys();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadsAutoClicker));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtVal = new System.Windows.Forms.Label();
            this.dtLbl = new System.Windows.Forms.Label();
            this.MsVal = new System.Windows.Forms.Label();
            this.MsLbl = new System.Windows.Forms.Label();
            this.CpsLbl = new System.Windows.Forms.Label();
            this.CpsTextBx = new System.Windows.Forms.TextBox();
            this.SelPos = new System.Windows.Forms.Button();
            this.YPos = new System.Windows.Forms.Label();
            this.XPos = new System.Windows.Forms.Label();
            this.YTitle = new System.Windows.Forms.Label();
            this.XTitle = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.dtVal);
            this.panel1.Controls.Add(this.dtLbl);
            this.panel1.Controls.Add(this.MsVal);
            this.panel1.Controls.Add(this.MsLbl);
            this.panel1.Controls.Add(this.CpsLbl);
            this.panel1.Controls.Add(this.CpsTextBx);
            this.panel1.Controls.Add(this.SelPos);
            this.panel1.Controls.Add(this.YPos);
            this.panel1.Controls.Add(this.XPos);
            this.panel1.Controls.Add(this.YTitle);
            this.panel1.Controls.Add(this.XTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 715);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtVal
            // 
            this.dtVal.AutoSize = true;
            this.dtVal.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtVal.Location = new System.Drawing.Point(238, 178);
            this.dtVal.Name = "dtVal";
            this.dtVal.Size = new System.Drawing.Size(85, 39);
            this.dtVal.TabIndex = 10;
            this.dtVal.Text = "0000";
            // 
            // dtLbl
            // 
            this.dtLbl.AutoSize = true;
            this.dtLbl.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtLbl.Location = new System.Drawing.Point(16, 178);
            this.dtLbl.Name = "dtLbl";
            this.dtLbl.Size = new System.Drawing.Size(225, 39);
            this.dtLbl.TabIndex = 9;
            this.dtLbl.Text = "dt milliseconds: ";
            // 
            // MsVal
            // 
            this.MsVal.AutoSize = true;
            this.MsVal.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MsVal.Location = new System.Drawing.Point(296, 358);
            this.MsVal.Name = "MsVal";
            this.MsVal.Size = new System.Drawing.Size(68, 39);
            this.MsVal.TabIndex = 8;
            this.MsVal.Text = "000";
            // 
            // MsLbl
            // 
            this.MsLbl.AutoSize = true;
            this.MsLbl.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MsLbl.Location = new System.Drawing.Point(118, 358);
            this.MsLbl.Name = "MsLbl";
            this.MsLbl.Size = new System.Drawing.Size(188, 39);
            this.MsLbl.TabIndex = 7;
            this.MsLbl.Text = "milliseconds: ";
            // 
            // CpsLbl
            // 
            this.CpsLbl.AutoSize = true;
            this.CpsLbl.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CpsLbl.Location = new System.Drawing.Point(118, 282);
            this.CpsLbl.Name = "CpsLbl";
            this.CpsLbl.Size = new System.Drawing.Size(246, 39);
            this.CpsLbl.TabIndex = 6;
            this.CpsLbl.Text = "Clicks Per Second";
            // 
            // CpsTextBx
            // 
            this.CpsTextBx.Location = new System.Drawing.Point(118, 324);
            this.CpsTextBx.Name = "CpsTextBx";
            this.CpsTextBx.Size = new System.Drawing.Size(117, 31);
            this.CpsTextBx.TabIndex = 5;
            this.CpsTextBx.Text = "10";
            // 
            // SelPos
            // 
            this.SelPos.Location = new System.Drawing.Point(403, 29);
            this.SelPos.Name = "SelPos";
            this.SelPos.Size = new System.Drawing.Size(195, 87);
            this.SelPos.TabIndex = 4;
            this.SelPos.Text = "Start Position Get";
            this.SelPos.UseVisualStyleBackColor = true;
            this.SelPos.Click += new System.EventHandler(this.SelPos_Click);
            // 
            // YPos
            // 
            this.YPos.AutoSize = true;
            this.YPos.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YPos.Location = new System.Drawing.Point(67, 92);
            this.YPos.Name = "YPos";
            this.YPos.Size = new System.Drawing.Size(68, 39);
            this.YPos.TabIndex = 3;
            this.YPos.Text = "000";
            // 
            // XPos
            // 
            this.XPos.AutoSize = true;
            this.XPos.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XPos.Location = new System.Drawing.Point(67, 29);
            this.XPos.Name = "XPos";
            this.XPos.Size = new System.Drawing.Size(68, 39);
            this.XPos.TabIndex = 2;
            this.XPos.Text = "000";
            // 
            // YTitle
            // 
            this.YTitle.AutoSize = true;
            this.YTitle.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YTitle.Location = new System.Drawing.Point(16, 92);
            this.YTitle.Name = "YTitle";
            this.YTitle.Size = new System.Drawing.Size(43, 39);
            this.YTitle.TabIndex = 1;
            this.YTitle.Text = "Y:";
            // 
            // XTitle
            // 
            this.XTitle.AutoSize = true;
            this.XTitle.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XTitle.Location = new System.Drawing.Point(16, 29);
            this.XTitle.Name = "XTitle";
            this.XTitle.Size = new System.Drawing.Size(45, 39);
            this.XTitle.TabIndex = 0;
            this.XTitle.Text = "X:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(469, 666);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(68, 25);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "Status?";
            // 
            // DadsAutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1343, 754);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DadsAutoClicker";
            this.Text = "Dads Auto Clicker v1.0";
            this.Load += new System.EventHandler(this.DadsAutoClicker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label YPos;
        private System.Windows.Forms.Label XPos;
        private System.Windows.Forms.Label YTitle;
        private System.Windows.Forms.Label XTitle;
        private System.Windows.Forms.Button SelPos;
        private System.Windows.Forms.Label CpsLbl;
        private System.Windows.Forms.TextBox CpsTextBx;
        private System.Windows.Forms.Label MsVal;
        private System.Windows.Forms.Label MsLbl;
        private System.Windows.Forms.Label dtVal;
        private System.Windows.Forms.Label dtLbl;
        private System.Windows.Forms.Label StatusLabel;
    }
}

