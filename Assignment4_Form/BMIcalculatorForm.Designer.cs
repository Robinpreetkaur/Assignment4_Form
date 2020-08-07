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
            this.MatricradioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.CalculateBMIbutton = new System.Windows.Forms.Button();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeighttextBox = new System.Windows.Forms.TextBox();
            this.WeighttextBox = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.Heightlabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeighttextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeighttextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(312, 125);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MatricradioButton
            // 
            this.MatricradioButton.AutoSize = true;
            this.MatricradioButton.Location = new System.Drawing.Point(136, 61);
            this.MatricradioButton.Name = "MatricradioButton";
            this.MatricradioButton.Size = new System.Drawing.Size(137, 43);
            this.MatricradioButton.TabIndex = 0;
            this.MatricradioButton.TabStop = true;
            this.MatricradioButton.Text = "Metric";
            this.MatricradioButton.UseVisualStyleBackColor = true;
            this.MatricradioButton.CheckedChanged += new System.EventHandler(this.MatricradioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(136, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(182, 43);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Imperical";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.ImpericalradioButton_CheckedChanged);
            // 
            // CalculateBMIbutton
            // 
            this.CalculateBMIbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CalculateBMIbutton.Location = new System.Drawing.Point(43, 241);
            this.CalculateBMIbutton.Name = "CalculateBMIbutton";
            this.CalculateBMIbutton.Size = new System.Drawing.Size(248, 45);
            this.CalculateBMIbutton.TabIndex = 2;
            this.CalculateBMIbutton.Text = "Calculate BMI";
            this.CalculateBMIbutton.UseVisualStyleBackColor = false;
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.Heightlabel.Location = new System.Drawing.Point(3, 0);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(120, 59);
            this.Heightlabel.TabIndex = 0;
            this.Heightlabel.Text = "My Height";
            this.Heightlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 59);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(125, 66);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "My Weight";
            // 
            // HeighttextBox
            // 
            this.HeighttextBox.Location = new System.Drawing.Point(159, 3);
            this.HeighttextBox.Name = "HeighttextBox";
            this.HeighttextBox.Size = new System.Drawing.Size(141, 45);
            this.HeighttextBox.TabIndex = 2;
            // 
            // WeighttextBox
            // 
            this.WeighttextBox.Location = new System.Drawing.Point(159, 62);
            this.WeighttextBox.Name = "WeighttextBox";
            this.WeighttextBox.Size = new System.Drawing.Size(141, 45);
            this.WeighttextBox.TabIndex = 3;
            // 
            // CalculateBMItextBox
            // 
            this.CalculateBMItextBox.Enabled = false;
            this.CalculateBMItextBox.Location = new System.Drawing.Point(12, 346);
            this.CalculateBMItextBox.Multiline = true;
            this.CalculateBMItextBox.Name = "CalculateBMItextBox";
            this.CalculateBMItextBox.Size = new System.Drawing.Size(294, 75);
            this.CalculateBMItextBox.TabIndex = 3;
            // 
            // BMIlabel
            // 
            this.BMIlabel.AutoSize = true;
            this.BMIlabel.Location = new System.Drawing.Point(9, 301);
            this.BMIlabel.Name = "BMIlabel";
            this.BMIlabel.Size = new System.Drawing.Size(84, 39);
            this.BMIlabel.TabIndex = 4;
            this.BMIlabel.Text = "BMI";
            this.BMIlabel.Click += new System.EventHandler(this.BMIlabel_Click);
            // 
            // BMIresultTextbox
            // 
            this.BMIresultTextbox.BackColor = System.Drawing.SystemColors.Menu;
            this.BMIresultTextbox.Enabled = false;
            this.BMIresultTextbox.Location = new System.Drawing.Point(165, 295);
            this.BMIresultTextbox.Name = "BMIresultTextbox";
            this.BMIresultTextbox.Size = new System.Drawing.Size(141, 45);
            this.BMIresultTextbox.TabIndex = 5;
            this.BMIresultTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BMIcalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 433);
            this.Controls.Add(this.BMIresultTextbox);
            this.Controls.Add(this.BMIlabel);
            this.Controls.Add(this.CalculateBMItextBox);
            this.Controls.Add(this.CalculateBMIbutton);
            this.Controls.Add(this.MatricradioButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.radioButton2);
            this.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMIcalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton MatricradioButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button CalculateBMIbutton;
        private System.Windows.Forms.TextBox HeighttextBox;
        private System.Windows.Forms.TextBox WeighttextBox;
        private System.Windows.Forms.TextBox CalculateBMItextBox;
        private System.Windows.Forms.Label BMIlabel;
        private System.Windows.Forms.TextBox BMIresultTextbox;
    }
}

