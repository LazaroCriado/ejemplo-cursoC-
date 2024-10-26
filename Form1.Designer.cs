namespace ejemplo1
{

    partial class Form1
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
            this.opTernarioCheckBox = new System.Windows.Forms.CheckBox();
            this.opTernarioLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opTernarioCheckBox
            // 
            this.opTernarioCheckBox.AutoSize = true;
            this.opTernarioCheckBox.Location = new System.Drawing.Point(298, 185);
            this.opTernarioCheckBox.Name = "opTernarioCheckBox";
            this.opTernarioCheckBox.Size = new System.Drawing.Size(164, 24);
            this.opTernarioCheckBox.TabIndex = 1;
            this.opTernarioCheckBox.Text = "Operador Ternario";
            this.opTernarioCheckBox.UseVisualStyleBackColor = true;
            this.opTernarioCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // opTernarioLabel
            // 
            this.opTernarioLabel.AutoSize = true;
            this.opTernarioLabel.Location = new System.Drawing.Point(347, 244);
            this.opTernarioLabel.Name = "opTernarioLabel";
            this.opTernarioLabel.Size = new System.Drawing.Size(0, 20);
            this.opTernarioLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opTernarioLabel);
            this.Controls.Add(this.opTernarioCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox opTernarioCheckBox;
        private System.Windows.Forms.Label opTernarioLabel;
    }
}

