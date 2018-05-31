namespace IwM
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.writeNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.validateNameButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.patientListBox = new System.Windows.Forms.ListBox();
            this.editPatientButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.backPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.6328F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.3672F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.validateNameButton, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.patientListBox, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.nextButton, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.editPatientButton, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.70968F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.29032F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 634);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.titleLabel, 3);
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(317, 57);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(179, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Karta Pacjenta";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.writeNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameTextBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(126, 107);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 70);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // writeNameLabel
            // 
            this.writeNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.writeNameLabel.AutoSize = true;
            this.writeNameLabel.Location = new System.Drawing.Point(3, 9);
            this.writeNameLabel.Name = "writeNameLabel";
            this.writeNameLabel.Size = new System.Drawing.Size(163, 17);
            this.writeNameLabel.TabIndex = 1;
            this.writeNameLabel.Text = "Podaj nazwisko pacjenta";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(3, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(340, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // validateNameButton
            // 
            this.validateNameButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validateNameButton.Location = new System.Drawing.Point(492, 107);
            this.validateNameButton.Name = "validateNameButton";
            this.validateNameButton.Size = new System.Drawing.Size(154, 70);
            this.validateNameButton.TabIndex = 6;
            this.validateNameButton.Text = "Znajdź w bazie";
            this.validateNameButton.UseVisualStyleBackColor = true;
            this.validateNameButton.Click += new System.EventHandler(this.validateNameButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(492, 409);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(154, 70);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Wybierz pacjenta";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // patientListBox
            // 
            this.patientListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientListBox.FormattingEnabled = true;
            this.patientListBox.ItemHeight = 16;
            this.patientListBox.Location = new System.Drawing.Point(126, 191);
            this.patientListBox.Name = "patientListBox";
            this.tableLayoutPanel1.SetRowSpan(this.patientListBox, 3);
            this.patientListBox.Size = new System.Drawing.Size(346, 337);
            this.patientListBox.TabIndex = 7;
            this.patientListBox.SelectedIndexChanged += new System.EventHandler(this.patientListBox_SelectedIndexChanged);
            // 
            // editPatientButton
            // 
            this.editPatientButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.editPatientButton.Enabled = false;
            this.editPatientButton.Location = new System.Drawing.Point(492, 233);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(154, 70);
            this.editPatientButton.TabIndex = 8;
            this.editPatientButton.Text = "Edytuj dane pacjenta";
            this.editPatientButton.UseVisualStyleBackColor = true;
            this.editPatientButton.Click += new System.EventHandler(this.editPatientButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.97207F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.027933F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel3.Controls.Add(this.backPageButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.nextPageButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(126, 546);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(346, 64);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // backPageButton
            // 
            this.backPageButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backPageButton.Enabled = false;
            this.backPageButton.Location = new System.Drawing.Point(63, 10);
            this.backPageButton.Name = "backPageButton";
            this.backPageButton.Size = new System.Drawing.Size(104, 44);
            this.backPageButton.TabIndex = 0;
            this.backPageButton.Text = "<";
            this.backPageButton.UseVisualStyleBackColor = true;
            this.backPageButton.Click += new System.EventHandler(this.backPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextPageButton.Location = new System.Drawing.Point(182, 10);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(104, 44);
            this.nextPageButton.TabIndex = 1;
            this.nextPageButton.Text = ">";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label writeNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button validateNameButton;
        private System.Windows.Forms.ListBox patientListBox;
        private System.Windows.Forms.Button editPatientButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button backPageButton;
        private System.Windows.Forms.Button nextPageButton;
    }
}

