namespace calc_app
{
    partial class CalcLuas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcLuas));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(351, 38);
            label1.TabIndex = 15;
            label1.Text = "Maybe Working Calculator";
            // 
            // button1
            // 
            button1.Location = new Point(12, 50);
            button1.Name = "button1";
            button1.Size = new Size(175, 40);
            button1.TabIndex = 21;
            button1.Text = "Luas Persegi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 96);
            button2.Name = "button2";
            button2.Size = new Size(175, 40);
            button2.TabIndex = 22;
            button2.Text = "Luas Persegi Panjang";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Location = new Point(193, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 247);
            panel1.TabIndex = 23;
            // 
            // CalcLuas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 302);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalcLuas";
            Text = "CalcLuas";
            FormClosing += CalcLuas_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}