namespace BallGamesWinFormsApp
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
            stopBallsButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            generateBallsButton = new Button();
            SuspendLayout();
            // 
            // stopBallsButton
            // 
            stopBallsButton.Location = new Point(416, 64);
            stopBallsButton.Name = "stopBallsButton";
            stopBallsButton.Size = new Size(146, 46);
            stopBallsButton.TabIndex = 2;
            stopBallsButton.Text = "Стоп (подсчёт пойманных)";
            stopBallsButton.UseVisualStyleBackColor = true;
            stopBallsButton.Click += StopBallsButton_Click;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(584, 561);
            Controls.Add(generateBallsButton);
            Controls.Add(stopBallsButton);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button stopBallsButton;
        private Button generateBallsButton;
        private System.Windows.Forms.Timer timer;
    }
}
