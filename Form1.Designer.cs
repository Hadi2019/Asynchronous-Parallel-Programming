namespace Hadi_Alkhashman_Sec004_Ex01
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelFactorialMessage = new System.Windows.Forms.Label();
            this.textBoxFactorialResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCalculateFactorial = new System.Windows.Forms.Button();
            this.textBoxFactorialInput = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelOddEvenError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOddEvenInput = new System.Windows.Forms.TextBox();
            this.buttonOddEven = new System.Windows.Forms.Button();
            this.textBoxOddEvenResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxLowHighResult = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonInteger = new System.Windows.Forms.RadioButton();
            this.radioButtonDouble = new System.Windows.Forms.RadioButton();
            this.radioButtonChar = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelDisplayError = new System.Windows.Forms.Label();
            this.textBoxHighIndexInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxLowIndexInput = new System.Windows.Forms.TextBox();
            this.textBoxSearchInput = new System.Windows.Forms.TextBox();
            this.buttonGenerateValues = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelSearchError = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelFactorialMessage);
            this.groupBox2.Controls.Add(this.textBoxFactorialResult);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonCalculateFactorial);
            this.groupBox2.Controls.Add(this.textBoxFactorialInput);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 147);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(1) Calculate Asynchronously";
            // 
            // labelFactorialMessage
            // 
            this.labelFactorialMessage.AutoSize = true;
            this.labelFactorialMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFactorialMessage.Location = new System.Drawing.Point(106, 70);
            this.labelFactorialMessage.Name = "labelFactorialMessage";
            this.labelFactorialMessage.Size = new System.Drawing.Size(0, 13);
            this.labelFactorialMessage.TabIndex = 31;
            // 
            // textBoxFactorialResult
            // 
            this.textBoxFactorialResult.Enabled = false;
            this.textBoxFactorialResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFactorialResult.Location = new System.Drawing.Point(88, 103);
            this.textBoxFactorialResult.Name = "textBoxFactorialResult";
            this.textBoxFactorialResult.ReadOnly = true;
            this.textBoxFactorialResult.Size = new System.Drawing.Size(175, 20);
            this.textBoxFactorialResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Get Factorial of:";
            // 
            // buttonCalculateFactorial
            // 
            this.buttonCalculateFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculateFactorial.Location = new System.Drawing.Point(13, 65);
            this.buttonCalculateFactorial.Name = "buttonCalculateFactorial";
            this.buttonCalculateFactorial.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateFactorial.TabIndex = 3;
            this.buttonCalculateFactorial.Text = "Calculate";
            this.buttonCalculateFactorial.UseVisualStyleBackColor = true;
            this.buttonCalculateFactorial.Click += new System.EventHandler(this.buttonCalculateFactorial_Click);
            // 
            // textBoxFactorialInput
            // 
            this.textBoxFactorialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFactorialInput.Location = new System.Drawing.Point(104, 28);
            this.textBoxFactorialInput.Name = "textBoxFactorialInput";
            this.textBoxFactorialInput.Size = new System.Drawing.Size(161, 20);
            this.textBoxFactorialInput.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelOddEvenError);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxOddEvenInput);
            this.groupBox4.Controls.Add(this.buttonOddEven);
            this.groupBox4.Controls.Add(this.textBoxOddEvenResult);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(24, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 136);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "(2) Check for Even/Odd";
            // 
            // labelOddEvenError
            // 
            this.labelOddEvenError.AutoSize = true;
            this.labelOddEvenError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOddEvenError.Location = new System.Drawing.Point(103, 54);
            this.labelOddEvenError.Name = "labelOddEvenError";
            this.labelOddEvenError.Size = new System.Drawing.Size(0, 13);
            this.labelOddEvenError.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Input Number :";
            // 
            // textBoxOddEvenInput
            // 
            this.textBoxOddEvenInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOddEvenInput.Location = new System.Drawing.Point(106, 31);
            this.textBoxOddEvenInput.Name = "textBoxOddEvenInput";
            this.textBoxOddEvenInput.Size = new System.Drawing.Size(157, 20);
            this.textBoxOddEvenInput.TabIndex = 8;
            // 
            // buttonOddEven
            // 
            this.buttonOddEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOddEven.Location = new System.Drawing.Point(0, 82);
            this.buttonOddEven.Name = "buttonOddEven";
            this.buttonOddEven.Size = new System.Drawing.Size(100, 23);
            this.buttonOddEven.TabIndex = 9;
            this.buttonOddEven.Text = "Check Even/Odd";
            this.buttonOddEven.UseVisualStyleBackColor = true;
            this.buttonOddEven.Click += new System.EventHandler(this.buttonOddEven_Clicked);
            // 
            // textBoxOddEvenResult
            // 
            this.textBoxOddEvenResult.Enabled = false;
            this.textBoxOddEvenResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOddEvenResult.Location = new System.Drawing.Point(209, 85);
            this.textBoxOddEvenResult.Name = "textBoxOddEvenResult";
            this.textBoxOddEvenResult.ReadOnly = true;
            this.textBoxOddEvenResult.Size = new System.Drawing.Size(48, 20);
            this.textBoxOddEvenResult.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "The Number is :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelSearchError);
            this.groupBox3.Controls.Add(this.buttonDisplay);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.textBoxLowHighResult);
            this.groupBox3.Controls.Add(this.buttonExit);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.labelDisplayError);
            this.groupBox3.Controls.Add(this.textBoxHighIndexInput);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxLowIndexInput);
            this.groupBox3.Controls.Add(this.textBoxSearchInput);
            this.groupBox3.Controls.Add(this.buttonGenerateValues);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(356, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 289);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(3) Display List of Values and Search";
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.ForeColor = System.Drawing.Color.Black;
            this.buttonDisplay.Location = new System.Drawing.Point(316, 133);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplay.TabIndex = 33;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.ButtonLowHighDisplay);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(51, 160);
            this.listBox1.TabIndex = 32;
            // 
            // textBoxLowHighResult
            // 
            this.textBoxLowHighResult.Enabled = false;
            this.textBoxLowHighResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLowHighResult.Location = new System.Drawing.Point(69, 230);
            this.textBoxLowHighResult.Name = "textBoxLowHighResult";
            this.textBoxLowHighResult.ReadOnly = true;
            this.textBoxLowHighResult.Size = new System.Drawing.Size(322, 20);
            this.textBoxLowHighResult.TabIndex = 24;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(316, 256);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 28;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonInteger);
            this.groupBox1.Controls.Add(this.radioButtonDouble);
            this.groupBox1.Controls.Add(this.radioButtonChar);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 33);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonInteger
            // 
            this.radioButtonInteger.AutoSize = true;
            this.radioButtonInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInteger.Location = new System.Drawing.Point(6, 10);
            this.radioButtonInteger.Name = "radioButtonInteger";
            this.radioButtonInteger.Size = new System.Drawing.Size(63, 17);
            this.radioButtonInteger.TabIndex = 13;
            this.radioButtonInteger.TabStop = true;
            this.radioButtonInteger.Text = "Integers";
            this.radioButtonInteger.UseVisualStyleBackColor = true;
            // 
            // radioButtonDouble
            // 
            this.radioButtonDouble.AutoSize = true;
            this.radioButtonDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDouble.Location = new System.Drawing.Point(75, 10);
            this.radioButtonDouble.Name = "radioButtonDouble";
            this.radioButtonDouble.Size = new System.Drawing.Size(64, 17);
            this.radioButtonDouble.TabIndex = 14;
            this.radioButtonDouble.TabStop = true;
            this.radioButtonDouble.Text = "Doubles";
            this.radioButtonDouble.UseVisualStyleBackColor = true;
            // 
            // radioButtonChar
            // 
            this.radioButtonChar.AutoSize = true;
            this.radioButtonChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChar.Location = new System.Drawing.Point(147, 10);
            this.radioButtonChar.Name = "radioButtonChar";
            this.radioButtonChar.Size = new System.Drawing.Size(47, 17);
            this.radioButtonChar.TabIndex = 15;
            this.radioButtonChar.TabStop = true;
            this.radioButtonChar.Text = "Char";
            this.radioButtonChar.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(316, 63);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 25;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Clicked);
            // 
            // labelDisplayError
            // 
            this.labelDisplayError.AutoSize = true;
            this.labelDisplayError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayError.Location = new System.Drawing.Point(63, 176);
            this.labelDisplayError.Name = "labelDisplayError";
            this.labelDisplayError.Size = new System.Drawing.Size(0, 13);
            this.labelDisplayError.TabIndex = 31;
            // 
            // textBoxHighIndexInput
            // 
            this.textBoxHighIndexInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHighIndexInput.Location = new System.Drawing.Point(183, 146);
            this.textBoxHighIndexInput.Name = "textBoxHighIndexInput";
            this.textBoxHighIndexInput.Size = new System.Drawing.Size(115, 20);
            this.textBoxHighIndexInput.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(66, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Output Values between Low and High:";
            // 
            // textBoxLowIndexInput
            // 
            this.textBoxLowIndexInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLowIndexInput.Location = new System.Drawing.Point(183, 116);
            this.textBoxLowIndexInput.Name = "textBoxLowIndexInput";
            this.textBoxLowIndexInput.Size = new System.Drawing.Size(115, 20);
            this.textBoxLowIndexInput.TabIndex = 22;
            // 
            // textBoxSearchInput
            // 
            this.textBoxSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchInput.Location = new System.Drawing.Point(183, 65);
            this.textBoxSearchInput.Name = "textBoxSearchInput";
            this.textBoxSearchInput.Size = new System.Drawing.Size(115, 20);
            this.textBoxSearchInput.TabIndex = 21;
            // 
            // buttonGenerateValues
            // 
            this.buttonGenerateValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateValues.Location = new System.Drawing.Point(209, 23);
            this.buttonGenerateValues.Name = "buttonGenerateValues";
            this.buttonGenerateValues.Size = new System.Drawing.Size(121, 23);
            this.buttonGenerateValues.TabIndex = 16;
            this.buttonGenerateValues.Text = "Generate Values";
            this.buttonGenerateValues.UseVisualStyleBackColor = true;
            this.buttonGenerateValues.Click += new System.EventHandler(this.buttonGenerateValues_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Input High Index";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Input Values for Search";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Input Low Index";
            // 
            // labelSearchError
            // 
            this.labelSearchError.AutoSize = true;
            this.labelSearchError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchError.Location = new System.Drawing.Point(66, 92);
            this.labelSearchError.Name = "labelSearchError";
            this.labelSearchError.Size = new System.Drawing.Size(0, 13);
            this.labelSearchError.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 335);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Asychronous Programming";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxFactorialResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCalculateFactorial;
        private System.Windows.Forms.TextBox textBoxFactorialInput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOddEvenInput;
        private System.Windows.Forms.Button buttonOddEven;
        private System.Windows.Forms.TextBox textBoxOddEvenResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxLowHighResult;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLowHighDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonInteger;
        private System.Windows.Forms.RadioButton radioButtonDouble;
        private System.Windows.Forms.RadioButton radioButtonChar;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelDisplayError;
        private System.Windows.Forms.TextBox textBoxHighIndexInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxLowIndexInput;
        private System.Windows.Forms.TextBox textBoxSearchInput;
        private System.Windows.Forms.Button buttonGenerateValues;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelFactorialMessage;
        private System.Windows.Forms.Label labelOddEvenError;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Label labelSearchError;
    }
}

