namespace VerificadiRipasso
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
            button1 = new Button();
            listBoxParole = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(77, 56);
            button1.Name = "button1";
            button1.Size = new Size(117, 64);
            button1.TabIndex = 1;
            button1.Text = "Cifrare";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxParole
            // 
            listBoxParole.FormattingEnabled = true;
            listBoxParole.ItemHeight = 15;
            listBoxParole.Location = new Point(237, 56);
            listBoxParole.Name = "listBoxParole";
            listBoxParole.Size = new Size(120, 94);
            listBoxParole.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxParole);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ListBox listBoxParole;
    }
}
