namespace TemperatureConverter
{
    partial class TempConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.FromComboBox = new System.Windows.Forms.ComboBox();
            this.ToComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LabelFormula = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(202, 81);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.PlaceholderText = "Output";
            this.OutputTextBox.Size = new System.Drawing.Size(160, 23);
            this.OutputTextBox.TabIndex = 2;
            this.OutputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OutputTextBox_KeyPress);
            this.OutputTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OutputTextBox_KeyUp);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(11, 81);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.PlaceholderText = "Input";
            this.InputTextBox.Size = new System.Drawing.Size(160, 23);
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            this.InputTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputTextBox_KeyUp);
            // 
            // FromComboBox
            // 
            this.FromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Items.AddRange(new object[] {
            "Celsius",
            "Kelvin",
            "Fahrenheit",
            "Rankine"});
            this.FromComboBox.Location = new System.Drawing.Point(11, 59);
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(160, 23);
            this.FromComboBox.TabIndex = 3;
            this.FromComboBox.SelectedIndexChanged += new System.EventHandler(this.FromComboBox_SelectedIndexChanged);
            // 
            // ToComboBox
            // 
            this.ToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToComboBox.FormattingEnabled = true;
            this.ToComboBox.Items.AddRange(new object[] {
            "Celsius",
            "Kelvin",
            "Fahrenheit",
            "Rankine"});
            this.ToComboBox.Location = new System.Drawing.Point(202, 59);
            this.ToComboBox.Name = "ToComboBox";
            this.ToComboBox.Size = new System.Drawing.Size(160, 23);
            this.ToComboBox.TabIndex = 3;
            this.ToComboBox.SelectedIndexChanged += new System.EventHandler(this.ToComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Temperature Converter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Note:To keep history press the Enter button.";
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(11, 224);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(109, 23);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "Show History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(301, 224);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LabelFormula
            // 
            this.LabelFormula.AutoSize = true;
            this.LabelFormula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelFormula.Location = new System.Drawing.Point(95, 162);
            this.LabelFormula.Name = "LabelFormula";
            this.LabelFormula.Size = new System.Drawing.Size(0, 21);
            this.LabelFormula.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(175, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 7;
            // 
            // TempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.LabelFormula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ToComboBox);
            this.Controls.Add(this.FromComboBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(402, 298);
            this.Name = "TempConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.TempConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox OutputTextBox;
        private TextBox InputTextBox;
        private ComboBox FromComboBox;
        private ComboBox ToComboBox;
        private Label label4;
        private Label label5;
        private Button btnHistory;
        private Button btnExit;
        private Label LabelFormula;
        private Label label3;
        private Label label1;
    }
}