
namespace МагазинМузыкальныхИнструментов
{
    partial class RedactorEmployeeForm
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
            this.dateBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.orderId = new System.Windows.Forms.TextBox();
            this.buttonRedactor = new System.Windows.Forms.Button();
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
            this.MainPanel.TabIndex = 4;
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
            // 
            // SmallMainPanel
            // 
            this.SmallMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.SmallMainPanel.Controls.Add(this.dateBox);
            this.SmallMainPanel.Controls.Add(this.quantityBox);
            this.SmallMainPanel.Controls.Add(this.checkBox);
            this.SmallMainPanel.Controls.Add(this.orderId);
            this.SmallMainPanel.Controls.Add(this.buttonRedactor);
            this.SmallMainPanel.Controls.Add(this.label1);
            this.SmallMainPanel.Location = new System.Drawing.Point(60, 38);
            this.SmallMainPanel.Name = "SmallMainPanel";
            this.SmallMainPanel.Size = new System.Drawing.Size(487, 360);
            this.SmallMainPanel.TabIndex = 0;
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dateBox.Location = new System.Drawing.Point(49, 194);
            this.dateBox.Multiline = true;
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(395, 30);
            this.dateBox.TabIndex = 8;
            this.dateBox.UseSystemPasswordChar = true;
            // 
            // quantityBox
            // 
            this.quantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.quantityBox.Location = new System.Drawing.Point(49, 130);
            this.quantityBox.Multiline = true;
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(395, 30);
            this.quantityBox.TabIndex = 7;
            this.quantityBox.UseSystemPasswordChar = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox.ForeColor = System.Drawing.Color.White;
            this.checkBox.Location = new System.Drawing.Point(49, 252);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(78, 20);
            this.checkBox.TabIndex = 6;
            this.checkBox.Text = "Finished";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // orderId
            // 
            this.orderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.orderId.Location = new System.Drawing.Point(49, 71);
            this.orderId.Multiline = true;
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(395, 30);
            this.orderId.TabIndex = 4;
            this.orderId.UseSystemPasswordChar = true;
            this.orderId.Enter += new System.EventHandler(this.orderId_Enter);
            this.orderId.Leave += new System.EventHandler(this.orderId_Leave);
            // 
            // buttonRedactor
            // 
            this.buttonRedactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.buttonRedactor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRedactor.FlatAppearance.BorderSize = 0;
            this.buttonRedactor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonRedactor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.buttonRedactor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRedactor.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRedactor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.buttonRedactor.Location = new System.Drawing.Point(126, 307);
            this.buttonRedactor.Name = "buttonRedactor";
            this.buttonRedactor.Size = new System.Drawing.Size(237, 34);
            this.buttonRedactor.TabIndex = 3;
            this.buttonRedactor.Text = "Оформить заказ";
            this.buttonRedactor.UseVisualStyleBackColor = false;
            this.buttonRedactor.Click += new System.EventHandler(this.buttonRedactor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(152, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редактирование заказа";
            // 
            // RedactorEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 430);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RedactorEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RedactorEmployeeForm";
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
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.Button buttonRedactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.TextBox dateBox;
    }
}