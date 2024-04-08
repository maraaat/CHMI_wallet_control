namespace CHMI2.Forms
{
    partial class TransAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransAddForm));
            this.BackBtn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTrType1 = new System.Windows.Forms.ComboBox();
            this.cbCtgry1 = new System.Windows.Forms.ComboBox();
            this.AddBtn1 = new System.Windows.Forms.Button();
            this.SumTb1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackBtn3
            // 
            this.BackBtn3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.BackBtn3.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn3.Image")));
            this.BackBtn3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackBtn3.Location = new System.Drawing.Point(280, 407);
            this.BackBtn3.Name = "BackBtn3";
            this.BackBtn3.Size = new System.Drawing.Size(92, 42);
            this.BackBtn3.TabIndex = 0;
            this.BackBtn3.Text = "Назад";
            this.BackBtn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackBtn3.UseVisualStyleBackColor = true;
            this.BackBtn3.Click += new System.EventHandler(this.BackBtn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // cbTrType1
            // 
            this.cbTrType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrType1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbTrType1.FormattingEnabled = true;
            this.cbTrType1.Items.AddRange(new object[] {
            "Доход",
            "Расход"});
            this.cbTrType1.Location = new System.Drawing.Point(216, 73);
            this.cbTrType1.Name = "cbTrType1";
            this.cbTrType1.Size = new System.Drawing.Size(145, 28);
            this.cbTrType1.TabIndex = 2;
            this.cbTrType1.DropDown += new System.EventHandler(this.cbTrType1_DropDown);
            this.cbTrType1.TextUpdate += new System.EventHandler(this.cbTrType1_TextUpdate);
            this.cbTrType1.DropDownClosed += new System.EventHandler(this.cbTrType1_DropDownClosed);
            this.cbTrType1.TextChanged += new System.EventHandler(this.cbTrType1_TextChanged);
            // 
            // cbCtgry1
            // 
            this.cbCtgry1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCtgry1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbCtgry1.FormattingEnabled = true;
            this.cbCtgry1.Location = new System.Drawing.Point(182, 111);
            this.cbCtgry1.Name = "cbCtgry1";
            this.cbCtgry1.Size = new System.Drawing.Size(179, 28);
            this.cbCtgry1.TabIndex = 3;
            // 
            // AddBtn1
            // 
            this.AddBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AddBtn1.Location = new System.Drawing.Point(142, 245);
            this.AddBtn1.Name = "AddBtn1";
            this.AddBtn1.Size = new System.Drawing.Size(126, 40);
            this.AddBtn1.TabIndex = 4;
            this.AddBtn1.Text = "Добавить";
            this.AddBtn1.UseVisualStyleBackColor = true;
            this.AddBtn1.Click += new System.EventHandler(this.AddBtn1_Click);
            // 
            // SumTb1
            // 
            this.SumTb1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SumTb1.Location = new System.Drawing.Point(186, 194);
            this.SumTb1.Name = "SumTb1";
            this.SumTb1.Size = new System.Drawing.Size(175, 27);
            this.SumTb1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Укажите дату:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите сумму (руб.):";
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtp1.Location = new System.Drawing.Point(182, 153);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(179, 27);
            this.dtp1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Добавление транзакции";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Название:";
            // 
            // tbName1
            // 
            this.tbName1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbName1.Location = new System.Drawing.Point(101, 40);
            this.tbName1.Name = "tbName1";
            this.tbName1.Size = new System.Drawing.Size(260, 27);
            this.tbName1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Выберите тип транзакции:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Выберите категорию:";
            // 
            // TransAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbName1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SumTb1);
            this.Controls.Add(this.AddBtn1);
            this.Controls.Add(this.cbCtgry1);
            this.Controls.Add(this.cbTrType1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn3);
            this.Name = "TransAddForm";
            this.Text = "TransAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackBtn3;
        private Label label1;
        private ComboBox cbTrType1;
        private ComboBox cbCtgry1;
        private Button AddBtn1;
        private TextBox SumTb1;
        private Label label3;
        private Label label4;
        private DateTimePicker dtp1;
        private Label label2;
        private Label label5;
        private TextBox tbName1;
        private Label label6;
        private Label label7;
    }
}