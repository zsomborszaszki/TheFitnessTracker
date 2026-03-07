namespace TheFitnessTracker
{
    partial class Form1
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
            this.sportagLabel = new System.Windows.Forms.Label();
            this.idotartamLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.helyszinLabel = new System.Windows.Forms.Label();
            this.percLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sportagCombo = new System.Windows.Forms.ComboBox();
            this.datumDateTime = new System.Windows.Forms.DateTimePicker();
            this.helyszinText = new System.Windows.Forms.TextBox();
            this.felvitelButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.idotartamNumeric = new System.Windows.Forms.NumericUpDown();
            this.adatokButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idotartamNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // sportagLabel
            // 
            this.sportagLabel.AutoSize = true;
            this.sportagLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sportagLabel.Location = new System.Drawing.Point(128, 98);
            this.sportagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sportagLabel.Name = "sportagLabel";
            this.sportagLabel.Size = new System.Drawing.Size(129, 29);
            this.sportagLabel.TabIndex = 0;
            this.sportagLabel.Text = "Sportág:";
            // 
            // idotartamLabel
            // 
            this.idotartamLabel.AutoSize = true;
            this.idotartamLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.idotartamLabel.Location = new System.Drawing.Point(128, 217);
            this.idotartamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idotartamLabel.Name = "idotartamLabel";
            this.idotartamLabel.Size = new System.Drawing.Size(160, 29);
            this.idotartamLabel.TabIndex = 1;
            this.idotartamLabel.Text = "Időtartam:";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.datumLabel.Location = new System.Drawing.Point(632, 104);
            this.datumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(112, 29);
            this.datumLabel.TabIndex = 2;
            this.datumLabel.Text = "Dátum:";
            // 
            // helyszinLabel
            // 
            this.helyszinLabel.AutoSize = true;
            this.helyszinLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.helyszinLabel.Location = new System.Drawing.Point(632, 215);
            this.helyszinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.helyszinLabel.Name = "helyszinLabel";
            this.helyszinLabel.Size = new System.Drawing.Size(136, 29);
            this.helyszinLabel.TabIndex = 3;
            this.helyszinLabel.Text = "Helyszín:";
            // 
            // percLabel
            // 
            this.percLabel.AutoSize = true;
            this.percLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.percLabel.Location = new System.Drawing.Point(404, 219);
            this.percLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.percLabel.Name = "percLabel";
            this.percLabel.Size = new System.Drawing.Size(72, 29);
            this.percLabel.TabIndex = 4;
            this.percLabel.Text = "perc";
            // 
            // sportagCombo
            // 
            this.sportagCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sportagCombo.FormattingEnabled = true;
            this.sportagCombo.Items.AddRange(new object[] {
            "Labdarúgás",
            "Röplabda",
            "Kosárlabda",
            "Asztalitenisz",
            "Kézilabda",
            "Futás",
            "Pilátesz",
            "Jóga",
            "Karate",
            "Kézilabda",
            "Box",
            "Síelés",
            "Kerékpározás"});
            this.sportagCombo.Location = new System.Drawing.Point(292, 100);
            this.sportagCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sportagCombo.Name = "sportagCombo";
            this.sportagCombo.Size = new System.Drawing.Size(182, 33);
            this.sportagCombo.TabIndex = 5;
            // 
            // datumDateTime
            // 
            this.datumDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDateTime.Location = new System.Drawing.Point(776, 104);
            this.datumDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datumDateTime.Name = "datumDateTime";
            this.datumDateTime.Size = new System.Drawing.Size(212, 31);
            this.datumDateTime.TabIndex = 7;
            // 
            // helyszinText
            // 
            this.helyszinText.Location = new System.Drawing.Point(776, 217);
            this.helyszinText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.helyszinText.Name = "helyszinText";
            this.helyszinText.Size = new System.Drawing.Size(212, 31);
            this.helyszinText.TabIndex = 9;
            this.helyszinText.TextChanged += new System.EventHandler(this.helyszinText_TextChanged);
            // 
            // felvitelButton
            // 
            this.felvitelButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.felvitelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.felvitelButton.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold);
            this.felvitelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.felvitelButton.Location = new System.Drawing.Point(136, 304);
            this.felvitelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.felvitelButton.Name = "felvitelButton";
            this.felvitelButton.Size = new System.Drawing.Size(152, 48);
            this.felvitelButton.TabIndex = 10;
            this.felvitelButton.Text = "Felvitel";
            this.felvitelButton.UseVisualStyleBackColor = false;
            this.felvitelButton.Click += new System.EventHandler(this.felvitelButton_Click);
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold);
            this.importButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.importButton.Location = new System.Drawing.Point(592, 304);
            this.importButton.Margin = new System.Windows.Forms.Padding(0);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(152, 48);
            this.importButton.TabIndex = 11;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.DarkOrange;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportButton.Location = new System.Drawing.Point(836, 304);
            this.exportButton.Margin = new System.Windows.Forms.Padding(0);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(152, 48);
            this.exportButton.TabIndex = 12;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // idotartamNumeric
            // 
            this.idotartamNumeric.Location = new System.Drawing.Point(292, 213);
            this.idotartamNumeric.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.idotartamNumeric.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.idotartamNumeric.Name = "idotartamNumeric";
            this.idotartamNumeric.Size = new System.Drawing.Size(104, 31);
            this.idotartamNumeric.TabIndex = 15;
            this.idotartamNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // adatokButton
            // 
            this.adatokButton.BackColor = System.Drawing.Color.Plum;
            this.adatokButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adatokButton.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold);
            this.adatokButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adatokButton.Location = new System.Drawing.Point(358, 304);
            this.adatokButton.Margin = new System.Windows.Forms.Padding(0);
            this.adatokButton.Name = "adatokButton";
            this.adatokButton.Size = new System.Drawing.Size(152, 48);
            this.adatokButton.TabIndex = 16;
            this.adatokButton.Text = "Adatok";
            this.adatokButton.UseVisualStyleBackColor = false;
            this.adatokButton.Click += new System.EventHandler(this.adatokButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 439);
            this.Controls.Add(this.adatokButton);
            this.Controls.Add(this.idotartamNumeric);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.felvitelButton);
            this.Controls.Add(this.helyszinText);
            this.Controls.Add(this.datumDateTime);
            this.Controls.Add(this.sportagCombo);
            this.Controls.Add(this.percLabel);
            this.Controls.Add(this.helyszinLabel);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.idotartamLabel);
            this.Controls.Add(this.sportagLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.idotartamNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sportagLabel;
        private System.Windows.Forms.Label idotartamLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label helyszinLabel;
        private System.Windows.Forms.Label percLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox sportagCombo;
        private System.Windows.Forms.DateTimePicker datumDateTime;
        private System.Windows.Forms.TextBox helyszinText;
        private System.Windows.Forms.Button felvitelButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.NumericUpDown idotartamNumeric;
        private System.Windows.Forms.Button adatokButton;
    }
}

