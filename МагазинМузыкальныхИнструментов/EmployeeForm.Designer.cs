
namespace МагазинМузыкальныхИнструментов
{
    partial class EmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.buttonSpisok = new System.Windows.Forms.Button();
            this.buttonKatalog = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Label();
            this.SmallMainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRedactor = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonReceipts = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SmallMainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.MainPanel.Controls.Add(this.buttonSpisok);
            this.MainPanel.Controls.Add(this.buttonKatalog);
            this.MainPanel.Controls.Add(this.buttonOrders);
            this.MainPanel.Controls.Add(this.closeButton);
            this.MainPanel.Controls.Add(this.SmallMainPanel);
            this.MainPanel.Controls.Add(this.buttonSales);
            this.MainPanel.Controls.Add(this.buttonReceipts);
            this.MainPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainPanel.Location = new System.Drawing.Point(-8, -12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(985, 612);
            this.MainPanel.TabIndex = 3;
            // 
            // buttonSpisok
            // 
            this.buttonSpisok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.buttonSpisok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpisok.FlatAppearance.BorderSize = 0;
            this.buttonSpisok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpisok.ForeColor = System.Drawing.Color.White;
            this.buttonSpisok.Location = new System.Drawing.Point(778, 37);
            this.buttonSpisok.Name = "buttonSpisok";
            this.buttonSpisok.Size = new System.Drawing.Size(180, 23);
            this.buttonSpisok.TabIndex = 9;
            this.buttonSpisok.Text = "Список успеха";
            this.buttonSpisok.UseVisualStyleBackColor = false;
            this.buttonSpisok.Click += new System.EventHandler(this.buttonSpisok_Click);
            // 
            // buttonKatalog
            // 
            this.buttonKatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.buttonKatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKatalog.FlatAppearance.BorderSize = 0;
            this.buttonKatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKatalog.ForeColor = System.Drawing.Color.White;
            this.buttonKatalog.Location = new System.Drawing.Point(220, 38);
            this.buttonKatalog.Name = "buttonKatalog";
            this.buttonKatalog.Size = new System.Drawing.Size(180, 23);
            this.buttonKatalog.TabIndex = 6;
            this.buttonKatalog.Text = "Каталог";
            this.buttonKatalog.UseVisualStyleBackColor = false;
            this.buttonKatalog.Click += new System.EventHandler(this.buttonKatalog_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.buttonOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.ForeColor = System.Drawing.Color.White;
            this.buttonOrders.Location = new System.Drawing.Point(592, 37);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(180, 23);
            this.buttonOrders.TabIndex = 8;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(962, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 26);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // SmallMainPanel
            // 
            this.SmallMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.SmallMainPanel.Controls.Add(this.panel1);
            this.SmallMainPanel.Controls.Add(this.dataGridView1);
            this.SmallMainPanel.Controls.Add(this.buttonRedactor);
            this.SmallMainPanel.Location = new System.Drawing.Point(34, 66);
            this.SmallMainPanel.Name = "SmallMainPanel";
            this.SmallMainPanel.Size = new System.Drawing.Size(923, 502);
            this.SmallMainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 47);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(0, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(920, 388);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DividerWidth = 300;
            this.Column1.FillWeight = 300F;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // buttonRedactor
            // 
            this.buttonRedactor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRedactor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRedactor.FlatAppearance.BorderSize = 0;
            this.buttonRedactor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRedactor.ForeColor = System.Drawing.Color.Black;
            this.buttonRedactor.Location = new System.Drawing.Point(760, 464);
            this.buttonRedactor.Name = "buttonRedactor";
            this.buttonRedactor.Size = new System.Drawing.Size(148, 23);
            this.buttonRedactor.TabIndex = 10;
            this.buttonRedactor.Text = "Редактировать заказы";
            this.buttonRedactor.UseVisualStyleBackColor = false;
            this.buttonRedactor.Click += new System.EventHandler(this.buttonRedactor_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.buttonSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSales.FlatAppearance.BorderSize = 0;
            this.buttonSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSales.ForeColor = System.Drawing.Color.White;
            this.buttonSales.Location = new System.Drawing.Point(406, 37);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(180, 23);
            this.buttonSales.TabIndex = 7;
            this.buttonSales.Text = "Продажи";
            this.buttonSales.UseVisualStyleBackColor = false;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // buttonReceipts
            // 
            this.buttonReceipts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.buttonReceipts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReceipts.FlatAppearance.BorderSize = 0;
            this.buttonReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReceipts.ForeColor = System.Drawing.Color.White;
            this.buttonReceipts.Location = new System.Drawing.Point(34, 37);
            this.buttonReceipts.Name = "buttonReceipts";
            this.buttonReceipts.Size = new System.Drawing.Size(180, 23);
            this.buttonReceipts.TabIndex = 4;
            this.buttonReceipts.Text = "Поступления";
            this.buttonReceipts.UseVisualStyleBackColor = false;
            this.buttonReceipts.Click += new System.EventHandler(this.buttonReceipts_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 598);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.SmallMainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel SmallMainPanel;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button buttonKatalog;
        private System.Windows.Forms.Button buttonReceipts;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSpisok;
        private System.Windows.Forms.Button buttonRedactor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
    }
}