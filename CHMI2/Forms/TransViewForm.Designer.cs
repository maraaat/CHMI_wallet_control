using CHMI2.WalletModels;

namespace CHMI2
{
    partial class TransViewForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        //smth
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransViewForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlanBtn1 = new System.Windows.Forms.Button();
            this.ReservBtn1 = new System.Windows.Forms.Button();
            this.AddTrBtn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BalanceLabel1 = new System.Windows.Forms.Label();
            this.RepBtn1 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.TrType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.walletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.walletBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PlanBtn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReservBtn1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 395);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PlanBtn1
            // 
            this.PlanBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlanBtn1.Image = ((System.Drawing.Image)(resources.GetObject("PlanBtn1.Image")));
            this.PlanBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlanBtn1.Location = new System.Drawing.Point(3, 3);
            this.PlanBtn1.Name = "PlanBtn1";
            this.PlanBtn1.Size = new System.Drawing.Size(169, 48);
            this.PlanBtn1.TabIndex = 0;
            this.PlanBtn1.Text = "Планирование бюджета";
            this.PlanBtn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PlanBtn1.UseVisualStyleBackColor = true;
            this.PlanBtn1.Click += new System.EventHandler(this.PlanBtn1_Click_1);
            // 
            // ReservBtn1
            // 
            this.ReservBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReservBtn1.Image = global::CHMI2.Properties.Resources.рез;
            this.ReservBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReservBtn1.Location = new System.Drawing.Point(178, 3);
            this.ReservBtn1.Name = "ReservBtn1";
            this.ReservBtn1.Size = new System.Drawing.Size(169, 48);
            this.ReservBtn1.TabIndex = 1;
            this.ReservBtn1.Text = "Резервирование средств";
            this.ReservBtn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReservBtn1.UseVisualStyleBackColor = true;
            this.ReservBtn1.Click += new System.EventHandler(this.ReservBtn1_Click);
            // 
            // AddTrBtn1
            // 
            this.AddTrBtn1.Image = ((System.Drawing.Image)(resources.GetObject("AddTrBtn1.Image")));
            this.AddTrBtn1.Location = new System.Drawing.Point(461, 395);
            this.AddTrBtn1.Name = "AddTrBtn1";
            this.AddTrBtn1.Size = new System.Drawing.Size(61, 57);
            this.AddTrBtn1.TabIndex = 1;
            this.AddTrBtn1.UseVisualStyleBackColor = true;
            this.AddTrBtn1.Click += new System.EventHandler(this.AddTrBtn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Баланс:";
            // 
            // BalanceLabel1
            // 
            this.BalanceLabel1.AutoSize = true;
            this.BalanceLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.BalanceLabel1.Location = new System.Drawing.Point(100, 9);
            this.BalanceLabel1.Name = "BalanceLabel1";
            this.BalanceLabel1.Size = new System.Drawing.Size(72, 25);
            this.BalanceLabel1.TabIndex = 3;
            this.BalanceLabel1.Text = "5.542P";
            this.BalanceLabel1.Click += new System.EventHandler(this.BalanceLabel1_Click);
            // 
            // RepBtn1
            // 
            this.RepBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RepBtn1.Location = new System.Drawing.Point(447, 12);
            this.RepBtn1.Name = "RepBtn1";
            this.RepBtn1.Size = new System.Drawing.Size(75, 30);
            this.RepBtn1.TabIndex = 4;
            this.RepBtn1.Text = "Отчёт";
            this.RepBtn1.UseVisualStyleBackColor = true;
            this.RepBtn1.Click += new System.EventHandler(this.RepBtn1_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrType,
            this.TbCat,
            this.TrName,
            this.TrDate,
            this.TrVal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.Location = new System.Drawing.Point(15, 52);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(507, 337);
            this.dgv1.TabIndex = 5;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // TrType
            // 
            this.TrType.HeaderText = "Тип";
            this.TrType.Name = "TrType";
            this.TrType.ReadOnly = true;
            this.TrType.Width = 59;
            // 
            // TbCat
            // 
            this.TbCat.HeaderText = "Категория";
            this.TbCat.Name = "TbCat";
            this.TbCat.ReadOnly = true;
            this.TbCat.Width = 106;
            // 
            // TrName
            // 
            this.TrName.HeaderText = "Название";
            this.TrName.Name = "TrName";
            this.TrName.ReadOnly = true;
            this.TrName.Width = 102;
            // 
            // TrDate
            // 
            this.TrDate.HeaderText = "Дата";
            this.TrDate.Name = "TrDate";
            this.TrDate.ReadOnly = true;
            this.TrDate.Width = 67;
            // 
            // TrVal
            // 
            this.TrVal.HeaderText = "Размер";
            this.TrVal.Name = "TrVal";
            this.TrVal.ReadOnly = true;
            this.TrVal.Width = 86;
            // 
            // walletBindingSource
            // 
            this.walletBindingSource.DataSource = typeof(Wallet);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(Transaction);
            // 
            // walletBindingSource1
            // 
            this.walletBindingSource1.DataSource = typeof(Wallet);
            // 
            // TransViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.RepBtn1);
            this.Controls.Add(this.BalanceLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddTrBtn1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgv1);
            this.Name = "TransViewForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button PlanBtn1;
        private Button ReservBtn1;
        private Button AddTrBtn1;
        private Label label1;
        private Label BalanceLabel1;
        private Button RepBtn1;
        private DataGridViewTextBoxColumn TrType;
        private DataGridViewTextBoxColumn TbCat;
        private DataGridViewTextBoxColumn TrName;
        private DataGridViewTextBoxColumn TrDate;
        private DataGridViewTextBoxColumn TrVal;
        private BindingSource walletBindingSource;
        private BindingSource transactionBindingSource;
        private DataGridView dgv1;
        private BindingSource walletBindingSource1;
    }
}