namespace PasswordCreator
{
    partial class Form3
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
            this.dataGridViewPassword = new System.Windows.Forms.DataGridView();
            this.btnSaveSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPassword
            // 
            this.dataGridViewPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassword.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewPassword.Name = "dataGridViewPassword";
            this.dataGridViewPassword.Size = new System.Drawing.Size(346, 310);
            this.dataGridViewPassword.TabIndex = 0;
            // 
            // btnSaveSave
            // 
            this.btnSaveSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSaveSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveSave.Location = new System.Drawing.Point(236, 329);
            this.btnSaveSave.Name = "btnSaveSave";
            this.btnSaveSave.Size = new System.Drawing.Size(123, 34);
            this.btnSaveSave.TabIndex = 3;
            this.btnSaveSave.Text = "Şifreyi Sil";
            this.btnSaveSave.UseVisualStyleBackColor = false;
            this.btnSaveSave.Click += new System.EventHandler(this.btnSaveSave_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 374);
            this.Controls.Add(this.btnSaveSave);
            this.Controls.Add(this.dataGridViewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıtlı Şifreler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewPassword;
        private System.Windows.Forms.Button btnSaveSave;
    }
}