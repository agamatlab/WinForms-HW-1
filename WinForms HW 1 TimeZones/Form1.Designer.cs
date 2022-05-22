namespace WinForms_HW_1_TimeZones
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
            this.lbl_Time = new System.Windows.Forms.Label();
            this.btn_Baku = new System.Windows.Forms.Button();
            this.btn_London = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Time.Location = new System.Drawing.Point(293, 54);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(135, 54);
            this.lbl_Time.TabIndex = 0;
            this.lbl_Time.Text = "-------";
            // 
            // btn_Baku
            // 
            this.btn_Baku.Font = new System.Drawing.Font("Source Sans Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Baku.Location = new System.Drawing.Point(169, 238);
            this.btn_Baku.Name = "btn_Baku";
            this.btn_Baku.Size = new System.Drawing.Size(116, 47);
            this.btn_Baku.TabIndex = 1;
            this.btn_Baku.Text = "Baku";
            this.btn_Baku.UseVisualStyleBackColor = true;
            this.btn_Baku.Click += new System.EventHandler(this.btn_Baku_Click);
            // 
            // btn_London
            // 
            this.btn_London.Font = new System.Drawing.Font("Source Sans Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_London.Location = new System.Drawing.Point(509, 238);
            this.btn_London.Name = "btn_London";
            this.btn_London.Size = new System.Drawing.Size(116, 47);
            this.btn_London.TabIndex = 2;
            this.btn_London.Text = "London";
            this.btn_London.UseVisualStyleBackColor = true;
            this.btn_London.Click += new System.EventHandler(this.btn_London_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(794, 449);
            this.Controls.Add(this.btn_London);
            this.Controls.Add(this.btn_Baku);
            this.Controls.Add(this.lbl_Time);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Time;
        private Button btn_Baku;
        private Button btn_London;
    }
}