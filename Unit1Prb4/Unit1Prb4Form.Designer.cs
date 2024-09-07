namespace Unit1Prb4
{
    partial class Unit1Prb4Form
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
            numberOfOrdersLabel = new Label();
            orderQueueLabel = new Label();
            queueTextBox = new TextBox();
            numTextBox = new TextBox();
            newOrderButton = new Button();
            releaseOrderButton = new Button();
            SuspendLayout();
            // 
            // numberOfOrdersLabel
            // 
            numberOfOrdersLabel.AutoSize = true;
            numberOfOrdersLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numberOfOrdersLabel.Location = new Point(12, 20);
            numberOfOrdersLabel.Name = "numberOfOrdersLabel";
            numberOfOrdersLabel.Size = new Size(149, 21);
            numberOfOrdersLabel.TabIndex = 0;
            numberOfOrdersLabel.Text = "Number of orders:";
            // 
            // orderQueueLabel
            // 
            orderQueueLabel.AutoSize = true;
            orderQueueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderQueueLabel.Location = new Point(12, 56);
            orderQueueLabel.Name = "orderQueueLabel";
            orderQueueLabel.Size = new Size(107, 21);
            orderQueueLabel.TabIndex = 1;
            orderQueueLabel.Text = "Order Queue";
            // 
            // queueTextBox
            // 
            queueTextBox.Location = new Point(12, 90);
            queueTextBox.Multiline = true;
            queueTextBox.Name = "queueTextBox";
            queueTextBox.ReadOnly = true;
            queueTextBox.Size = new Size(305, 334);
            queueTextBox.TabIndex = 2;
            queueTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // numTextBox
            // 
            numTextBox.Location = new Point(159, 22);
            numTextBox.Name = "numTextBox";
            numTextBox.ReadOnly = true;
            numTextBox.Size = new Size(25, 23);
            numTextBox.TabIndex = 3;
            numTextBox.Text = "0";
            numTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // newOrderButton
            // 
            newOrderButton.Location = new Point(125, 57);
            newOrderButton.Name = "newOrderButton";
            newOrderButton.Size = new Size(104, 23);
            newOrderButton.TabIndex = 4;
            newOrderButton.Text = "New work order";
            newOrderButton.UseVisualStyleBackColor = true;
            newOrderButton.Click += newJobButton_Click;
            // 
            // releaseOrderButton
            // 
            releaseOrderButton.Location = new Point(242, 57);
            releaseOrderButton.Name = "releaseOrderButton";
            releaseOrderButton.Size = new Size(75, 23);
            releaseOrderButton.TabIndex = 5;
            releaseOrderButton.Text = "Release Order";
            releaseOrderButton.UseVisualStyleBackColor = true;
            releaseOrderButton.Click += releaseOrderButton_Click;
            // 
            // Unit1Prb4Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 450);
            Controls.Add(releaseOrderButton);
            Controls.Add(newOrderButton);
            Controls.Add(numTextBox);
            Controls.Add(queueTextBox);
            Controls.Add(orderQueueLabel);
            Controls.Add(numberOfOrdersLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Unit1Prb4Form";
            Text = "Unit1Prb4 - Thuong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numberOfOrdersLabel;
        private Label orderQueueLabel;
        private TextBox queueTextBox;
        private TextBox numTextBox;
        private Button newOrderButton;
        private Button releaseOrderButton;
    }
}