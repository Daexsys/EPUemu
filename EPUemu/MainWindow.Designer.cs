namespace EPUemu
{
    partial class MainWindow
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
            this.exitButton = new System.Windows.Forms.Button();
            this.button_dataCacheViewer = new System.Windows.Forms.Button();
            this.button_codeCacheViewer = new System.Windows.Forms.Button();
            this.button_stackCacheViewer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(13, 13);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button_dataCacheViewer
            // 
            this.button_dataCacheViewer.Location = new System.Drawing.Point(94, 13);
            this.button_dataCacheViewer.Name = "button_dataCacheViewer";
            this.button_dataCacheViewer.Size = new System.Drawing.Size(121, 23);
            this.button_dataCacheViewer.TabIndex = 1;
            this.button_dataCacheViewer.Text = "Data Cache Viewer";
            this.button_dataCacheViewer.UseVisualStyleBackColor = true;
            this.button_dataCacheViewer.Click += new System.EventHandler(this.button_dataCacheViewer_Click);
            // 
            // button_codeCacheViewer
            // 
            this.button_codeCacheViewer.Location = new System.Drawing.Point(94, 42);
            this.button_codeCacheViewer.Name = "button_codeCacheViewer";
            this.button_codeCacheViewer.Size = new System.Drawing.Size(121, 23);
            this.button_codeCacheViewer.TabIndex = 2;
            this.button_codeCacheViewer.Text = "Code Cache Viewer";
            this.button_codeCacheViewer.UseVisualStyleBackColor = true;
            this.button_codeCacheViewer.Click += new System.EventHandler(this.button_codeCacheViewer_Click);
            // 
            // button_stackCacheViewer
            // 
            this.button_stackCacheViewer.Location = new System.Drawing.Point(94, 71);
            this.button_stackCacheViewer.Name = "button_stackCacheViewer";
            this.button_stackCacheViewer.Size = new System.Drawing.Size(121, 23);
            this.button_stackCacheViewer.TabIndex = 3;
            this.button_stackCacheViewer.Text = "Stack Cache Viewer";
            this.button_stackCacheViewer.UseVisualStyleBackColor = true;
            this.button_stackCacheViewer.Click += new System.EventHandler(this.button_stackCacheViewer_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 102);
            this.Controls.Add(this.button_stackCacheViewer);
            this.Controls.Add(this.button_codeCacheViewer);
            this.Controls.Add(this.button_dataCacheViewer);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPUemu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button_dataCacheViewer;
        private System.Windows.Forms.Button button_codeCacheViewer;
        private System.Windows.Forms.Button button_stackCacheViewer;
    }
}