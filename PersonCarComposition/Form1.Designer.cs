namespace PersonCarComposition
{
    partial class Form1
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
            btnBadDesign = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnBadDesign
            // 
            btnBadDesign.ForeColor = Color.Firebrick;
            btnBadDesign.Location = new Point(22, 40);
            btnBadDesign.Name = "btnBadDesign";
            btnBadDesign.Size = new Size(104, 52);
            btnBadDesign.TabIndex = 0;
            btnBadDesign.Text = "BadDesign";
            btnBadDesign.Click += btnBadDesign_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.LightSeaGreen;
            button1.Location = new Point(235, 40);
            button1.Name = "button1";
            button1.Size = new Size(104, 52);
            button1.TabIndex = 1;
            button1.Text = "GodDesign";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(123, 155);
            button2.Name = "button2";
            button2.Size = new Size(104, 52);
            button2.TabIndex = 2;
            button2.Text = "PlateNumber";
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 283);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnBadDesign);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBadDesign;
        private Button button1;
        private Button button2;
    }
}
