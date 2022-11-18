
namespace Painter
{
    partial class PainterForm
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
            this.paintPanel = new System.Windows.Forms.Panel();
            this.colorBox = new System.Windows.Forms.GroupBox();
            this.blackButton = new System.Windows.Forms.RadioButton();
            this.greenButton = new System.Windows.Forms.RadioButton();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.sizeBox = new System.Windows.Forms.GroupBox();
            this.largeButton = new System.Windows.Forms.RadioButton();
            this.mediumButton = new System.Windows.Forms.RadioButton();
            this.smallButton = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.colorBox.SuspendLayout();
            this.sizeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // paintPanel
            // 
            this.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintPanel.Location = new System.Drawing.Point(255, 12);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(533, 426);
            this.paintPanel.TabIndex = 0;
            this.paintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseDown);
            this.paintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseMove);
            this.paintPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseUp);
            // 
            // colorBox
            // 
            this.colorBox.Controls.Add(this.blackButton);
            this.colorBox.Controls.Add(this.greenButton);
            this.colorBox.Controls.Add(this.blueButton);
            this.colorBox.Controls.Add(this.redButton);
            this.colorBox.Location = new System.Drawing.Point(12, 12);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(237, 210);
            this.colorBox.TabIndex = 1;
            this.colorBox.TabStop = false;
            this.colorBox.Text = "Color";
            // 
            // blackButton
            // 
            this.blackButton.AutoSize = true;
            this.blackButton.Location = new System.Drawing.Point(78, 168);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(53, 19);
            this.blackButton.TabIndex = 3;
            this.blackButton.TabStop = true;
            this.blackButton.Text = "Black";
            this.blackButton.UseVisualStyleBackColor = true;
            this.blackButton.CheckedChanged += new System.EventHandler(this.PainterForm_ChangeColor);
            // 
            // greenButton
            // 
            this.greenButton.AutoSize = true;
            this.greenButton.Location = new System.Drawing.Point(78, 125);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(56, 19);
            this.greenButton.TabIndex = 2;
            this.greenButton.TabStop = true;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.CheckedChanged += new System.EventHandler(this.PainterForm_ChangeColor);
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Location = new System.Drawing.Point(78, 84);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(48, 19);
            this.blueButton.TabIndex = 1;
            this.blueButton.TabStop = true;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.CheckedChanged += new System.EventHandler(this.PainterForm_ChangeColor);
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(78, 40);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(45, 19);
            this.redButton.TabIndex = 0;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.CheckedChanged += new System.EventHandler(this.PainterForm_ChangeColor);
            // 
            // sizeBox
            // 
            this.sizeBox.Controls.Add(this.largeButton);
            this.sizeBox.Controls.Add(this.mediumButton);
            this.sizeBox.Controls.Add(this.smallButton);
            this.sizeBox.Location = new System.Drawing.Point(12, 238);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(237, 147);
            this.sizeBox.TabIndex = 2;
            this.sizeBox.TabStop = false;
            this.sizeBox.Text = "Size";
            // 
            // largeButton
            // 
            this.largeButton.AutoSize = true;
            this.largeButton.Location = new System.Drawing.Point(78, 95);
            this.largeButton.Name = "largeButton";
            this.largeButton.Size = new System.Drawing.Size(54, 19);
            this.largeButton.TabIndex = 2;
            this.largeButton.TabStop = true;
            this.largeButton.Text = "Large";
            this.largeButton.UseVisualStyleBackColor = true;
            this.largeButton.CheckedChanged += new System.EventHandler(this.PainterForm_ChangeSize);
            // 
            // mediumButton
            // 
            this.mediumButton.AutoSize = true;
            this.mediumButton.Location = new System.Drawing.Point(78, 59);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(70, 19);
            this.mediumButton.TabIndex = 1;
            this.mediumButton.TabStop = true;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.CheckedChanged += new System.EventHandler(this.PainterForm_ChangeSize);
            // 
            // smallButton
            // 
            this.smallButton.AutoSize = true;
            this.smallButton.Location = new System.Drawing.Point(78, 22);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(54, 19);
            this.smallButton.TabIndex = 0;
            this.smallButton.TabStop = true;
            this.smallButton.Text = "Small";
            this.smallButton.UseVisualStyleBackColor = true;
            this.smallButton.CheckedChanged += new System.EventHandler(this.PainterForm_ChangeSize);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(85, 401);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.paintPanel);
            this.Name = "PainterForm";
            this.Text = "Painter";
            this.colorBox.ResumeLayout(false);
            this.colorBox.PerformLayout();
            this.sizeBox.ResumeLayout(false);
            this.sizeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paintPanel;
        private System.Windows.Forms.GroupBox colorBox;
        private System.Windows.Forms.GroupBox sizeBox;
        private System.Windows.Forms.RadioButton blackButton;
        private System.Windows.Forms.RadioButton greenButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton largeButton;
        private System.Windows.Forms.RadioButton mediumButton;
        private System.Windows.Forms.RadioButton smallButton;
        private System.Windows.Forms.Button clearButton;
    }
}

