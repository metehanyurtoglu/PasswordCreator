namespace PasswordCreator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtSavePassword = new System.Windows.Forms.TextBox();
            this.txtSaveInstruction = new System.Windows.Forms.TextBox();
            this.btnSaveSave = new System.Windows.Forms.Button();
            this.txtSaveDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSavePassword
            // 
            resources.ApplyResources(this.txtSavePassword, "txtSavePassword");
            this.txtSavePassword.Name = "txtSavePassword";
            this.txtSavePassword.ReadOnly = true;
            // 
            // txtSaveInstruction
            // 
            resources.ApplyResources(this.txtSaveInstruction, "txtSaveInstruction");
            this.txtSaveInstruction.Name = "txtSaveInstruction";
            // 
            // btnSaveSave
            // 
            this.btnSaveSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnSaveSave, "btnSaveSave");
            this.btnSaveSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveSave.Name = "btnSaveSave";
            this.btnSaveSave.UseVisualStyleBackColor = false;
            this.btnSaveSave.Click += new System.EventHandler(this.btnSaveSave_Click);
            // 
            // txtSaveDate
            // 
            resources.ApplyResources(this.txtSaveDate, "txtSaveDate");
            this.txtSaveDate.Name = "txtSaveDate";
            this.txtSaveDate.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaveDate);
            this.Controls.Add(this.btnSaveSave);
            this.Controls.Add(this.txtSaveInstruction);
            this.Controls.Add(this.txtSavePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSavePassword;
        private System.Windows.Forms.TextBox txtSaveInstruction;
        private System.Windows.Forms.Button btnSaveSave;
        private System.Windows.Forms.TextBox txtSaveDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}