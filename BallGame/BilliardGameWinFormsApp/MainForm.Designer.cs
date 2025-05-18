namespace BilliardGameWinFormsApp
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
            leftRedLabel = new Label();
            downRedLabel = new Label();
            rightRedLabel = new Label();
            topRedLabel = new Label();
            leftBlueLabel = new Label();
            downBlueLabel = new Label();
            rightBlueLabel = new Label();
            topBlueLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // leftRedLabel
            // 
            leftRedLabel.Anchor = AnchorStyles.None;
            leftRedLabel.AutoSize = true;
            leftRedLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            leftRedLabel.ForeColor = Color.Red;
            leftRedLabel.Location = new Point(12, 183);
            leftRedLabel.Name = "leftRedLabel";
            leftRedLabel.Size = new Size(20, 22);
            leftRedLabel.TabIndex = 0;
            leftRedLabel.Text = "0";
            leftRedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // downRedLabel
            // 
            downRedLabel.Anchor = AnchorStyles.None;
            downRedLabel.AutoSize = true;
            downRedLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            downRedLabel.ForeColor = Color.Red;
            downRedLabel.Location = new Point(336, 419);
            downRedLabel.Name = "downRedLabel";
            downRedLabel.Size = new Size(20, 22);
            downRedLabel.TabIndex = 1;
            downRedLabel.Text = "0";
            downRedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rightRedLabel
            // 
            rightRedLabel.Anchor = AnchorStyles.None;
            rightRedLabel.AutoSize = true;
            rightRedLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rightRedLabel.ForeColor = Color.Red;
            rightRedLabel.Location = new Point(696, 196);
            rightRedLabel.Name = "rightRedLabel";
            rightRedLabel.Size = new Size(20, 22);
            rightRedLabel.TabIndex = 2;
            rightRedLabel.Text = "0";
            rightRedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // topRedLabel
            // 
            topRedLabel.Anchor = AnchorStyles.None;
            topRedLabel.AutoSize = true;
            topRedLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            topRedLabel.ForeColor = Color.Red;
            topRedLabel.Location = new Point(336, 9);
            topRedLabel.Name = "topRedLabel";
            topRedLabel.Size = new Size(20, 22);
            topRedLabel.TabIndex = 3;
            topRedLabel.Text = "0";
            topRedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // leftBlueLabel
            // 
            leftBlueLabel.Anchor = AnchorStyles.None;
            leftBlueLabel.AutoSize = true;
            leftBlueLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            leftBlueLabel.ForeColor = Color.Blue;
            leftBlueLabel.Location = new Point(12, 245);
            leftBlueLabel.Name = "leftBlueLabel";
            leftBlueLabel.Size = new Size(20, 22);
            leftBlueLabel.TabIndex = 4;
            leftBlueLabel.Text = "0";
            leftBlueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // downBlueLabel
            // 
            downBlueLabel.Anchor = AnchorStyles.None;
            downBlueLabel.AutoSize = true;
            downBlueLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            downBlueLabel.ForeColor = Color.Blue;
            downBlueLabel.Location = new Point(392, 419);
            downBlueLabel.Name = "downBlueLabel";
            downBlueLabel.Size = new Size(20, 22);
            downBlueLabel.TabIndex = 5;
            downBlueLabel.Text = "0";
            downBlueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rightBlueLabel
            // 
            rightBlueLabel.Anchor = AnchorStyles.None;
            rightBlueLabel.AutoSize = true;
            rightBlueLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rightBlueLabel.ForeColor = Color.Blue;
            rightBlueLabel.Location = new Point(696, 245);
            rightBlueLabel.Name = "rightBlueLabel";
            rightBlueLabel.Size = new Size(20, 22);
            rightBlueLabel.TabIndex = 6;
            rightBlueLabel.Text = "0";
            rightBlueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // topBlueLabel
            // 
            topBlueLabel.Anchor = AnchorStyles.None;
            topBlueLabel.AutoSize = true;
            topBlueLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            topBlueLabel.ForeColor = Color.Blue;
            topBlueLabel.Location = new Point(392, 9);
            topBlueLabel.Name = "topBlueLabel";
            topBlueLabel.Size = new Size(20, 22);
            topBlueLabel.TabIndex = 7;
            topBlueLabel.Text = "0";
            topBlueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += Timer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 450);
            Controls.Add(topBlueLabel);
            Controls.Add(rightBlueLabel);
            Controls.Add(downBlueLabel);
            Controls.Add(leftBlueLabel);
            Controls.Add(topRedLabel);
            Controls.Add(rightRedLabel);
            Controls.Add(downRedLabel);
            Controls.Add(leftRedLabel);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftRedLabel;
        private Label downRedLabel;
        private Label rightRedLabel;
        private Label topRedLabel;
        private Label leftBlueLabel;
        private Label downBlueLabel;
        private Label rightBlueLabel;
        private Label topBlueLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
