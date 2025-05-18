namespace CatchBall2WinFormsApp
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
            components = new System.ComponentModel.Container();
            clearBallsButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            generateBallsButton = new Button();
            amountBallsLabel = new Label();
            SuspendLayout();
            // 
            // clearBallsButton
            // 
            clearBallsButton.Location = new Point(416, 64);
            clearBallsButton.Name = "clearBallsButton";
            clearBallsButton.Size = new Size(146, 46);
            clearBallsButton.TabIndex = 2;
            clearBallsButton.Text = "Очистить";
            clearBallsButton.UseVisualStyleBackColor = true;
            clearBallsButton.Click += ClearBallsButton_Click;
            // 
            // timer
            // 
            timer.Interval = 10;
            // 
            // generateBallsButton
            // 
            generateBallsButton.Location = new Point(416, 12);
            generateBallsButton.Name = "generateBallsButton";
            generateBallsButton.Size = new Size(146, 46);
            generateBallsButton.TabIndex = 3;
            generateBallsButton.Text = "Сгенерировать рандомный шарик";
            generateBallsButton.UseVisualStyleBackColor = true;
            generateBallsButton.Click += GenerateBallsButton_Click;
            // 
            // amountBallsLabel
            // 
            amountBallsLabel.AutoSize = true;
            amountBallsLabel.Location = new Point(362, 12);
            amountBallsLabel.Name = "amountBallsLabel";
            amountBallsLabel.Size = new Size(13, 15);
            amountBallsLabel.TabIndex = 4;
            amountBallsLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(584, 561);
            Controls.Add(amountBallsLabel);
            Controls.Add(generateBallsButton);
            Controls.Add(clearBallsButton);
            Name = "MainForm";
            Text = "Form1";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button clearBallsButton;
        private Button generateBallsButton;
        private System.Windows.Forms.Timer timer;
        private Label amountBallsLabel;
    }
}