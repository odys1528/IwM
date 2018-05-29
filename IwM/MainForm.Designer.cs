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
            this.namesComboBox = new System.Windows.Forms.ComboBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.chartButton = new System.Windows.Forms.Button();
            this.anotherButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.validateNameButton, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.namesComboBox, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.nextButton, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.historyDataGridView, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 769);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.titleLabel, 3);
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(318, 54);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(126, 110);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(348, 74);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // writeNameLabel
            // 
            this.writeNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.writeNameLabel.AutoSize = true;
            this.writeNameLabel.Location = new System.Drawing.Point(3, 10);
            this.writeNameLabel.Name = "writeNameLabel";
            this.writeNameLabel.Size = new System.Drawing.Size(163, 17);
            this.writeNameLabel.TabIndex = 1;
            this.writeNameLabel.Text = "Podaj nazwisko pacjenta";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(3, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(342, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // validateNameButton
            // 
            this.validateNameButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validateNameButton.Location = new System.Drawing.Point(494, 119);
            this.validateNameButton.Name = "validateNameButton";
            this.validateNameButton.Size = new System.Drawing.Size(154, 56);
            this.validateNameButton.TabIndex = 6;
            this.validateNameButton.Text = "Znajdź w bazie";
            this.validateNameButton.UseVisualStyleBackColor = true;
            this.validateNameButton.Click += new System.EventHandler(this.validateNameButton_Click);
            // 
            // namesComboBox
            // 
            this.namesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.namesComboBox.Location = new System.Drawing.Point(126, 213);
            this.namesComboBox.Name = "namesComboBox";
            this.namesComboBox.Size = new System.Drawing.Size(348, 24);
            this.namesComboBox.TabIndex = 4;
            this.namesComboBox.Text = "Wybierz pacjenta z listy";
            this.namesComboBox.SelectedIndexChanged += new System.EventHandler(this.namesComboBox_SelectedIndexChanged);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(494, 206);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(154, 39);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Wybierz pacjenta";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.fromLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.fromDateTimePicker, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.toDateTimePicker, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.toLabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.filterButton, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(126, 264);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(564, 79);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(3, 1);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(24, 17);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "od";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromDateTimePicker.Enabled = false;
            this.fromDateTimePicker.Location = new System.Drawing.Point(3, 38);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(187, 22);
            this.fromDateTimePicker.TabIndex = 2;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toDateTimePicker.Enabled = false;
            this.toDateTimePicker.Location = new System.Drawing.Point(227, 38);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(182, 22);
            this.toDateTimePicker.TabIndex = 3;
            // 
            // toLabel
            // 
            this.toLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(227, 1);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(24, 17);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "do";
            // 
            // filterButton
            // 
            this.filterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filterButton.Enabled = false;
            this.filterButton.Location = new System.Drawing.Point(467, 13);
            this.filterButton.Name = "filterButton";
            this.tableLayoutPanel3.SetRowSpan(this.filterButton, 2);
            this.filterButton.Size = new System.Drawing.Size(75, 52);
            this.filterButton.TabIndex = 4;
            this.filterButton.Text = "Filtruj daty";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AllowUserToAddRows = false;
            this.historyDataGridView.AllowUserToDeleteRows = false;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.historyDataGridView, 3);
            this.historyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyDataGridView.Location = new System.Drawing.Point(126, 357);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.RowTemplate.Height = 24;
            this.historyDataGridView.Size = new System.Drawing.Size(564, 239);
            this.historyDataGridView.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 3);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.50739F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.49261F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel4.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.chartButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.anotherButton, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(126, 610);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(564, 135);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(51, 29);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 76);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Dodaj nowe coś";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // chartButton
            // 
            this.chartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartButton.Enabled = false;
            this.chartButton.Location = new System.Drawing.Point(257, 28);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(93, 79);
            this.chartButton.TabIndex = 1;
            this.chartButton.Text = "Wyświetl wykres";
            this.chartButton.UseVisualStyleBackColor = true;
            // 
            // anotherButton
            // 
            this.anotherButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.anotherButton.Enabled = false;
            this.anotherButton.Location = new System.Drawing.Point(441, 28);
            this.anotherButton.Name = "anotherButton";
            this.anotherButton.Size = new System.Drawing.Size(87, 79);
            this.anotherButton.TabIndex = 2;
            this.anotherButton.Text = "Jeszcze jeden guzik";
            this.anotherButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 769);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label writeNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ComboBox namesComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button validateNameButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.Button anotherButton;
    }
}

