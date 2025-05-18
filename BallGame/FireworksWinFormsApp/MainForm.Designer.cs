namespace FireworksWinFormsApp
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
            launchButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // launchButton
            // 
            launchButton.Location = new Point(679, 22);
            launchButton.Name = "launchButton";
            launchButton.Size = new Size(109, 44);
            launchButton.TabIndex = 0;
            launchButton.Text = "Шарик вылетает снизу";
            launchButton.UseVisualStyleBackColor = true;
            launchButton.Click += LaunchButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(launchButton);
            Name = "MainForm";
            Text = "Салют";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button launchButton;
        private System.Windows.Forms.Timer timer;
    }
}
