namespace AngryBirdsWinFormsApp
{
    partial class MainForm
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
            returnButton = new Button();
            caughtPigCount = new Label();
            SuspendLayout();
            // 
            // returnButton
            // 
            returnButton.Location = new Point(496, 12);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(75, 44);
            returnButton.TabIndex = 0;
            returnButton.Text = "Вернуть птичку";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += ReturnBirdButton_Click;
            // 
            // caughtPigCount
            // 
            caughtPigCount.AutoSize = true;
            caughtPigCount.Location = new Point(12, 9);
            caughtPigCount.Name = "caughtPigCount";
            caughtPigCount.Size = new Size(13, 15);
            caughtPigCount.TabIndex = 1;
            caughtPigCount.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 450);
            Controls.Add(caughtPigCount);
            Controls.Add(returnButton);
            Name = "MainForm";
            Text = "Form1";
            Shown += MainForm_Shown;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnButton;
        private Label caughtPigCount;
    }
}
