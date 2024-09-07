namespace Unit1Prb4
{
    partial class addForm
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
            addButton = new Button();
            cancelButton = new Button();
            numLabel = new Label();
            orderNumTextBox = new TextBox();
            nameTextBox = new TextBox();
            uNameLabel = new Label();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 67);
            addButton.Name = "addButton";
            addButton.Size = new Size(120, 23);
            addButton.TabIndex = 0;
            addButton.Text = "Add work order";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(138, 67);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.Location = new Point(12, 9);
            numLabel.Name = "numLabel";
            numLabel.Size = new Size(87, 15);
            numLabel.TabIndex = 2;
            numLabel.Text = "Order Number:";
            // 
            // orderNumTextBox
            // 
            orderNumTextBox.Location = new Point(113, 6);
            orderNumTextBox.Name = "orderNumTextBox";
            orderNumTextBox.Size = new Size(100, 23);
            orderNumTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(113, 32);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 5;
            // 
            // uNameLabel
            // 
            uNameLabel.AutoSize = true;
            uNameLabel.Location = new Point(57, 32);
            uNameLabel.Name = "uNameLabel";
            uNameLabel.Size = new Size(42, 15);
            uNameLabel.TabIndex = 3;
            uNameLabel.Text = "Name:";
            // 
            // addForm
            // 
            AcceptButton = addButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(225, 110);
            Controls.Add(nameTextBox);
            Controls.Add(orderNumTextBox);
            Controls.Add(uNameLabel);
            Controls.Add(numLabel);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "addForm";
            Text = "New";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button cancelButton;
        private Label numLabel;
        private TextBox orderNumTextBox;
        private TextBox nameTextBox;
        private Label uNameLabel;
    }
}