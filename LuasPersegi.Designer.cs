namespace calc_app
{
    partial class LuasPersegi
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
            numParam1 = new NumericUpDown();
            label2 = new Label();
            btnPlus = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numParam1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lblResult);
            groupBox2.Location = new Point(3, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 147);
            groupBox2.TabIndex = 14;
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
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(numParam1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnPlus);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 88);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parameters";
            // 
            // numParam1
            // 
            numParam1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numParam1.Location = new Point(140, 22);
            numParam1.Name = "numParam1";
            numParam1.Size = new Size(242, 23);
            numParam1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 8;
            label2.Text = "Sisi";
            // 
            // btnPlus
            // 
            btnPlus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPlus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(271, 51);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(111, 26);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "Calculate";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // LuasPersegi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LuasPersegi";
            Size = new Size(394, 256);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}
