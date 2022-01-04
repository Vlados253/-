
namespace МагазинМузыкальныхИнструментов
{
    partial class OrderForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ArrowBackLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.SmallMainPanel = new System.Windows.Forms.Panel();
            this.customerAdres = new System.Windows.Forms.TextBox();
            this.instrumentType = new System.Windows.Forms.TextBox();
            this.instrumentQuantity = new System.Windows.Forms.TextBox();
            this.instrumentName = new System.Windows.Forms.TextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SmallMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.MainPanel.Controls.Add(this.ArrowBackLabel);
            this.MainPanel.Controls.Add(this.closeButton);
            this.MainPanel.Controls.Add(this.SmallMainPanel);
            this.MainPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(616, 431);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
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
            this.SmallMainPanel.Controls.Add(this.customerAdres);
            this.SmallMainPanel.Controls.Add(this.instrumentType);
            this.SmallMainPanel.Controls.Add(this.instrumentQuantity);
            this.SmallMainPanel.Controls.Add(this.instrumentName);
            this.SmallMainPanel.Controls.Add(this.buttonOrder);
            this.SmallMainPanel.Controls.Add(this.label1);
            this.SmallMainPanel.Location = new System.Drawing.Point(60, 38);
            this.SmallMainPanel.Name = "SmallMainPanel";
            this.SmallMainPanel.Size = new System.Drawing.Size(487, 360);
            this.SmallMainPanel.TabIndex = 0;
            // 
            // customerAdres
            // 
            this.customerAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerAdres.ForeColor = System.Drawing.Color.Gray;
            this.customerAdres.Location = new System.Drawing.Point(49, 211);
            this.customerAdres.Multiline = true;
            this.customerAdres.Name = "customerAdres";
            this.customerAdres.Size = new System.Drawing.Size(395, 30);
            this.customerAdres.TabIndex = 8;
            this.customerAdres.Text = "Адресс";
            this.customerAdres.UseSystemPasswordChar = true;
            this.customerAdres.Enter += new System.EventHandler(this.instrumentAdres_Enter);
            this.customerAdres.Leave += new System.EventHandler(this.instrumentAdres_Leave);
            // 
            // instrumentType
            // 
            this.instrumentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instrumentType.ForeColor = System.Drawing.Color.Gray;
            this.instrumentType.Location = new System.Drawing.Point(49, 109);
            this.instrumentType.Multiline = true;
            this.instrumentType.Name = "instrumentType";
            this.instrumentType.Size = new System.Drawing.Size(395, 30);
            this.instrumentType.TabIndex = 6;
            this.instrumentType.Text = "Тип инструмента";
            this.instrumentType.UseSystemPasswordChar = true;
            this.instrumentType.Enter += new System.EventHandler(this.instrumentType_Enter);
            this.instrumentType.Leave += new System.EventHandler(this.instrumentType_Leave);
            // 
            // instrumentQuantity
            // 
            this.instrumentQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instrumentQuantity.ForeColor = System.Drawing.Color.Gray;
            this.instrumentQuantity.Location = new System.Drawing.Point(49, 159);
            this.instrumentQuantity.Multiline = true;
            this.instrumentQuantity.Name = "instrumentQuantity";
            this.instrumentQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.instrumentQuantity.Size = new System.Drawing.Size(395, 30);
            this.instrumentQuantity.TabIndex = 2;
            this.instrumentQuantity.Text = "Количество";
            this.instrumentQuantity.UseSystemPasswordChar = true;
            this.instrumentQuantity.Enter += new System.EventHandler(this.instrumentQuantity_Enter);
            this.instrumentQuantity.Leave += new System.EventHandler(this.instrumentQuantity_Leave);
            // 
            // instrumentName
            // 
            this.instrumentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instrumentName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.instrumentName.Location = new System.Drawing.Point(49, 61);
            this.instrumentName.Multiline = true;
            this.instrumentName.Name = "instrumentName";
            this.instrumentName.Size = new System.Drawing.Size(395, 30);
            this.instrumentName.TabIndex = 4;
            this.instrumentName.Text = "Название инструмента";
            this.instrumentName.UseSystemPasswordChar = true;
            this.instrumentName.Enter += new System.EventHandler(this.instrumentName_Enter);
            this.instrumentName.Leave += new System.EventHandler(this.instrumentName_Leave);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.buttonOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.buttonOrder.Location = new System.Drawing.Point(126, 307);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(237, 34);
            this.buttonOrder.TabIndex = 3;
            this.buttonOrder.Text = "Оформить заказ";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(166, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформление заказа";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 430);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.SmallMainPanel.ResumeLayout(false);
            this.SmallMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label ArrowBackLabel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel SmallMainPanel;
        private System.Windows.Forms.TextBox instrumentType;
        private System.Windows.Forms.TextBox instrumentQuantity;
        private System.Windows.Forms.TextBox instrumentName;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerAdres;
    }
}