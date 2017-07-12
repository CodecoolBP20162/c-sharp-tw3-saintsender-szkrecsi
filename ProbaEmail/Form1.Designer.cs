namespace EmailApp
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
            this.btnNewMessageForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewMessageForm
            // 
            this.btnNewMessageForm.BackColor = System.Drawing.Color.Tomato;
            this.btnNewMessageForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewMessageForm.ForeColor = System.Drawing.Color.Bisque;
            this.btnNewMessageForm.Location = new System.Drawing.Point(12, 12);
            this.btnNewMessageForm.Name = "btnNewMessageForm";
            this.btnNewMessageForm.Size = new System.Drawing.Size(80, 33);
            this.btnNewMessageForm.TabIndex = 0;
            this.btnNewMessageForm.Text = "Compose";
            this.btnNewMessageForm.UseVisualStyleBackColor = false;
            this.btnNewMessageForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 448);
            this.Controls.Add(this.btnNewMessageForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewMessageForm;
    }
}

