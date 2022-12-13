namespace Tips_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.percentControl = new System.Windows.Forms.TrackBar();
            this.percentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.billAmountBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentControl)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(546, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(43, 33);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // percentControl
            // 
            this.percentControl.Location = new System.Drawing.Point(72, 145);
            this.percentControl.Name = "percentControl";
            this.percentControl.Size = new System.Drawing.Size(178, 45);
            this.percentControl.TabIndex = 1;
            this.percentControl.Scroll += new System.EventHandler(this.percentControl_Scroll);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(83)))), ((int)(((byte)(148)))));
            this.percentLabel.Location = new System.Drawing.Point(256, 145);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(36, 27);
            this.percentLabel.TabIndex = 2;
            this.percentLabel.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(83)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tip Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter bill amount (in USD):\r\n";
            // 
            // billAmountBox
            // 
            this.billAmountBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.billAmountBox.Location = new System.Drawing.Point(275, 70);
            this.billAmountBox.Name = "billAmountBox";
            this.billAmountBox.Size = new System.Drawing.Size(100, 20);
            this.billAmountBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select tipping percentage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(83)))), ((int)(((byte)(148)))));
            this.label4.Location = new System.Drawing.Point(334, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tip amount:";
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(83)))), ((int)(((byte)(148)))));
            this.tipLabel.Location = new System.Drawing.Point(463, 200);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(57, 24);
            this.tipLabel.TabIndex = 8;
            this.tipLabel.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(83)))), ((int)(((byte)(148)))));
            this.label6.Location = new System.Drawing.Point(334, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total bill price:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(83)))), ((int)(((byte)(148)))));
            this.totalLabel.Location = new System.Drawing.Point(495, 248);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(57, 24);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "$0.00";
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(72, 198);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(104, 39);
            this.calcButton.TabIndex = 11;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 336);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.billAmountBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.percentControl);
            this.Controls.Add(this.closeButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tips Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.TrackBar percentControl;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox billAmountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calcButton;
    }
}

