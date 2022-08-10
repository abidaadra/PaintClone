using System;

namespace Painter
{
    partial class PainterForm
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
            this.PainterPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.imageComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainterPanel
            // 
            this.PainterPanel.BackColor = System.Drawing.SystemColors.Window;
            this.PainterPanel.Location = new System.Drawing.Point(94, 40);
            this.PainterPanel.Name = "PainterPanel";
            this.PainterPanel.Size = new System.Drawing.Size(252, 205);
            this.PainterPanel.TabIndex = 1;
            this.PainterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PainterPanel_Paint);
            this.PainterPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PainterPanel_MouseDown);
            this.PainterPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PainterPanel_MouseMove);
            this.PainterPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PainterPanel_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blackRadioButton);
            this.groupBox1.Controls.Add(this.greenRadioButton);
            this.groupBox1.Controls.Add(this.blueRadioButton);
            this.groupBox1.Controls.Add(this.redRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(7, 92);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(49, 17);
            this.blackRadioButton.TabIndex = 3;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(7, 68);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.Location = new System.Drawing.Point(7, 44);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(45, 17);
            this.blueRadioButton.TabIndex = 1;
            this.blueRadioButton.TabStop = true;
            this.blueRadioButton.Text = "Blue";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            this.blueRadioButton.CheckedChanged += new System.EventHandler(this.blueRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(7, 20);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(44, 17);
            this.redRadioButton.TabIndex = 0;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.largeRadioButton);
            this.groupBox2.Controls.Add(this.mediumRadioButton);
            this.groupBox2.Controls.Add(this.smallRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(7, 68);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.largeRadioButton.TabIndex = 2;
            this.largeRadioButton.TabStop = true;
            this.largeRadioButton.Text = "Large";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            this.largeRadioButton.CheckedChanged += new System.EventHandler(this.largeRadioButton_CheckedChanged);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(7, 44);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(61, 17);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.mediumRadioButton_CheckedChanged);
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(7, 20);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(49, 17);
            this.smallRadioButton.TabIndex = 0;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            this.smallRadioButton.CheckedChanged += new System.EventHandler(this.smallRadioButton_CheckedChanged);
            // 
            // imageComboBox
            // 
            this.imageComboBox.FormattingEnabled = true;
            this.imageComboBox.Items.AddRange(new object[] {
            "Filled Circle",
            "Filled Square",
            "Filled Ellipse",
            "Filled Pie"});
            this.imageComboBox.Location = new System.Drawing.Point(104, 13);
            this.imageComboBox.Name = "imageComboBox";
            this.imageComboBox.Size = new System.Drawing.Size(121, 21);
            this.imageComboBox.TabIndex = 4;
            this.imageComboBox.Text = "Types of fill";
            // 
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 261);
            this.Controls.Add(this.imageComboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PainterPanel);
            this.Name = "PainterForm";
            this.Text = "Painter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainterPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton blueRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.ComboBox imageComboBox;
    }
}