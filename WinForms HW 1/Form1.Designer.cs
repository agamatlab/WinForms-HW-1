namespace WinForms_HW_1
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
            this.lbl_Moving = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Moving
            // 
            this.lbl_Moving.AutoSize = true;
            this.lbl_Moving.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Moving.Location = new System.Drawing.Point(249, 173);
            this.lbl_Moving.Name = "lbl_Moving";
            this.lbl_Moving.Size = new System.Drawing.Size(195, 41);
            this.lbl_Moving.TabIndex = 0;
            this.lbl_Moving.Text = "Moving Text";
            this.lbl_Moving.MouseHover += new System.EventHandler(this.lbl_Moving_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 405);
            this.Controls.Add(this.lbl_Moving);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Moving;
    }
}