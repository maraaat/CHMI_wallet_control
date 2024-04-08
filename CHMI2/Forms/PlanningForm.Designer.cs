namespace CHMI2.Forms
{
    partial class PlanningForm
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
            this.BackBtn4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BudgetCb1 = new System.Windows.Forms.ComboBox();
            this.DepTb1 = new System.Windows.Forms.TextBox();
            this.DepBtn1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WthdrwTb1 = new System.Windows.Forms.TextBox();
            this.WthdrwBtn1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelPlan = new System.Windows.Forms.Label();
            this.LabelBal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackBtn4
            // 
            this.BackBtn4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.BackBtn4.Image = global::CHMI2.Properties.Resources.free_icon_turn_back_3585896;
            this.BackBtn4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackBtn4.Location = new System.Drawing.Point(284, 414);
            this.BackBtn4.Name = "BackBtn4";
            this.BackBtn4.Size = new System.Drawing.Size(88, 35);
            this.BackBtn4.TabIndex = 0;
            this.BackBtn4.Text = "Назад";
            this.BackBtn4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackBtn4.UseVisualStyleBackColor = true;
            this.BackBtn4.Click += new System.EventHandler(this.BackBtn4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Бюджеты";
            // 
            // button1
            // 
            this.button1.Image = global::CHMI2.Properties.Resources.free_icon_add_button_2740600;
            this.button1.Location = new System.Drawing.Point(333, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BudgetCb1
            // 
            this.BudgetCb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BudgetCb1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BudgetCb1.FormattingEnabled = true;
            this.BudgetCb1.Location = new System.Drawing.Point(12, 98);
            this.BudgetCb1.Name = "BudgetCb1";
            this.BudgetCb1.Size = new System.Drawing.Size(335, 31);
            this.BudgetCb1.TabIndex = 3;
            this.BudgetCb1.TextChanged += new System.EventHandler(this.BudgetCb1_TextChanged);
            // 
            // DepTb1
            // 
            this.DepTb1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DepTb1.Location = new System.Drawing.Point(200, 227);
            this.DepTb1.Name = "DepTb1";
            this.DepTb1.Size = new System.Drawing.Size(147, 30);
            this.DepTb1.TabIndex = 5;
            // 
            // DepBtn1
            // 
            this.DepBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.DepBtn1.Location = new System.Drawing.Point(126, 263);
            this.DepBtn1.Name = "DepBtn1";
            this.DepBtn1.Size = new System.Drawing.Size(126, 34);
            this.DepBtn1.TabIndex = 6;
            this.DepBtn1.Text = "Подтвердить";
            this.DepBtn1.UseVisualStyleBackColor = true;
            this.DepBtn1.Click += new System.EventHandler(this.DepBtn1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пополнить на (руб.): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(79, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Снять (руб.): ";
            // 
            // WthdrwTb1
            // 
            this.WthdrwTb1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WthdrwTb1.Location = new System.Drawing.Point(200, 305);
            this.WthdrwTb1.Name = "WthdrwTb1";
            this.WthdrwTb1.Size = new System.Drawing.Size(147, 30);
            this.WthdrwTb1.TabIndex = 8;
            // 
            // WthdrwBtn1
            // 
            this.WthdrwBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.WthdrwBtn1.Location = new System.Drawing.Point(127, 341);
            this.WthdrwBtn1.Name = "WthdrwBtn1";
            this.WthdrwBtn1.Size = new System.Drawing.Size(126, 34);
            this.WthdrwBtn1.TabIndex = 9;
            this.WthdrwBtn1.Text = "Подтвердить";
            this.WthdrwBtn1.UseVisualStyleBackColor = true;
            this.WthdrwBtn1.Click += new System.EventHandler(this.WthdrwBtn1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Текущий баланс (руб.): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(106, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Цель (руб.):";
            // 
            // LabelPlan
            // 
            this.LabelPlan.AutoSize = true;
            this.LabelPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPlan.Location = new System.Drawing.Point(217, 188);
            this.LabelPlan.Name = "LabelPlan";
            this.LabelPlan.Size = new System.Drawing.Size(53, 23);
            this.LabelPlan.TabIndex = 12;
            this.LabelPlan.Text = "10000";
            // 
            // LabelBal
            // 
            this.LabelBal.AutoSize = true;
            this.LabelBal.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelBal.Location = new System.Drawing.Point(217, 147);
            this.LabelBal.Name = "LabelBal";
            this.LabelBal.Size = new System.Drawing.Size(35, 23);
            this.LabelBal.TabIndex = 13;
            this.LabelBal.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Выберите цель:";
            // 
            // PlanningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelBal);
            this.Controls.Add(this.LabelPlan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WthdrwBtn1);
            this.Controls.Add(this.WthdrwTb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepBtn1);
            this.Controls.Add(this.DepTb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BudgetCb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn4);
            this.Name = "PlanningForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackBtn4;
        private Label label1;
        private Button button1;
        private ComboBox BudgetCb1;
        private TextBox DepTb1;
        private Button DepBtn1;
        private Label label2;
        private Label label3;
        private TextBox WthdrwTb1;
        private Button WthdrwBtn1;
        private Label label4;
        private Label label5;
        private Label LabelPlan;
        private Label LabelBal;
        private Label label6;
    }
}