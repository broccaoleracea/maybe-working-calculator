namespace calc_app
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            label1 = new Label();
            btnPlus = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            numParam2 = new NumericUpDown();
            numParam1 = new NumericUpDown();
            groupBox2 = new GroupBox();
            lblResult = new Label();
            btnMin = new Button();
            btnDivide = new Button();
            btnTimes = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numParam2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numParam1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(351, 38);
            label1.TabIndex = 1;
            label1.Text = "Maybe Working Calculator";
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(45, 147);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 40);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 8;
            label2.Text = "First Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 54);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 9;
            label3.Text = "Second Number";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numParam2);
            groupBox1.Controls.Add(numParam1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(21, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 91);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parameters";
            // 
            // numParam2
            // 
            numParam2.Location = new Point(117, 51);
            numParam2.Name = "numParam2";
            numParam2.Size = new Size(242, 23);
            numParam2.TabIndex = 10;
            // 
            // numParam1
            // 
            numParam1.Location = new Point(117, 22);
            numParam1.Name = "numParam1";
            numParam1.Size = new Size(242, 23);
            numParam1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblResult);
            groupBox2.Location = new Point(21, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 104);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Montserrat SemiBold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(6, 19);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 38);
            lblResult.TabIndex = 0;
            // 
            // btnMin
            // 
            btnMin.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMin.Location = new Point(126, 147);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(75, 40);
            btnMin.TabIndex = 11;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(207, 147);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 40);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnTimes
            // 
            btnTimes.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimes.Location = new Point(288, 147);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(75, 40);
            btnTimes.TabIndex = 13;
            btnTimes.Text = "x";
            btnTimes.UseVisualStyleBackColor = true;
            btnTimes.Click += btnTimes_Click;
            // 
            // Calculator
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(405, 307);
            Controls.Add(btnTimes);
            Controls.Add(btnDivide);
            Controls.Add(btnMin);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnPlus);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Calculator";
            Text = "Calculator";
            FormClosing += Calculator_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numParam2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numParam1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPlus;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnMin;
        private Button btnDivide;
        private Button btnTimes;
        private Label lblResult;
        private NumericUpDown numParam2;
        private NumericUpDown numParam1;
    }
}