namespace Assignment4_Form
{
    partial class BMIcalculatorForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImpericalRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateBMIbutton = new System.Windows.Forms.Button();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMItextBox = new System.Windows.Forms.TextBox();
            this.BMIlabel = new System.Windows.Forms.Label();
            this.BMIresultTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.HeightTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Heightlabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 116);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 132);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(141, 64);
            this.MetricRadioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(114, 44);
            this.MetricRadioButton.TabIndex = 0;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MatricradioButton_CheckedChanged);
            // 
            // ImpericalRadioButton
            // 
            this.ImpericalRadioButton.AutoSize = true;
            this.ImpericalRadioButton.Location = new System.Drawing.Point(139, 14);
            this.ImpericalRadioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ImpericalRadioButton.Name = "ImpericalRadioButton";
            this.ImpericalRadioButton.Size = new System.Drawing.Size(152, 44);
            this.ImpericalRadioButton.TabIndex = 1;
            this.ImpericalRadioButton.TabStop = true;
            this.ImpericalRadioButton.Text = "Imperical";
            this.ImpericalRadioButton.UseVisualStyleBackColor = true;
            this.ImpericalRadioButton.CheckedChanged += new System.EventHandler(this.ImpericalradioButton_CheckedChanged);
            // 
            // CalculateBMIbutton
            // 
            this.CalculateBMIbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalculateBMIbutton.Location = new System.Drawing.Point(57, 254);
            this.CalculateBMIbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CalculateBMIbutton.Name = "CalculateBMIbutton";
            this.CalculateBMIbutton.Size = new System.Drawing.Size(198, 47);
            this.CalculateBMIbutton.TabIndex = 2;
            this.CalculateBMIbutton.Text = "Calculate BMI";
            this.CalculateBMIbutton.UseVisualStyleBackColor = false;
            this.CalculateBMIbutton.Click += new System.EventHandler(this.CalculateBMIbutton_click);
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.Heightlabel.Location = new System.Drawing.Point(2, 0);
            this.Heightlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(99, 62);
            this.Heightlabel.TabIndex = 0;
            this.Heightlabel.Text = "My Height";
            this.Heightlabel.Click += new System.EventHandler(this.myHeight_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(2, 62);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(105, 70);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.Click += new System.EventHandler(this.myWeight_click);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(145, 3);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(114, 45);
            this.HeightTextBox.TabIndex = 2;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(145, 65);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(114, 45);
            this.WeightTextBox.TabIndex = 3;
            // 
            // CalculateBMItextBox
            // 
            this.CalculateBMItextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CalculateBMItextBox.Enabled = false;
            this.CalculateBMItextBox.Location = new System.Drawing.Point(28, 355);
            this.CalculateBMItextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CalculateBMItextBox.Multiline = true;
            this.CalculateBMItextBox.Name = "CalculateBMItextBox";
            this.CalculateBMItextBox.Size = new System.Drawing.Size(236, 66);
            this.CalculateBMItextBox.TabIndex = 3;
            // 
            // BMIlabel
            // 
            this.BMIlabel.AutoSize = true;
            this.BMIlabel.Location = new System.Drawing.Point(11, 312);
            this.BMIlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BMIlabel.Name = "BMIlabel";
            this.BMIlabel.Size = new System.Drawing.Size(67, 40);
            this.BMIlabel.TabIndex = 4;
            this.BMIlabel.Text = "BMI";
            this.BMIlabel.Click += new System.EventHandler(this.BMIlabel_Click);
            // 
            // BMIresultTextbox
            // 
            this.BMIresultTextbox.BackColor = System.Drawing.SystemColors.Menu;
            this.BMIresultTextbox.Enabled = false;
            this.BMIresultTextbox.Location = new System.Drawing.Point(150, 304);
            this.BMIresultTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BMIresultTextbox.Name = "BMIresultTextbox";
            this.BMIresultTextbox.Size = new System.Drawing.Size(114, 45);
            this.BMIresultTextbox.TabIndex = 5;
            // 
            // BMIcalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.BMIresultTextbox);
            this.Controls.Add(this.BMIlabel);
            this.Controls.Add(this.CalculateBMItextBox);
            this.Controls.Add(this.CalculateBMIbutton);
            this.Controls.Add(this.MetricRadioButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ImpericalRadioButton);
            this.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "BMIcalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMIcalculatorForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImpericalRadioButton;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button CalculateBMIbutton;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox CalculateBMItextBox;
        private System.Windows.Forms.Label BMIlabel;
        private System.Windows.Forms.TextBox BMIresultTextbox;
    }
}

