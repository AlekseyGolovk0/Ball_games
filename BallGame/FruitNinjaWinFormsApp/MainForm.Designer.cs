namespace FruitNinjaWinFormsApp
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
            _timer = new System.Windows.Forms.Timer(components);
            amountBallsLabel = new Label();
            restartButton = new Button();
            SuspendLayout();
            // 
            // timer
            // 
            _timer.Tick += Timer_Tick;
            // 
            // amountBallsLabel
            // 
            amountBallsLabel.AutoSize = true;
            amountBallsLabel.Location = new Point(33, 33);
            amountBallsLabel.Name = "amountBallsLabel";
            amountBallsLabel.Size = new Size(13, 15);
            amountBallsLabel.TabIndex = 0;
            amountBallsLabel.Text = "0";
            // 
            // restartButton
            // 
            restartButton.Location = new Point(713, 12);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(75, 23);
            restartButton.TabIndex = 1;
            restartButton.Text = "Рестарт";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Click += RestartButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(restartButton);
            Controls.Add(amountBallsLabel);
            Name = "MainForm";
            Text = "Fruit Ninja";
            MouseMove += Form_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer _timer;
        private Label amountBallsLabel;
        private Button restartButton;
    }
}
