namespace WinFormsApp22082025
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
            Labal_Contador = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Labal_Contador
            // 
            Labal_Contador.AutoSize = true;
            Labal_Contador.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Labal_Contador.Location = new Point(225, 68);
            Labal_Contador.Name = "Labal_Contador";
            Labal_Contador.Size = new Size(19, 23);
            Labal_Contador.TabIndex = 0;
            Labal_Contador.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(158, 94);
            button1.Name = "button1";
            button1.Size = new Size(154, 58);
            button1.TabIndex = 1;
            button1.Text = "Clique Aqui!!!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(476, 211);
            Controls.Add(button1);
            Controls.Add(Labal_Contador);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label Labal_Contador;
        //private Button button1;
    }
}
