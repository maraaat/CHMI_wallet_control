namespace CHMI2.Forms
{
    partial class ReservatForm
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
            this.BackBtn2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResBal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProcTb1 = new System.Windows.Forms.TextBox();
            this.ResProc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WithdrawTb1 = new System.Windows.Forms.TextBox();
            this.ProcBtn1 = new System.Windows.Forms.Button();
            this.WthdrBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackBtn2
            // 
            this.BackBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.BackBtn2.Image = global::CHMI2.Properties.Resources.free_icon_turn_back_3585896;
            this.BackBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackBtn2.Location = new System.Drawing.Point(277, 410);
            this.BackBtn2.Name = "BackBtn2";
            this.BackBtn2.Size = new System.Drawing.Size(95, 39);
            this.BackBtn2.TabIndex = 0;
            this.BackBtn2.Text = "Назад";
            this.BackBtn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackBtn2.UseVisualStyleBackColor = true;
            this.BackBtn2.Click += new System.EventHandler(this.BackBtn2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(173, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Отложенный бюджет (руб.):";
            // 
            // ResBal
            // 
            this.ResBal.AutoSize = true;
            this.ResBal.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResBal.Location = new System.Drawing.Point(255, 52);
            this.ResBal.Name = "ResBal";
            this.ResBal.Size = new System.Drawing.Size(97, 23);
            this.ResBal.TabIndex = 9;
            this.ResBal.Text = "100.000.000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Текущий процент (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Резервирование (копилка)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Новый процент:";
            // 
            // ProcTb1
            // 
            this.ProcTb1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProcTb1.Location = new System.Drawing.Point(159, 128);
            this.ProcTb1.Name = "ProcTb1";
            this.ProcTb1.Size = new System.Drawing.Size(135, 30);
            this.ProcTb1.TabIndex = 13;
            // 
            // ResProc
            // 
            this.ResProc.AutoSize = true;
            this.ResProc.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResProc.Location = new System.Drawing.Point(217, 89);
            this.ResProc.Name = "ResProc";
            this.ResProc.Size = new System.Drawing.Size(32, 23);
            this.ResProc.TabIndex = 14;
            this.ResProc.Text = "5.5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Вывод на основной счет (руб.):";
            // 
            // WithdrawTb1
            // 
            this.WithdrawTb1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WithdrawTb1.Location = new System.Drawing.Point(12, 286);
            this.WithdrawTb1.Name = "WithdrawTb1";
            this.WithdrawTb1.Size = new System.Drawing.Size(198, 30);
            this.WithdrawTb1.TabIndex = 17;
            // 
            // ProcBtn1
            // 
            this.ProcBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ProcBtn1.Location = new System.Drawing.Point(159, 173);
            this.ProcBtn1.Name = "ProcBtn1";
            this.ProcBtn1.Size = new System.Drawing.Size(135, 34);
            this.ProcBtn1.TabIndex = 19;
            this.ProcBtn1.Text = "Подтвердить";
            this.ProcBtn1.UseVisualStyleBackColor = true;
            this.ProcBtn1.Click += new System.EventHandler(this.ProcBtn1_Click);
            // 
            // WthdrBtn2
            // 
            this.WthdrBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.WthdrBtn2.Location = new System.Drawing.Point(226, 286);
            this.WthdrBtn2.Name = "WthdrBtn2";
            this.WthdrBtn2.Size = new System.Drawing.Size(126, 34);
            this.WthdrBtn2.TabIndex = 20;
            this.WthdrBtn2.Text = "Подтвердить";
            this.WthdrBtn2.UseVisualStyleBackColor = true;
            this.WthdrBtn2.Click += new System.EventHandler(this.WthdrBtn2_Click);
            // 
            // ReservatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.WthdrBtn2);
            this.Controls.Add(this.ProcBtn1);
            this.Controls.Add(this.WithdrawTb1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ResProc);
            this.Controls.Add(this.ProcTb1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResBal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackBtn2);
            this.Name = "ReservatForm";
            this.Text = "ReservatForm";
            this.Load += new System.EventHandler(this.ReservatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackBtn2;
        private Label label4;
        private Label label2;
        private Label ResBal;
        private Label label1;
        private Label label3;
        private Label label6;
        private TextBox ProcTb1;
        private Label ResProc;
        private Label label8;
        private TextBox WithdrawTb1;
        private Button ProcBtn1;
        private Button WthdrBtn2;
    }
}