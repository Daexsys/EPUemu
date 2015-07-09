namespace EPUemu
{
    partial class ExportDialog
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.numericUpDown_cacheStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_cacheStop = new System.Windows.Forms.NumericUpDown();
            this.label_cacheStartHex = new System.Windows.Forms.Label();
            this.label_cacheStopHex = new System.Windows.Forms.Label();
            this.label_header_cacheRange = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.panel_exportRange = new System.Windows.Forms.Panel();
            this.label_header_numberOfBytes = new System.Windows.Forms.Label();
            this.panel_bytesSelected = new System.Windows.Forms.Panel();
            this.label_bytesSelectedHex = new System.Windows.Forms.Label();
            this.label_bytesSelected = new System.Windows.Forms.Label();
            this.button_saveFile = new System.Windows.Forms.Button();
            this.panel_mainButtons = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cacheStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cacheStop)).BeginInit();
            this.panel_exportRange.SuspendLayout();
            this.panel_bytesSelected.SuspendLayout();
            this.panel_mainButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(85, 3);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 0;
            this.button_cancel.Text = "&Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_cacheStart
            // 
            this.numericUpDown_cacheStart.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_cacheStart.Location = new System.Drawing.Point(6, 16);
            this.numericUpDown_cacheStart.Name = "numericUpDown_cacheStart";
            this.numericUpDown_cacheStart.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown_cacheStart.TabIndex = 1;
            this.numericUpDown_cacheStart.ValueChanged += new System.EventHandler(this.numericUpDown_cacheStart_ValueChanged);
            // 
            // numericUpDown_cacheStop
            // 
            this.numericUpDown_cacheStop.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_cacheStop.Location = new System.Drawing.Point(98, 16);
            this.numericUpDown_cacheStop.Name = "numericUpDown_cacheStop";
            this.numericUpDown_cacheStop.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown_cacheStop.TabIndex = 2;
            this.numericUpDown_cacheStop.ValueChanged += new System.EventHandler(this.numericUpDown_cacheStop_ValueChanged);
            // 
            // label_cacheStartHex
            // 
            this.label_cacheStartHex.AutoSize = true;
            this.label_cacheStartHex.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cacheStartHex.Location = new System.Drawing.Point(6, 41);
            this.label_cacheStartHex.Name = "label_cacheStartHex";
            this.label_cacheStartHex.Size = new System.Drawing.Size(40, 16);
            this.label_cacheStartHex.TabIndex = 5;
            this.label_cacheStartHex.Text = "????";
            // 
            // label_cacheStopHex
            // 
            this.label_cacheStopHex.AutoSize = true;
            this.label_cacheStopHex.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cacheStopHex.Location = new System.Drawing.Point(98, 41);
            this.label_cacheStopHex.Name = "label_cacheStopHex";
            this.label_cacheStopHex.Size = new System.Drawing.Size(40, 16);
            this.label_cacheStopHex.TabIndex = 6;
            this.label_cacheStopHex.Text = "????";
            // 
            // label_header_cacheRange
            // 
            this.label_header_cacheRange.AutoSize = true;
            this.label_header_cacheRange.Location = new System.Drawing.Point(3, 0);
            this.label_header_cacheRange.Name = "label_header_cacheRange";
            this.label_header_cacheRange.Size = new System.Drawing.Size(115, 13);
            this.label_header_cacheRange.TabIndex = 8;
            this.label_header_cacheRange.Text = "Cache range to export:";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(76, 19);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(16, 13);
            this.label_to.TabIndex = 9;
            this.label_to.Text = "to";
            // 
            // panel_exportRange
            // 
            this.panel_exportRange.Controls.Add(this.label_header_cacheRange);
            this.panel_exportRange.Controls.Add(this.label_to);
            this.panel_exportRange.Controls.Add(this.label_cacheStopHex);
            this.panel_exportRange.Controls.Add(this.label_cacheStartHex);
            this.panel_exportRange.Controls.Add(this.numericUpDown_cacheStart);
            this.panel_exportRange.Controls.Add(this.numericUpDown_cacheStop);
            this.panel_exportRange.Location = new System.Drawing.Point(12, 12);
            this.panel_exportRange.Name = "panel_exportRange";
            this.panel_exportRange.Size = new System.Drawing.Size(167, 62);
            this.panel_exportRange.TabIndex = 10;
            // 
            // label_header_numberOfBytes
            // 
            this.label_header_numberOfBytes.AutoSize = true;
            this.label_header_numberOfBytes.Location = new System.Drawing.Point(3, 0);
            this.label_header_numberOfBytes.Name = "label_header_numberOfBytes";
            this.label_header_numberOfBytes.Size = new System.Drawing.Size(130, 13);
            this.label_header_numberOfBytes.TabIndex = 10;
            this.label_header_numberOfBytes.Text = "Number of bytes selected:";
            // 
            // panel_bytesSelected
            // 
            this.panel_bytesSelected.Controls.Add(this.label_bytesSelectedHex);
            this.panel_bytesSelected.Controls.Add(this.label_bytesSelected);
            this.panel_bytesSelected.Controls.Add(this.label_header_numberOfBytes);
            this.panel_bytesSelected.Location = new System.Drawing.Point(12, 80);
            this.panel_bytesSelected.Name = "panel_bytesSelected";
            this.panel_bytesSelected.Size = new System.Drawing.Size(167, 47);
            this.panel_bytesSelected.TabIndex = 11;
            // 
            // label_bytesSelectedHex
            // 
            this.label_bytesSelectedHex.AutoSize = true;
            this.label_bytesSelectedHex.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bytesSelectedHex.Location = new System.Drawing.Point(6, 29);
            this.label_bytesSelectedHex.Name = "label_bytesSelectedHex";
            this.label_bytesSelectedHex.Size = new System.Drawing.Size(40, 16);
            this.label_bytesSelectedHex.TabIndex = 12;
            this.label_bytesSelectedHex.Text = "????";
            // 
            // label_bytesSelected
            // 
            this.label_bytesSelected.AutoSize = true;
            this.label_bytesSelected.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bytesSelected.Location = new System.Drawing.Point(6, 13);
            this.label_bytesSelected.Name = "label_bytesSelected";
            this.label_bytesSelected.Size = new System.Drawing.Size(40, 16);
            this.label_bytesSelected.TabIndex = 11;
            this.label_bytesSelected.Text = "????";
            // 
            // button_saveFile
            // 
            this.button_saveFile.Location = new System.Drawing.Point(4, 3);
            this.button_saveFile.Name = "button_saveFile";
            this.button_saveFile.Size = new System.Drawing.Size(75, 23);
            this.button_saveFile.TabIndex = 12;
            this.button_saveFile.Text = "&Save file...";
            this.button_saveFile.UseVisualStyleBackColor = true;
            this.button_saveFile.Click += new System.EventHandler(this.button_saveFile_Click);
            // 
            // panel_mainButtons
            // 
            this.panel_mainButtons.Controls.Add(this.button_cancel);
            this.panel_mainButtons.Controls.Add(this.button_saveFile);
            this.panel_mainButtons.Location = new System.Drawing.Point(12, 133);
            this.panel_mainButtons.Name = "panel_mainButtons";
            this.panel_mainButtons.Size = new System.Drawing.Size(167, 30);
            this.panel_mainButtons.TabIndex = 13;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save Binary As...";
            // 
            // ExportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(192, 170);
            this.Controls.Add(this.panel_mainButtons);
            this.Controls.Add(this.panel_bytesSelected);
            this.Controls.Add(this.panel_exportRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(208, 208);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(208, 208);
            this.Name = "ExportDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Binary...";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cacheStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cacheStop)).EndInit();
            this.panel_exportRange.ResumeLayout(false);
            this.panel_exportRange.PerformLayout();
            this.panel_bytesSelected.ResumeLayout(false);
            this.panel_bytesSelected.PerformLayout();
            this.panel_mainButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.NumericUpDown numericUpDown_cacheStart;
        private System.Windows.Forms.NumericUpDown numericUpDown_cacheStop;
        private System.Windows.Forms.Label label_cacheStartHex;
        private System.Windows.Forms.Label label_cacheStopHex;
        private System.Windows.Forms.Label label_header_cacheRange;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Panel panel_exportRange;
        private System.Windows.Forms.Label label_header_numberOfBytes;
        private System.Windows.Forms.Panel panel_bytesSelected;
        private System.Windows.Forms.Label label_bytesSelectedHex;
        private System.Windows.Forms.Label label_bytesSelected;
        private System.Windows.Forms.Button button_saveFile;
        private System.Windows.Forms.Panel panel_mainButtons;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}