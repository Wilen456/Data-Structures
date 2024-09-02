namespace Unit1Prb3

{
    partial class Unit1Prb3Form
    {
      
        private System.ComponentModel.IContainer components = null;
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
            this.infixLabel = new System.Windows.Forms.Label();
            this.infixTextBox = new System.Windows.Forms.TextBox();
            this.postfixLabel = new System.Windows.Forms.Label();
            this.postfixTextBox = new System.Windows.Forms.TextBox();
            this.parseButton = new System.Windows.Forms.Button();
            this.cautionLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infixLabel
            // 
            this.infixLabel.AutoSize = true;
            this.infixLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infixLabel.Location = new System.Drawing.Point(12, 19);
            this.infixLabel.Name = "infixLabel";
            this.infixLabel.Size = new System.Drawing.Size(135, 21);
            this.infixLabel.TabIndex = 0;
            this.infixLabel.Text = "Infix expression:";
            // 
            // infixTextBox
            // 
            this.infixTextBox.Location = new System.Drawing.Point(171, 21);
            this.infixTextBox.Name = "infixTextBox";
            this.infixTextBox.Size = new System.Drawing.Size(262, 23);
            this.infixTextBox.TabIndex = 1;
            // 
            // postfixLabel
            // 
            this.postfixLabel.AutoSize = true;
            this.postfixLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postfixLabel.Location = new System.Drawing.Point(12, 72);
            this.postfixLabel.Name = "postfixLabel";
            this.postfixLabel.Size = new System.Drawing.Size(153, 21);
            this.postfixLabel.TabIndex = 2;
            this.postfixLabel.Text = "Postfix expression:";
            // 
            // postfixTextBox
            // 
            this.postfixTextBox.Location = new System.Drawing.Point(171, 74);
            this.postfixTextBox.Name = "postfixTextBox";
            this.postfixTextBox.ReadOnly = true;
            this.postfixTextBox.Size = new System.Drawing.Size(262, 23);
            this.postfixTextBox.TabIndex = 3;
            // 
            // parseButton
            // 
            this.parseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parseButton.Location = new System.Drawing.Point(12, 172);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(95, 36);
            this.parseButton.TabIndex = 4;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.parseButton_Click);
            // 
            // cautionLabel
            // 
            this.cautionLabel.AutoSize = true;
            this.cautionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.cautionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cautionLabel.ForeColor = System.Drawing.Color.Red;
            this.cautionLabel.Location = new System.Drawing.Point(12, 47);
            this.cautionLabel.Name = "cautionLabel";
            this.cautionLabel.Size = new System.Drawing.Size(408, 15);
            this.cautionLabel.TabIndex = 5;
            this.cautionLabel.Text = "Only +,*.-,/, ^ are supported operations, and a,b,c,d are supported variables.";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aLabel.Location = new System.Drawing.Point(22, 117);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(23, 21);
            this.aLabel.TabIndex = 6;
            this.aLabel.Text = "a:";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bLabel.Location = new System.Drawing.Point(132, 117);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(24, 21);
            this.bLabel.TabIndex = 7;
            this.bLabel.Text = "b:";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cLabel.Location = new System.Drawing.Point(242, 117);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(22, 21);
            this.cLabel.TabIndex = 8;
            this.cLabel.Text = "c:";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dLabel.Location = new System.Drawing.Point(347, 117);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(24, 21);
            this.dLabel.TabIndex = 9;
            this.dLabel.Text = "d:";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(51, 115);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(56, 23);
            this.aTextBox.TabIndex = 10;
            this.aTextBox.Text = "0.0";
            this.aTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(162, 115);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(56, 23);
            this.bTextBox.TabIndex = 11;
            this.bTextBox.Text = "0.0";
            this.bTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(270, 115);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(56, 23);
            this.cTextBox.TabIndex = 12;
            this.cTextBox.Text = "0.0";
            this.cTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dTextBox
            // 
            this.dTextBox.Location = new System.Drawing.Point(377, 115);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(56, 23);
            this.dTextBox.TabIndex = 13;
            this.dTextBox.Text = "0.0";
            this.dTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(333, 172);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.ReadOnly = true;
            this.valueTextBox.Size = new System.Drawing.Size(100, 23);
            this.valueTextBox.TabIndex = 14;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.valueLabel.Location = new System.Drawing.Point(184, 172);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(142, 21);
            this.valueLabel.TabIndex = 15;
            this.valueLabel.Text = "Expression value:";
            // 
            // Unit1Prb3Form
            // 
            this.AcceptButton = this.parseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 220);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.dTextBox);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.cautionLabel);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.postfixTextBox);
            this.Controls.Add(this.postfixLabel);
            this.Controls.Add(this.infixTextBox);
            this.Controls.Add(this.infixLabel);
            this.MaximizeBox = false;
            this.Name = "Unit1Prb3Form";
            this.Text = "Unit1Prb3 - Thuong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label infixLabel;
        private TextBox infixTextBox;
        private Label postfixLabel;
        private TextBox postfixTextBox;
        private Button parseButton;
        private Label cautionLabel;
        private Label aLabel;
        private Label bLabel;
        private Label cLabel;
        private Label dLabel;
        private TextBox aTextBox;
        private TextBox bTextBox;
        private TextBox cTextBox;
        private TextBox dTextBox;
        private TextBox valueTextBox;
        private Label valueLabel;
    }
}