namespace OpenCVTextDisplayer
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
            this.image = new System.Windows.Forms.PictureBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.textInput = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.discoMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(58, 26);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(687, 226);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(310, 332);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(185, 79);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate Image";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(210, 282);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(407, 23);
            this.textInput.TabIndex = 2;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(173, 285);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(31, 15);
            this.inputLabel.TabIndex = 3;
            this.inputLabel.Text = "Text:";
            // 
            // discoMode
            // 
            this.discoMode.AutoSize = true;
            this.discoMode.Checked = true;
            this.discoMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.discoMode.Location = new System.Drawing.Point(577, 363);
            this.discoMode.Name = "discoMode";
            this.discoMode.Size = new System.Drawing.Size(94, 19);
            this.discoMode.TabIndex = 4;
            this.discoMode.Text = "Disco Mode?";
            this.discoMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.discoMode);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox image;
        private Button generateButton;
        private TextBox textInput;
        private Label inputLabel;
        private CheckBox discoMode;
    }
}