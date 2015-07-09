namespace EPUemu
{
    partial class ImportDialog
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
            this.label_bytesSelectedHex = new System.Windows.Forms.Label();
            this.label_bytesSelected = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.label_fileStopHex = new System.Windows.Forms.Label();
            this.label_fileStartHex = new System.Windows.Forms.Label();
            this.numericUpDown_fileStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_fileStop = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_openFile = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_insertAtHex = new System.Windows.Forms.Label();
            this.numericUpDown_insertAt = new System.Windows.Forms.NumericUpDown();
            this.button_accept = new System.Windows.Forms.Button();
            this.groupBox_fileRange = new System.Windows.Forms.GroupBox();
            this.groupBox_insertAt = new System.Windows.Forms.GroupBox();
            this.groupBox_bytesSelected = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fileStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fileStop)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_insertAt)).BeginInit();
            this.groupBox_fileRange.SuspendLayout();
            this.groupBox_insertAt.SuspendLayout();
            this.groupBox_bytesSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_bytesSelectedHex
            // 
            this.label_bytesSelectedHex.AutoSize = true;
            this.label_bytesSelectedHex.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bytesSelectedHex.Location = new System.Drawing.Point(6, 33);
            this.label_bytesSelectedHex.Name = "label_bytesSelectedHex";
            this.label_bytesSelectedHex.Size = new System.Drawing.Size(40, 16);
            this.label_bytesSelectedHex.TabIndex = 15;
            this.label_bytesSelectedHex.Text = "????";
            // 
            // label_bytesSelected
            // 
            this.label_bytesSelected.AutoSize = true;
            this.label_bytesSelected.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bytesSelected.Location = new System.Drawing.Point(6, 17);
            this.label_bytesSelected.Name = "label_bytesSelected";
            this.label_bytesSelected.Size = new System.Drawing.Size(40, 16);
            this.label_bytesSelected.TabIndex = 14;
            this.label_bytesSelected.Text = "????";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(76, 22);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(16, 13);
            this.label_to.TabIndex = 9;
            this.label_to.Text = "to";
            // 
            // label_fileStopHex
            // 
            this.label_fileStopHex.AutoSize = true;
            this.label_fileStopHex.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fileStopHex.Location = new System.Drawing.Point(98, 44);
            this.label_fileStopHex.Name = "label_fileStopHex";
            this.label_fileStopHex.Size = new System.Drawing.Size(40, 16);
            this.label_fileStopHex.TabIndex = 6;
            this.label_fileStopHex.Text = "????";
            // 
            // label_fileStartHex
            // 
            this.label_fileStartHex.AutoSize = true;
            this.label_fileStartHex.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fileStartHex.Location = new System.Drawing.Point(6, 44);
            this.label_fileStartHex.Name = "label_fileStartHex";
            this.label_fileStartHex.Size = new System.Drawing.Size(40, 16);
            this.label_fileStartHex.TabIndex = 5;
            this.label_fileStartHex.Text = "????";
            // 
            // numericUpDown_fileStart
            // 
            this.numericUpDown_fileStart.Enabled = false;
            this.numericUpDown_fileStart.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_fileStart.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown_fileStart.Name = "numericUpDown_fileStart";
            this.numericUpDown_fileStart.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown_fileStart.TabIndex = 1;
            this.numericUpDown_fileStart.ValueChanged += new System.EventHandler(this.numericUpDown_fileStart_ValueChanged);
            // 
            // numericUpDown_fileStop
            // 
            this.numericUpDown_fileStop.Enabled = false;
            this.numericUpDown_fileStop.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_fileStop.Location = new System.Drawing.Point(98, 19);
            this.numericUpDown_fileStop.Name = "numericUpDown_fileStop";
            this.numericUpDown_fileStop.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown_fileStop.TabIndex = 2;
            this.numericUpDown_fileStop.ValueChanged += new System.EventHandler(this.numericUpDown_fileStop_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_accept);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.button_openFile);
            this.panel1.Location = new System.Drawing.Point(12, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 58);
            this.panel1.TabIndex = 12;
            // 
            // button_openFile
            // 
            this.button_openFile.Location = new System.Drawing.Point(6, 3);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(75, 23);
            this.button_openFile.TabIndex = 0;
            this.button_openFile.Text = "&Open file...";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(89, 32);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "&Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label_insertAtHex
            // 
            this.label_insertAtHex.AutoSize = true;
            this.label_insertAtHex.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_insertAtHex.Location = new System.Drawing.Point(6, 44);
            this.label_insertAtHex.Name = "label_insertAtHex";
            this.label_insertAtHex.Size = new System.Drawing.Size(40, 16);
            this.label_insertAtHex.TabIndex = 7;
            this.label_insertAtHex.Text = "????";
            // 
            // numericUpDown_insertAt
            // 
            this.numericUpDown_insertAt.Enabled = false;
            this.numericUpDown_insertAt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_insertAt.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown_insertAt.Name = "numericUpDown_insertAt";
            this.numericUpDown_insertAt.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown_insertAt.TabIndex = 6;
            this.numericUpDown_insertAt.ValueChanged += new System.EventHandler(this.numericUpDown_insertAt_ValueChanged);
            // 
            // button_accept
            // 
            this.button_accept.Enabled = false;
            this.button_accept.Location = new System.Drawing.Point(6, 32);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(75, 23);
            this.button_accept.TabIndex = 2;
            this.button_accept.Text = "&Accept";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // groupBox_fileRange
            // 
            this.groupBox_fileRange.Controls.Add(this.numericUpDown_fileStart);
            this.groupBox_fileRange.Controls.Add(this.label_to);
            this.groupBox_fileRange.Controls.Add(this.numericUpDown_fileStop);
            this.groupBox_fileRange.Controls.Add(this.label_fileStopHex);
            this.groupBox_fileRange.Controls.Add(this.label_fileStartHex);
            this.groupBox_fileRange.Location = new System.Drawing.Point(12, 12);
            this.groupBox_fileRange.Name = "groupBox_fileRange";
            this.groupBox_fileRange.Size = new System.Drawing.Size(168, 64);
            this.groupBox_fileRange.TabIndex = 14;
            this.groupBox_fileRange.TabStop = false;
            this.groupBox_fileRange.Text = "File range to import";
            // 
            // groupBox_insertAt
            // 
            this.groupBox_insertAt.Controls.Add(this.label_insertAtHex);
            this.groupBox_insertAt.Controls.Add(this.numericUpDown_insertAt);
            this.groupBox_insertAt.Location = new System.Drawing.Point(12, 82);
            this.groupBox_insertAt.Name = "groupBox_insertAt";
            this.groupBox_insertAt.Size = new System.Drawing.Size(168, 65);
            this.groupBox_insertAt.TabIndex = 15;
            this.groupBox_insertAt.TabStop = false;
            this.groupBox_insertAt.Text = "Insert at";
            // 
            // groupBox_bytesSelected
            // 
            this.groupBox_bytesSelected.Controls.Add(this.label_bytesSelectedHex);
            this.groupBox_bytesSelected.Controls.Add(this.label_bytesSelected);
            this.groupBox_bytesSelected.Location = new System.Drawing.Point(12, 153);
            this.groupBox_bytesSelected.Name = "groupBox_bytesSelected";
            this.groupBox_bytesSelected.Size = new System.Drawing.Size(168, 52);
            this.groupBox_bytesSelected.TabIndex = 16;
            this.groupBox_bytesSelected.TabStop = false;
            this.groupBox_bytesSelected.Text = "Number of bytes selected";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All files (*.*)|*.*";
            this.openFileDialog.Title = "Open Binary...";
            // 
            // ImportDialog
            // 
            this.AcceptButton = this.button_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(192, 272);
            this.Controls.Add(this.groupBox_bytesSelected);
            this.Controls.Add(this.groupBox_insertAt);
            this.Controls.Add(this.groupBox_fileRange);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Binary...";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fileStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fileStop)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_insertAt)).EndInit();
            this.groupBox_fileRange.ResumeLayout(false);
            this.groupBox_fileRange.PerformLayout();
            this.groupBox_insertAt.ResumeLayout(false);
            this.groupBox_insertAt.PerformLayout();
            this.groupBox_bytesSelected.ResumeLayout(false);
            this.groupBox_bytesSelected.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_bytesSelectedHex;
        private System.Windows.Forms.Label label_bytesSelected;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_fileStopHex;
        private System.Windows.Forms.Label label_fileStartHex;
        private System.Windows.Forms.NumericUpDown numericUpDown_fileStart;
        private System.Windows.Forms.NumericUpDown numericUpDown_fileStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_insertAtHex;
        private System.Windows.Forms.NumericUpDown numericUpDown_insertAt;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.GroupBox groupBox_fileRange;
        private System.Windows.Forms.GroupBox groupBox_insertAt;
        private System.Windows.Forms.GroupBox groupBox_bytesSelected;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}