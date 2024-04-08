namespace CHMI2.Forms
{
    partial class BudgetAddForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTb1 = new System.Windows.Forms.TextBox();
            this.StartTb1 = new System.Windows.Forms.TextBox();
            this.ValTb1 = new System.Windows.Forms.TextBox();
            this.BackBtn2 = new System.Windows.Forms.Button();
            this.BtnAdd1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание новой цели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите желанную сумму:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введите начальный взнос:";
            // 
            // NameTb1
            // 
            this.NameTb1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameTb1.Location = new System.Drawing.Point(175, 53);
            this.NameTb1.Name = "NameTb1";
            this.NameTb1.Size = new System.Drawing.Size(187, 30);
            this.NameTb1.TabIndex = 4;
            // 
            // StartTb1
            // 
            this.StartTb1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartTb1.Location = new System.Drawing.Point(245, 133);
            this.StartTb1.Name = "StartTb1";
            this.StartTb1.Size = new System.Drawing.Size(117, 30);
            this.StartTb1.TabIndex = 5;
            // 
            // ValTb1
            // 
            this.ValTb1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValTb1.Location = new System.Drawing.Point(245, 93);
            this.ValTb1.Name = "ValTb1";
            this.ValTb1.Size = new System.Drawing.Size(117, 30);
            this.ValTb1.TabIndex = 6;
            // 
            // BackBtn2
            // 
            this.BackBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.BackBtn2.Image = global::CHMI2.Properties.Resources.free_icon_turn_back_3585896;
            this.BackBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackBtn2.Location = new System.Drawing.Point(267, 410);
            this.BackBtn2.Name = "BackBtn2";
            this.BackBtn2.Size = new System.Drawing.Size(95, 39);
            this.BackBtn2.TabIndex = 7;
            this.BackBtn2.Text = "Назад";
            this.BackBtn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackBtn2.UseVisualStyleBackColor = true;
            this.BackBtn2.Click += new System.EventHandler(this.BackBtn2_Click);
            // 
            // BtnAdd1
            // 
            this.BtnAdd1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd1.Location = new System.Drawing.Point(122, 179);
            this.BtnAdd1.Name = "BtnAdd1";
            this.BtnAdd1.Size = new System.Drawing.Size(135, 39);
            this.BtnAdd1.TabIndex = 8;
            this.BtnAdd1.Text = " Создать";
            this.BtnAdd1.UseVisualStyleBackColor = true;
            this.BtnAdd1.Click += new System.EventHandler(this.BtnAdd1_Click);
            // 
            // BudgetAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.BtnAdd1);
            this.Controls.Add(this.BackBtn2);
            this.Controls.Add(this.ValTb1);
            this.Controls.Add(this.StartTb1);
            this.Controls.Add(this.NameTb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BudgetAddForm";
            this.Text = "BudgetAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NameTb1;
        private TextBox StartTb1;
        private TextBox ValTb1;
        private Button BackBtn2;
        private Button BtnAdd1;
    }
}