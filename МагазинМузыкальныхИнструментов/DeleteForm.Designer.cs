namespace МагазинМузыкальныхИнструментов
{
    partial class DeleteForm
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
            this.ArrowBackLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.SmallMainPanel = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxFull = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxCustomers = new System.Windows.Forms.CheckBox();
            this.checkBoxEmployee = new System.Windows.Forms.CheckBox();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.checkBoxSale = new System.Windows.Forms.CheckBox();
            this.checkBoxKata = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPost = new System.Windows.Forms.CheckBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SmallMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArrowBackLabel
            // 
            this.ArrowBackLabel.AutoSize = true;
            this.ArrowBackLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArrowBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrowBackLabel.ForeColor = System.Drawing.Color.White;
            this.ArrowBackLabel.Location = new System.Drawing.Point(3, 0);
            this.ArrowBackLabel.Name = "ArrowBackLabel";
            this.ArrowBackLabel.Size = new System.Drawing.Size(39, 26);
            this.ArrowBackLabel.TabIndex = 2;
            this.ArrowBackLabel.Text = "<--";
            this.ArrowBackLabel.Click += new System.EventHandler(this.ArrowBackLabel_Click);
            this.ArrowBackLabel.MouseEnter += new System.EventHandler(this.ArrowBackLabel_MouseEnter);
            this.ArrowBackLabel.MouseLeave += new System.EventHandler(this.ArrowBackLabel_MouseLeave);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.MainPanel.Controls.Add(this.ArrowBackLabel);
            this.MainPanel.Controls.Add(this.closeButton);
            this.MainPanel.Controls.Add(this.SmallMainPanel);
            this.MainPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainPanel.Location = new System.Drawing.Point(-1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(616, 431);
            this.MainPanel.TabIndex = 5;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(593, 0);
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
            this.SmallMainPanel.Controls.Add(this.textBoxId);
            this.SmallMainPanel.Controls.Add(this.label4);
            this.SmallMainPanel.Controls.Add(this.checkBoxFull);
            this.SmallMainPanel.Controls.Add(this.label3);
            this.SmallMainPanel.Controls.Add(this.checkBoxCustomers);
            this.SmallMainPanel.Controls.Add(this.checkBoxEmployee);
            this.SmallMainPanel.Controls.Add(this.checkBoxOrder);
            this.SmallMainPanel.Controls.Add(this.checkBoxSale);
            this.SmallMainPanel.Controls.Add(this.checkBoxKata);
            this.SmallMainPanel.Controls.Add(this.label2);
            this.SmallMainPanel.Controls.Add(this.checkBoxPost);
            this.SmallMainPanel.Controls.Add(this.buttonDelete);
            this.SmallMainPanel.Controls.Add(this.label1);
            this.SmallMainPanel.Location = new System.Drawing.Point(60, 38);
            this.SmallMainPanel.Name = "SmallMainPanel";
            this.SmallMainPanel.Size = new System.Drawing.Size(487, 360);
            this.SmallMainPanel.TabIndex = 0;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(298, 253);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(165, 20);
            this.textBoxId.TabIndex = 16;
            this.textBoxId.Enter += new System.EventHandler(this.textBoxId_Enter);
            this.textBoxId.Leave += new System.EventHandler(this.textBoxId_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label4.Location = new System.Drawing.Point(228, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "или";
            // 
            // checkBoxFull
            // 
            this.checkBoxFull.AutoSize = true;
            this.checkBoxFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxFull.ForeColor = System.Drawing.Color.White;
            this.checkBoxFull.Location = new System.Drawing.Point(37, 253);
            this.checkBoxFull.Name = "checkBoxFull";
            this.checkBoxFull.Size = new System.Drawing.Size(167, 20);
            this.checkBoxFull.TabIndex = 14;
            this.checkBoxFull.Text = "Удалить всю таблицу";
            this.checkBoxFull.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label3.Location = new System.Drawing.Point(34, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Выберите действие";
            // 
            // checkBoxCustomers
            // 
            this.checkBoxCustomers.AutoSize = true;
            this.checkBoxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCustomers.ForeColor = System.Drawing.Color.White;
            this.checkBoxCustomers.Location = new System.Drawing.Point(366, 140);
            this.checkBoxCustomers.Name = "checkBoxCustomers";
            this.checkBoxCustomers.Size = new System.Drawing.Size(106, 20);
            this.checkBoxCustomers.TabIndex = 12;
            this.checkBoxCustomers.Text = "Покупатели";
            this.checkBoxCustomers.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmployee
            // 
            this.checkBoxEmployee.AutoSize = true;
            this.checkBoxEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxEmployee.ForeColor = System.Drawing.Color.White;
            this.checkBoxEmployee.Location = new System.Drawing.Point(214, 140);
            this.checkBoxEmployee.Name = "checkBoxEmployee";
            this.checkBoxEmployee.Size = new System.Drawing.Size(105, 20);
            this.checkBoxEmployee.TabIndex = 11;
            this.checkBoxEmployee.Text = "Сотрудники";
            this.checkBoxEmployee.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxOrder.ForeColor = System.Drawing.Color.White;
            this.checkBoxOrder.Location = new System.Drawing.Point(37, 140);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(75, 20);
            this.checkBoxOrder.TabIndex = 10;
            this.checkBoxOrder.Text = "Заказы";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // checkBoxSale
            // 
            this.checkBoxSale.AutoSize = true;
            this.checkBoxSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSale.ForeColor = System.Drawing.Color.White;
            this.checkBoxSale.Location = new System.Drawing.Point(366, 95);
            this.checkBoxSale.Name = "checkBoxSale";
            this.checkBoxSale.Size = new System.Drawing.Size(85, 20);
            this.checkBoxSale.TabIndex = 9;
            this.checkBoxSale.Text = "Продажи";
            this.checkBoxSale.UseVisualStyleBackColor = true;
            // 
            // checkBoxKata
            // 
            this.checkBoxKata.AutoSize = true;
            this.checkBoxKata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxKata.ForeColor = System.Drawing.Color.White;
            this.checkBoxKata.Location = new System.Drawing.Point(214, 95);
            this.checkBoxKata.Name = "checkBoxKata";
            this.checkBoxKata.Size = new System.Drawing.Size(79, 20);
            this.checkBoxKata.TabIndex = 8;
            this.checkBoxKata.Text = "Каталог";
            this.checkBoxKata.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите таблицу";
            // 
            // checkBoxPost
            // 
            this.checkBoxPost.AutoSize = true;
            this.checkBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPost.ForeColor = System.Drawing.Color.White;
            this.checkBoxPost.Location = new System.Drawing.Point(37, 95);
            this.checkBoxPost.Name = "checkBoxPost";
            this.checkBoxPost.Size = new System.Drawing.Size(113, 20);
            this.checkBoxPost.TabIndex = 6;
            this.checkBoxPost.Text = "Поступления";
            this.checkBoxPost.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.buttonDelete.Location = new System.Drawing.Point(126, 307);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(237, 34);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(170, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удаление данных";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 430);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.SmallMainPanel.ResumeLayout(false);
            this.SmallMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ArrowBackLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel SmallMainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPost;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSale;
        private System.Windows.Forms.CheckBox checkBoxKata;
        private System.Windows.Forms.CheckBox checkBoxEmployee;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxFull;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxCustomers;
    }
}