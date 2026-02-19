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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sportag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idotartam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helyszin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sportagLabel
            // 
            this.sportagLabel.AutoSize = true;
            this.sportagLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sportagLabel.Location = new System.Drawing.Point(127, 99);
            this.sportagLabel.Name = "sportagLabel";
            this.sportagLabel.Size = new System.Drawing.Size(129, 29);
            this.sportagLabel.TabIndex = 0;
            this.sportagLabel.Text = "Sportág:";
            // 
            // idotartamLabel
            // 
            this.idotartamLabel.AutoSize = true;
            this.idotartamLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.idotartamLabel.Location = new System.Drawing.Point(127, 217);
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
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(112, 29);
            this.datumLabel.TabIndex = 2;
            this.datumLabel.Text = "Dátum:";
            // 
            // helyszinLabel
            // 
            this.helyszinLabel.AutoSize = true;
            this.helyszinLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.helyszinLabel.Location = new System.Drawing.Point(632, 216);
            this.helyszinLabel.Name = "helyszinLabel";
            this.helyszinLabel.Size = new System.Drawing.Size(136, 29);
            this.helyszinLabel.TabIndex = 3;
            this.helyszinLabel.Text = "Helyszín:";
            // 
            // percLabel
            // 
            this.percLabel.AutoSize = true;
            this.percLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.percLabel.Location = new System.Drawing.Point(403, 219);
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
            "Kézilabda"});
            this.sportagCombo.Location = new System.Drawing.Point(293, 100);
            this.sportagCombo.Name = "sportagCombo";
            this.sportagCombo.Size = new System.Drawing.Size(182, 33);
            this.sportagCombo.TabIndex = 5;
            // 
            // idotartamText
            // 
            this.idotartamText.Location = new System.Drawing.Point(293, 217);
            this.idotartamText.Name = "idotartamText";
            this.idotartamText.Size = new System.Drawing.Size(104, 31);
            this.idotartamText.TabIndex = 6;
            // 
            // datumDateTime
            // 
            this.datumDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDateTime.Location = new System.Drawing.Point(776, 104);
            this.datumDateTime.Name = "datumDateTime";
            this.datumDateTime.Size = new System.Drawing.Size(212, 31);
            this.datumDateTime.TabIndex = 7;
            // 
            // helyszinText
            // 
            this.helyszinText.Location = new System.Drawing.Point(776, 218);
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
            this.felvitelButton.Location = new System.Drawing.Point(244, 304);
            this.felvitelButton.Name = "felvitelButton";
            this.felvitelButton.Size = new System.Drawing.Size(153, 49);
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
            this.importButton.Location = new System.Drawing.Point(475, 304);
            this.importButton.Margin = new System.Windows.Forms.Padding(0);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(153, 49);
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
            this.exportButton.Location = new System.Drawing.Point(699, 304);
            this.exportButton.Margin = new System.Windows.Forms.Padding(0);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(153, 49);
            this.exportButton.TabIndex = 12;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeight = 46;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sportag,
            this.idotartam,
            this.helyszin,
            this.datum});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(154, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(804, 172);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sportag
            // 
            this.sportag.HeaderText = "Sportág";
            this.sportag.MinimumWidth = 10;
            this.sportag.Name = "sportag";
            this.sportag.Width = 200;
            // 
            // idotartam
            // 
            this.idotartam.HeaderText = "Időtartam(perc)";
            this.idotartam.MinimumWidth = 10;
            this.idotartam.Name = "idotartam";
            this.idotartam.Width = 200;
            // 
            // helyszin
            // 
            this.helyszin.HeaderText = "Helyszín";
            this.helyszin.MinimumWidth = 10;
            this.helyszin.Name = "helyszin";
            this.helyszin.Width = 200;
            // 
            // datum
            // 
            this.datum.HeaderText = "Dátum";
            this.datum.MinimumWidth = 10;
            this.datum.Name = "datum";
            this.datum.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 655);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportag;
        private System.Windows.Forms.DataGridViewTextBoxColumn idotartam;
        private System.Windows.Forms.DataGridViewTextBoxColumn helyszin;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
    }
}

