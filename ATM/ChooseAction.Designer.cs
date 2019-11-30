namespace ATM_
{
    partial class ChooseAction
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
            this.panelIO = new System.Windows.Forms.Panel();
            this.radioButtonCashIn = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIO
            // 
            this.panelIO.Controls.Add(this.radioButtonCashIn);
            this.panelIO.Controls.Add(this.radioButton2);
            this.panelIO.Location = new System.Drawing.Point(82, 16);
            this.panelIO.Name = "panelIO";
            this.panelIO.Size = new System.Drawing.Size(100, 53);
            this.panelIO.TabIndex = 43;
            // 
            // radioButtonCashIn
            // 
            this.radioButtonCashIn.AutoSize = true;
            this.radioButtonCashIn.Location = new System.Drawing.Point(10, 5);
            this.radioButtonCashIn.Name = "radioButtonCashIn";
            this.radioButtonCashIn.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCashIn.TabIndex = 40;
            this.radioButtonCashIn.TabStop = true;
            this.radioButtonCashIn.Text = "Снять";
            this.radioButtonCashIn.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 41;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Внести";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Выберите дальнейшее действие:";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(277, 46);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 47;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(278, 20);
            this.textSum.Name = "textSum";
            this.textSum.Size = new System.Drawing.Size(74, 20);
            this.textSum.TabIndex = 49;
            this.textSum.TextChanged += new System.EventHandler(this.SumChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Введите сумму:";
            // 
            // ChooseAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 79);
            this.Controls.Add(this.textSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelIO);
            this.Name = "ChooseAction";
            this.Text = "ATM";
            this.panelIO.ResumeLayout(false);
            this.panelIO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIO;
        private System.Windows.Forms.RadioButton radioButtonCashIn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.Label label1;
    }
}