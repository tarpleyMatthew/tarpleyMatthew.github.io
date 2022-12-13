namespace SimpleCalculator
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
            this.resultWindow = new System.Windows.Forms.TextBox();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.ceButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.timesButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.decButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultWindow
            // 
            this.resultWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultWindow.Location = new System.Drawing.Point(11, 12);
            this.resultWindow.Name = "resultWindow";
            this.resultWindow.Size = new System.Drawing.Size(344, 44);
            this.resultWindow.TabIndex = 0;
            this.resultWindow.Text = "0";
            this.resultWindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.White;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.Location = new System.Drawing.Point(12, 94);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(64, 55);
            this.sevenButton.TabIndex = 1;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.button_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.White;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(82, 94);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(64, 55);
            this.eightButton.TabIndex = 2;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.button_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.White;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(152, 94);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(64, 55);
            this.nineButton.TabIndex = 3;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.button_Click);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.Color.White;
            this.divButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divButton.Location = new System.Drawing.Point(222, 94);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(64, 55);
            this.divButton.TabIndex = 4;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // ceButton
            // 
            this.ceButton.BackColor = System.Drawing.Color.White;
            this.ceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceButton.Location = new System.Drawing.Point(292, 94);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(64, 55);
            this.ceButton.TabIndex = 5;
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = false;
            this.ceButton.Click += new System.EventHandler(this.CE_click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.White;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(11, 155);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(64, 55);
            this.fourButton.TabIndex = 6;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.button_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.White;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(82, 155);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(64, 55);
            this.fiveButton.TabIndex = 7;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.button_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.White;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(152, 155);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(64, 55);
            this.sixButton.TabIndex = 8;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.button_Click);
            // 
            // timesButton
            // 
            this.timesButton.BackColor = System.Drawing.Color.White;
            this.timesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesButton.Location = new System.Drawing.Point(222, 155);
            this.timesButton.Name = "timesButton";
            this.timesButton.Size = new System.Drawing.Size(64, 55);
            this.timesButton.TabIndex = 9;
            this.timesButton.Text = "*";
            this.timesButton.UseVisualStyleBackColor = false;
            this.timesButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.Color.White;
            this.cButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton.Location = new System.Drawing.Point(292, 155);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(64, 55);
            this.cButton.TabIndex = 10;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = false;
            this.cButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.White;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(12, 216);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(64, 55);
            this.oneButton.TabIndex = 11;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.button_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.White;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(82, 216);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(64, 55);
            this.twoButton.TabIndex = 12;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.button_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.White;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(152, 216);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(64, 55);
            this.threeButton.TabIndex = 13;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.button_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.White;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(222, 216);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(64, 55);
            this.minusButton.TabIndex = 14;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.BackColor = System.Drawing.Color.Orange;
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(292, 216);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(64, 116);
            this.equalsButton.TabIndex = 15;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = false;
            this.equalsButton.Click += new System.EventHandler(this.equals_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.White;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(222, 277);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(64, 55);
            this.plusButton.TabIndex = 16;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // decButton
            // 
            this.decButton.BackColor = System.Drawing.Color.White;
            this.decButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decButton.Location = new System.Drawing.Point(152, 277);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(64, 55);
            this.decButton.TabIndex = 17;
            this.decButton.Text = ".";
            this.decButton.UseVisualStyleBackColor = false;
            this.decButton.Click += new System.EventHandler(this.button_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.White;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(12, 277);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(134, 55);
            this.zeroButton.TabIndex = 18;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.button_Click);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.Color.White;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.equation.Location = new System.Drawing.Point(12, 12);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 24);
            this.equation.TabIndex = 19;
            // 
            // Form1
            // 
            this.AcceptButton = this.equalsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(371, 355);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.timesButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.ceButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.resultWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultWindow;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button ceButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button timesButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Label equation;
    }
}

