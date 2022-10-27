namespace Salary_Projection_GUI_App_v2
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
            this.priceGrpBx = new System.Windows.Forms.GroupBox();
            this.priceTxtBx = new System.Windows.Forms.TextBox();
            this.interestGrpBx = new System.Windows.Forms.GroupBox();
            this.interestTxtBx = new System.Windows.Forms.TextBox();
            this.yearsGrpBx = new System.Windows.Forms.GroupBox();
            this.yearsTxtBx = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.answerLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.priceGrpBx.SuspendLayout();
            this.interestGrpBx.SuspendLayout();
            this.yearsGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceGrpBx
            // 
            this.priceGrpBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.priceGrpBx.Controls.Add(this.priceTxtBx);
            this.priceGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceGrpBx.Location = new System.Drawing.Point(39, 169);
            this.priceGrpBx.Name = "priceGrpBx";
            this.priceGrpBx.Size = new System.Drawing.Size(271, 69);
            this.priceGrpBx.TabIndex = 0;
            this.priceGrpBx.TabStop = false;
            this.priceGrpBx.Text = "Car Price (decimal)";
            // 
            // priceTxtBx
            // 
            this.priceTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxtBx.Location = new System.Drawing.Point(16, 19);
            this.priceTxtBx.Name = "priceTxtBx";
            this.priceTxtBx.Size = new System.Drawing.Size(249, 22);
            this.priceTxtBx.TabIndex = 0;
            // 
            // interestGrpBx
            // 
            this.interestGrpBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.interestGrpBx.Controls.Add(this.interestTxtBx);
            this.interestGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestGrpBx.Location = new System.Drawing.Point(316, 169);
            this.interestGrpBx.Name = "interestGrpBx";
            this.interestGrpBx.Size = new System.Drawing.Size(271, 69);
            this.interestGrpBx.TabIndex = 1;
            this.interestGrpBx.TabStop = false;
            this.interestGrpBx.Text = "Ann. Rate Of Interest (% decimal)";
            // 
            // interestTxtBx
            // 
            this.interestTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestTxtBx.Location = new System.Drawing.Point(16, 19);
            this.interestTxtBx.Name = "interestTxtBx";
            this.interestTxtBx.Size = new System.Drawing.Size(249, 22);
            this.interestTxtBx.TabIndex = 0;
            // 
            // yearsGrpBx
            // 
            this.yearsGrpBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.yearsGrpBx.Controls.Add(this.yearsTxtBx);
            this.yearsGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsGrpBx.Location = new System.Drawing.Point(176, 244);
            this.yearsGrpBx.Name = "yearsGrpBx";
            this.yearsGrpBx.Size = new System.Drawing.Size(271, 69);
            this.yearsGrpBx.TabIndex = 2;
            this.yearsGrpBx.TabStop = false;
            this.yearsGrpBx.Text = "Loan Period >= 2 yrs (integer)";
            // 
            // yearsTxtBx
            // 
            this.yearsTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsTxtBx.Location = new System.Drawing.Point(16, 19);
            this.yearsTxtBx.Name = "yearsTxtBx";
            this.yearsTxtBx.Size = new System.Drawing.Size(249, 22);
            this.yearsTxtBx.TabIndex = 0;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(39, 348);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(107, 41);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(480, 348);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(107, 41);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // answerLbl
            // 
            this.answerLbl.BackColor = System.Drawing.Color.Aqua;
            this.answerLbl.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLbl.Location = new System.Drawing.Point(176, 348);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(271, 37);
            this.answerLbl.TabIndex = 5;
            this.answerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(632, 65);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(90, 324);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "E\r\n\r\nX\r\n\r\nI\r\n\r\nT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.Yellow;
            this.titleLbl.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(39, 77);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(548, 64);
            this.titleLbl.TabIndex = 7;
            this.titleLbl.Text = "Dalveer Car Loan Financing";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.yearsGrpBx);
            this.Controls.Add(this.interestGrpBx);
            this.Controls.Add(this.priceGrpBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.priceGrpBx.ResumeLayout(false);
            this.priceGrpBx.PerformLayout();
            this.interestGrpBx.ResumeLayout(false);
            this.interestGrpBx.PerformLayout();
            this.yearsGrpBx.ResumeLayout(false);
            this.yearsGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox priceGrpBx;
        private System.Windows.Forms.TextBox priceTxtBx;
        private System.Windows.Forms.GroupBox interestGrpBx;
        private System.Windows.Forms.TextBox interestTxtBx;
        private System.Windows.Forms.GroupBox yearsGrpBx;
        private System.Windows.Forms.TextBox yearsTxtBx;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label titleLbl;
    }
}

