
namespace МагазинМузыкальныхИнструментов
{
    partial class InsertForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.namePostav = new System.Windows.Forms.TextBox();
            this.costBox = new System.Windows.Forms.TextBox();
            this.idDokum = new System.Windows.Forms.TextBox();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.instrumentName = new System.Windows.Forms.TextBox();
            this.buttonRedactor = new System.Windows.Forms.Button();
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
            this.MainPanel.Location = new System.Drawing.Point(-1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(838, 508);
            this.MainPanel.TabIndex = 5;
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
            this.closeButton.Location = new System.Drawing.Point(815, 0);
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
            this.SmallMainPanel.Controls.Add(this.dateTimePicker1);
            this.SmallMainPanel.Controls.Add(this.namePostav);
            this.SmallMainPanel.Controls.Add(this.costBox);
            this.SmallMainPanel.Controls.Add(this.idDokum);
            this.SmallMainPanel.Controls.Add(this.adressBox);
            this.SmallMainPanel.Controls.Add(this.typeBox);
            this.SmallMainPanel.Controls.Add(this.quantityBox);
            this.SmallMainPanel.Controls.Add(this.instrumentName);
            this.SmallMainPanel.Controls.Add(this.buttonRedactor);
            this.SmallMainPanel.Controls.Add(this.label1);
            this.SmallMainPanel.Location = new System.Drawing.Point(60, 38);
            this.SmallMainPanel.Name = "SmallMainPanel";
            this.SmallMainPanel.Size = new System.Drawing.Size(717, 428);
            this.SmallMainPanel.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(367, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // namePostav
            // 
            this.namePostav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namePostav.ForeColor = System.Drawing.SystemColors.GrayText;
            this.namePostav.Location = new System.Drawing.Point(47, 127);
            this.namePostav.Multiline = true;
            this.namePostav.Name = "namePostav";
            this.namePostav.Size = new System.Drawing.Size(312, 30);
            this.namePostav.TabIndex = 11;
            this.namePostav.UseSystemPasswordChar = true;
            this.namePostav.Enter += new System.EventHandler(this.namePostav_Enter);
            this.namePostav.Leave += new System.EventHandler(this.namePostav_Leave);
            // 
            // costBox
            // 
            this.costBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.costBox.Location = new System.Drawing.Point(47, 251);
            this.costBox.Multiline = true;
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(312, 30);
            this.costBox.TabIndex = 10;
            this.costBox.UseSystemPasswordChar = true;
            this.costBox.Enter += new System.EventHandler(this.costBox_Enter);
            this.costBox.Leave += new System.EventHandler(this.costBox_Leave);
            // 
            // idDokum
            // 
            this.idDokum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idDokum.ForeColor = System.Drawing.SystemColors.GrayText;
            this.idDokum.Location = new System.Drawing.Point(367, 71);
            this.idDokum.Multiline = true;
            this.idDokum.Name = "idDokum";
            this.idDokum.Size = new System.Drawing.Size(312, 30);
            this.idDokum.TabIndex = 9;
            this.idDokum.UseSystemPasswordChar = true;
            this.idDokum.Enter += new System.EventHandler(this.idDokum_Enter);
            this.idDokum.Leave += new System.EventHandler(this.idDokum_Leave);
            // 
            // adressBox
            // 
            this.adressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.adressBox.Location = new System.Drawing.Point(367, 127);
            this.adressBox.Multiline = true;
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(312, 30);
            this.adressBox.TabIndex = 8;
            this.adressBox.UseSystemPasswordChar = true;
            this.adressBox.Enter += new System.EventHandler(this.adressBox_Enter);
            this.adressBox.Leave += new System.EventHandler(this.adressBox_Leave);
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.typeBox.Location = new System.Drawing.Point(367, 188);
            this.typeBox.Multiline = true;
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(312, 30);
            this.typeBox.TabIndex = 7;
            this.typeBox.UseSystemPasswordChar = true;
            this.typeBox.Enter += new System.EventHandler(this.typeBox_Enter);
            this.typeBox.Leave += new System.EventHandler(this.typeBox_Leave);
            // 
            // quantityBox
            // 
            this.quantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.quantityBox.Location = new System.Drawing.Point(47, 188);
            this.quantityBox.Multiline = true;
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(312, 30);
            this.quantityBox.TabIndex = 5;
            this.quantityBox.UseSystemPasswordChar = true;
            this.quantityBox.Enter += new System.EventHandler(this.quantityBox_Enter);
            this.quantityBox.Leave += new System.EventHandler(this.quantityBox_Leave);
            // 
            // instrumentName
            // 
            this.instrumentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instrumentName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.instrumentName.Location = new System.Drawing.Point(47, 71);
            this.instrumentName.Multiline = true;
            this.instrumentName.Name = "instrumentName";
            this.instrumentName.Size = new System.Drawing.Size(312, 30);
            this.instrumentName.TabIndex = 4;
            this.instrumentName.UseSystemPasswordChar = true;
            this.instrumentName.Enter += new System.EventHandler(this.instrumentName_Enter);
            this.instrumentName.Leave += new System.EventHandler(this.instrumentName_Leave);
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
            this.buttonRedactor.Location = new System.Drawing.Point(245, 361);
            this.buttonRedactor.Name = "buttonRedactor";
            this.buttonRedactor.Size = new System.Drawing.Size(237, 34);
            this.buttonRedactor.TabIndex = 3;
            this.buttonRedactor.Text = "Добавить";
            this.buttonRedactor.UseVisualStyleBackColor = false;
            this.buttonRedactor.Click += new System.EventHandler(this.buttonRedactor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(257, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление инструмента";
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 506);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertForm";
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
        private System.Windows.Forms.TextBox instrumentName;
        private System.Windows.Forms.Button buttonRedactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namePostav;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.TextBox idDokum;
        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}