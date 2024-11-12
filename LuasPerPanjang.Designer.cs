namespace calc_app
{
    partial class LuasPerPanjang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            lblResult = new Label();
            groupBox1 = new GroupBox();
            numParam2 = new NumericUpDown();
            label1 = new Label();
            numParam1 = new NumericUpDown();
            label2 = new Label();
            btnPlus = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numParam2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numParam1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lblResult);
            groupBox2.Location = new Point(3, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(441, 104);
            groupBox2.TabIndex = 17;
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
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(numParam2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numParam1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnPlus);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 120);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parameters";
            // 
            // numParam2
            // 
            numParam2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numParam2.Location = new Point(193, 51);
            numParam2.Name = "numParam2";
            numParam2.Size = new Size(242, 23);
            numParam2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 17;
            label1.Text = "Lebar";
            // 
            // numParam1
            // 
            numParam1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numParam1.Location = new Point(193, 22);
            numParam1.Name = "numParam1";
            numParam1.Size = new Size(242, 23);
            numParam1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 8;
            label2.Text = "Panjang";
            // 
            // btnPlus
            // 
            btnPlus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPlus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(324, 88);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(111, 26);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "Calculate";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // LuasPerPanjang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LuasPerPanjang";
            Size = new Size(447, 245);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numParam2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numParam1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label lblResult;
        private GroupBox groupBox1;
        private NumericUpDown numParam1;
        private Label label2;
        private Button btnPlus;
        private NumericUpDown numParam2;
        private Label label1;
    }
}
