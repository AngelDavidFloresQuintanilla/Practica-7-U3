namespace Practica_6_U3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            C1 = new TextBox();
            C2 = new TextBox();
            C3 = new TextBox();
            C4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(350, 45);
            label1.TabIndex = 0;
            label1.Text = "Boleta de calificaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 90);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 1;
            label2.Text = "Calificacion 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 155);
            label3.Name = "label3";
            label3.Size = new Size(155, 32);
            label3.TabIndex = 2;
            label3.Text = "Calificacion 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 215);
            label4.Name = "label4";
            label4.Size = new Size(155, 32);
            label4.TabIndex = 3;
            label4.Text = "Calificacion 3";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 278);
            label5.Name = "label5";
            label5.Size = new Size(155, 32);
            label5.TabIndex = 4;
            label5.Text = "Calificacion 4";
            // 
            // C1
            // 
            C1.Location = new Point(260, 92);
            C1.Name = "C1";
            C1.Size = new Size(200, 39);
            C1.TabIndex = 5;
            // 
            // C2
            // 
            C2.Location = new Point(262, 159);
            C2.Name = "C2";
            C2.Size = new Size(200, 39);
            C2.TabIndex = 6;
            // 
            // C3
            // 
            C3.Location = new Point(261, 216);
            C3.Name = "C3";
            C3.Size = new Size(200, 39);
            C3.TabIndex = 7;
            // 
            // C4
            // 
            C4.Location = new Point(262, 279);
            C4.Name = "C4";
            C4.Size = new Size(200, 39);
            C4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(221, 408);
            button1.Name = "button1";
            button1.Size = new Size(350, 77);
            button1.TabIndex = 9;
            button1.Text = "Decision";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(button1);
            Controls.Add(C4);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox C1;
        private TextBox C2;
        private TextBox C3;
        private TextBox C4;
        private Button button1;
    }
}