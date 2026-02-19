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
            this.idotartamText = new System.Windows.Forms.TextBox();
            this.datumDateTime = new System.Windows.Forms.DateTimePicker();
            this.helyszinText = new System.Windows.Forms.TextBox();
            this.felvitelButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sportagLabel
            // 
            this.sportagLabel.AutoSize = true;
            this.sportagLabel.Location = new System.Drawing.Point(127, 99);
            this.sportagLabel.Name = "sportagLabel";
            this.sportagLabel.Size = new System.Drawing.Size(93, 25);
            this.sportagLabel.TabIndex = 0;
            this.sportagLabel.Text = "Sportág:";
            // 
            // idotartamLabel
            // 
            this.idotartamLabel.AutoSize = true;
            this.idotartamLabel.Location = new System.Drawing.Point(127, 217);
            this.idotartamLabel.Name = "idotartamLabel";
            this.idotartamLabel.Size = new System.Drawing.Size(107, 25);
            this.idotartamLabel.TabIndex = 1;
            this.idotartamLabel.Text = "Időtartam:";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(653, 98);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(80, 25);
            this.datumLabel.TabIndex = 2;
            this.datumLabel.Text = "Dátum:";
            // 
            // helyszinLabel
            // 
            this.helyszinLabel.AutoSize = true;
            this.helyszinLabel.Location = new System.Drawing.Point(653, 223);
            this.helyszinLabel.Name = "helyszinLabel";
            this.helyszinLabel.Size = new System.Drawing.Size(100, 25);
            this.helyszinLabel.TabIndex = 3;
            this.helyszinLabel.Text = "Helyszín:";
            // 
            // percLabel
            // 
            this.percLabel.AutoSize = true;
            this.percLabel.Location = new System.Drawing.Point(383, 220);
            this.percLabel.Name = "percLabel";
            this.percLabel.Size = new System.Drawing.Size(54, 25);
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
            "Kézilabda"});
            this.sportagCombo.Location = new System.Drawing.Point(255, 94);
            this.sportagCombo.Name = "sportagCombo";
            this.sportagCombo.Size = new System.Drawing.Size(182, 33);
            this.sportagCombo.TabIndex = 5;
            // 
            // idotartamText
            // 
            this.idotartamText.Location = new System.Drawing.Point(255, 214);
            this.idotartamText.Name = "idotartamText";
            this.idotartamText.Size = new System.Drawing.Size(122, 31);
            this.idotartamText.TabIndex = 6;
            // 
            // datumDateTime
            // 
            this.datumDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDateTime.Location = new System.Drawing.Point(759, 93);
            this.datumDateTime.Name = "datumDateTime";
            this.datumDateTime.Size = new System.Drawing.Size(212, 31);
            this.datumDateTime.TabIndex = 7;
            // 
            // helyszinText
            // 
            this.helyszinText.Location = new System.Drawing.Point(759, 217);
            this.helyszinText.Name = "helyszinText";
            this.helyszinText.Size = new System.Drawing.Size(212, 31);
            this.helyszinText.TabIndex = 9;
            // 
            // felvitelButton
            // 
            this.felvitelButton.Location = new System.Drawing.Point(473, 304);
            this.felvitelButton.Name = "felvitelButton";
            this.felvitelButton.Size = new System.Drawing.Size(153, 40);
            this.felvitelButton.TabIndex = 10;
            this.felvitelButton.Text = "Felvitel";
            this.felvitelButton.UseVisualStyleBackColor = true;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(643, 304);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(153, 40);
            this.importButton.TabIndex = 11;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(818, 304);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(153, 40);
            this.exportButton.TabIndex = 12;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 655);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.felvitelButton);
            this.Controls.Add(this.helyszinText);
            this.Controls.Add(this.datumDateTime);
            this.Controls.Add(this.idotartamText);
            this.Controls.Add(this.sportagCombo);
            this.Controls.Add(this.percLabel);
            this.Controls.Add(this.helyszinLabel);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.idotartamLabel);
            this.Controls.Add(this.sportagLabel);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox idotartamText;
        private System.Windows.Forms.DateTimePicker datumDateTime;
        private System.Windows.Forms.TextBox helyszinText;
        private System.Windows.Forms.Button felvitelButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
    }
}

