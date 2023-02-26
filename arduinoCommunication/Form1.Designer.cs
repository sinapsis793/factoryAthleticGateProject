
namespace factoryAthletic
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.readComPortCombo = new System.Windows.Forms.ComboBox();
            this.writeComboPort = new System.Windows.Forms.ComboBox();
            this.clupTextBox = new System.Windows.Forms.TextBox();
            this.debugCheckBox = new System.Windows.Forms.CheckBox();
            this.optionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read Com Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Write Com Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kulüp No:";
            // 
            // readComPortCombo
            // 
            this.readComPortCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readComPortCombo.FormattingEnabled = true;
            this.readComPortCombo.Location = new System.Drawing.Point(17, 74);
            this.readComPortCombo.Name = "readComPortCombo";
            this.readComPortCombo.Size = new System.Drawing.Size(163, 33);
            this.readComPortCombo.TabIndex = 3;
            // 
            // writeComboPort
            // 
            this.writeComboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.writeComboPort.FormattingEnabled = true;
            this.writeComboPort.Location = new System.Drawing.Point(17, 158);
            this.writeComboPort.Name = "writeComboPort";
            this.writeComboPort.Size = new System.Drawing.Size(163, 33);
            this.writeComboPort.TabIndex = 4;
            // 
            // clupTextBox
            // 
            this.clupTextBox.Location = new System.Drawing.Point(17, 254);
            this.clupTextBox.Name = "clupTextBox";
            this.clupTextBox.Size = new System.Drawing.Size(163, 31);
            this.clupTextBox.TabIndex = 5;
            // 
            // debugCheckBox
            // 
            this.debugCheckBox.AutoSize = true;
            this.debugCheckBox.Location = new System.Drawing.Point(17, 314);
            this.debugCheckBox.Name = "debugCheckBox";
            this.debugCheckBox.Size = new System.Drawing.Size(182, 29);
            this.debugCheckBox.TabIndex = 6;
            this.debugCheckBox.Text = "Hata Ayıklama";
            this.debugCheckBox.UseVisualStyleBackColor = true;
            this.debugCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(17, 400);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(158, 38);
            this.optionsButton.TabIndex = 7;
            this.optionsButton.Text = "Kaydet";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 788);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.debugCheckBox);
            this.Controls.Add(this.clupTextBox);
            this.Controls.Add(this.writeComboPort);
            this.Controls.Add(this.readComPortCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsForm";
            this.Text = "Ayarlar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox readComPortCombo;
        private System.Windows.Forms.ComboBox writeComboPort;
        private System.Windows.Forms.TextBox clupTextBox;
        private System.Windows.Forms.CheckBox debugCheckBox;
        private System.Windows.Forms.Button optionsButton;
    }
}