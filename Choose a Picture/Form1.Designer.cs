namespace Choose_a_Picture
{
    partial class choosePictureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quitButton = new System.Windows.Forms.Button();
            this.choiceComboBox = new System.Windows.Forms.ComboBox();
            this.choicePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.choicePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(664, 412);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(115, 50);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.closeApplication);
            // 
            // choiceComboBox
            // 
            this.choiceComboBox.FormattingEnabled = true;
            this.choiceComboBox.Items.AddRange(new object[] {
            "King Kong",
            "Alien",
            "Godzilla",
            "Pirate Spider",
            "Nessie"});
            this.choiceComboBox.Location = new System.Drawing.Point(87, 106);
            this.choiceComboBox.Name = "choiceComboBox";
            this.choiceComboBox.Size = new System.Drawing.Size(185, 24);
            this.choiceComboBox.TabIndex = 1;
            this.choiceComboBox.SelectedIndexChanged += new System.EventHandler(this.selectImage);
            // 
            // choicePictureBox
            // 
            this.choicePictureBox.Location = new System.Drawing.Point(558, 85);
            this.choicePictureBox.Name = "choicePictureBox";
            this.choicePictureBox.Size = new System.Drawing.Size(256, 267);
            this.choicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.choicePictureBox.TabIndex = 2;
            this.choicePictureBox.TabStop = false;
            // 
            // choosePictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 495);
            this.Controls.Add(this.choicePictureBox);
            this.Controls.Add(this.choiceComboBox);
            this.Controls.Add(this.quitButton);
            this.Name = "choosePictureForm";
            this.Text = "Choose A Picture";
            ((System.ComponentModel.ISupportInitialize)(this.choicePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.ComboBox choiceComboBox;
        private System.Windows.Forms.PictureBox choicePictureBox;
    }
}

