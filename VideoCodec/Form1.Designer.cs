
namespace VideoCodec
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.btnFolderSave = new System.Windows.Forms.Button();
            this.txtbxFulNameFile = new System.Windows.Forms.TextBox();
            this.txtbxFolderNameOut = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(215, 88);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(101, 23);
            this.btnFileOpen.TabIndex = 0;
            this.btnFileOpen.Text = "Открыть файл";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // btnFolderSave
            // 
            this.btnFolderSave.Location = new System.Drawing.Point(215, 117);
            this.btnFolderSave.Name = "btnFolderSave";
            this.btnFolderSave.Size = new System.Drawing.Size(75, 23);
            this.btnFolderSave.TabIndex = 0;
            this.btnFolderSave.Text = "Сохранить";
            this.btnFolderSave.UseVisualStyleBackColor = true;
            this.btnFolderSave.Click += new System.EventHandler(this.btnFolderSave_Click);
            // 
            // txtbxFulNameFile
            // 
            this.txtbxFulNameFile.Location = new System.Drawing.Point(13, 90);
            this.txtbxFulNameFile.Name = "txtbxFulNameFile";
            this.txtbxFulNameFile.Size = new System.Drawing.Size(196, 20);
            this.txtbxFulNameFile.TabIndex = 1;
            // 
            // txtbxFolderNameOut
            // 
            this.txtbxFolderNameOut.Location = new System.Drawing.Point(12, 116);
            this.txtbxFolderNameOut.Name = "txtbxFolderNameOut";
            this.txtbxFolderNameOut.Size = new System.Drawing.Size(196, 20);
            this.txtbxFolderNameOut.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 242);
            this.Controls.Add(this.txtbxFolderNameOut);
            this.Controls.Add(this.txtbxFulNameFile);
            this.Controls.Add(this.btnFolderSave);
            this.Controls.Add(this.btnFileOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.Button btnFolderSave;
        private System.Windows.Forms.TextBox txtbxFulNameFile;
        private System.Windows.Forms.TextBox txtbxFolderNameOut;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

