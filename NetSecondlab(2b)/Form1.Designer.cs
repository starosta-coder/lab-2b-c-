namespace Laba4_13var
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
            this.textboxFirstSide = new System.Windows.Forms.TextBox();
            this.textBoxSecondSide = new System.Windows.Forms.TextBox();
            this.textBoxThirdSide = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textboxFirstSide
            // 
            this.textboxFirstSide.Location = new System.Drawing.Point(12, 12);
            this.textboxFirstSide.Name = "textboxFirstSide";
            this.textboxFirstSide.Size = new System.Drawing.Size(100, 22);
            this.textboxFirstSide.TabIndex = 0;
            this.textboxFirstSide.Text = "FirstSide";
            // 
            // textBoxSecondSide
            // 
            this.textBoxSecondSide.Location = new System.Drawing.Point(12, 40);
            this.textBoxSecondSide.Name = "textBoxSecondSide";
            this.textBoxSecondSide.Size = new System.Drawing.Size(100, 22);
            this.textBoxSecondSide.TabIndex = 0;
            this.textBoxSecondSide.Text = "SecondSide";
            // 
            // textBoxThirdSide
            // 
            this.textBoxThirdSide.Location = new System.Drawing.Point(12, 68);
            this.textBoxThirdSide.Name = "textBoxThirdSide";
            this.textBoxThirdSide.Size = new System.Drawing.Size(100, 22);
            this.textBoxThirdSide.TabIndex = 0;
            this.textBoxThirdSide.Text = "ThirdSide";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(118, 12);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(322, 78);
            this.textBoxResult.TabIndex = 0;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(12, 97);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 1;
            this.buttonResult.Text = "Result";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(94, 96);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 2;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(176, 96);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 130);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxThirdSide);
            this.Controls.Add(this.textBoxSecondSide);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textboxFirstSide);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxFirstSide;
        private System.Windows.Forms.TextBox textBoxSecondSide;
        private System.Windows.Forms.TextBox textBoxThirdSide;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

