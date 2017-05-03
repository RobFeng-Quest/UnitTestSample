namespace FileSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtTextToFind = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text to find:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(107, 26);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(150, 20);
            this.txtPath.TabIndex = 3;
            // 
            // txtTextToFind
            // 
            this.txtTextToFind.Location = new System.Drawing.Point(107, 67);
            this.txtTextToFind.Name = "txtTextToFind";
            this.txtTextToFind.Size = new System.Drawing.Size(150, 20);
            this.txtTextToFind.TabIndex = 4;
            this.txtTextToFind.Text = "Hello";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(263, 24);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(31, 23);
            this.btnBrowser.TabIndex = 6;
            this.btnBrowser.Text = "...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(107, 102);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(29, 150);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 339);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtTextToFind);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Case 05 in Winform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtTextToFind;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblResult;
    }
}

