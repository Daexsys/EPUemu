namespace EPUemu
{
    partial class DataViewer
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
            this.listBox_data = new System.Windows.Forms.ListBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.button_gotoAddress = new System.Windows.Forms.Button();
            this.groupBox_address = new System.Windows.Forms.GroupBox();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.button_export = new System.Windows.Forms.Button();
            this.button_abortData = new System.Windows.Forms.Button();
            this.button_updateData = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox_keys = new System.Windows.Forms.GroupBox();
            this.label_quickKeyLegend = new System.Windows.Forms.Label();
            this.label_quickKeyDescription = new System.Windows.Forms.Label();
            this.groupBox_address.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            this.groupBox_keys.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_data
            // 
            this.listBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_data.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_data.FormattingEnabled = true;
            this.listBox_data.ItemHeight = 16;
            this.listBox_data.Location = new System.Drawing.Point(12, 12);
            this.listBox_data.Name = "listBox_data";
            this.listBox_data.Size = new System.Drawing.Size(121, 292);
            this.listBox_data.TabIndex = 0;
            this.listBox_data.SelectedIndexChanged += new System.EventHandler(this.listBox_dataCache_SelectedIndexChanged);
            this.listBox_data.DoubleClick += new System.EventHandler(this.listBox_dataCache_DoubleClick);
            // 
            // textBox_address
            // 
            this.textBox_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_address.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(4, 17);
            this.textBox_address.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_address.MaxLength = 4;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(40, 22);
            this.textBox_address.TabIndex = 3;
            this.textBox_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_address.TextChanged += new System.EventHandler(this.textBox_address_TextChanged);
            this.textBox_address.Enter += new System.EventHandler(this.textBox_address_Enter);
            // 
            // textBox_data
            // 
            this.textBox_data.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_data.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_data.Location = new System.Drawing.Point(20, 18);
            this.textBox_data.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_data.MaxLength = 2;
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(24, 22);
            this.textBox_data.TabIndex = 4;
            this.textBox_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_data.TextChanged += new System.EventHandler(this.textBox_data_TextChanged);
            this.textBox_data.Enter += new System.EventHandler(this.textBox_data_Enter);
            // 
            // button_gotoAddress
            // 
            this.button_gotoAddress.Enabled = false;
            this.button_gotoAddress.Location = new System.Drawing.Point(55, 16);
            this.button_gotoAddress.Margin = new System.Windows.Forms.Padding(2);
            this.button_gotoAddress.Name = "button_gotoAddress";
            this.button_gotoAddress.Size = new System.Drawing.Size(75, 23);
            this.button_gotoAddress.TabIndex = 5;
            this.button_gotoAddress.Text = "Goto";
            this.button_gotoAddress.UseVisualStyleBackColor = true;
            this.button_gotoAddress.Click += new System.EventHandler(this.button_gotoAddress_Click);
            // 
            // groupBox_address
            // 
            this.groupBox_address.Controls.Add(this.button_gotoAddress);
            this.groupBox_address.Controls.Add(this.textBox_address);
            this.groupBox_address.Location = new System.Drawing.Point(138, 12);
            this.groupBox_address.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_address.Name = "groupBox_address";
            this.groupBox_address.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_address.Size = new System.Drawing.Size(135, 45);
            this.groupBox_address.TabIndex = 6;
            this.groupBox_address.TabStop = false;
            this.groupBox_address.Text = "Address";
            // 
            // groupBox_data
            // 
            this.groupBox_data.Controls.Add(this.button_export);
            this.groupBox_data.Controls.Add(this.button_abortData);
            this.groupBox_data.Controls.Add(this.button_updateData);
            this.groupBox_data.Controls.Add(this.button_import);
            this.groupBox_data.Controls.Add(this.textBox_data);
            this.groupBox_data.Location = new System.Drawing.Point(138, 62);
            this.groupBox_data.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_data.Size = new System.Drawing.Size(135, 128);
            this.groupBox_data.TabIndex = 7;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "Data";
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(55, 99);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(75, 23);
            this.button_export.TabIndex = 8;
            this.button_export.Text = "Export...";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_abortData
            // 
            this.button_abortData.Enabled = false;
            this.button_abortData.Location = new System.Drawing.Point(55, 44);
            this.button_abortData.Margin = new System.Windows.Forms.Padding(2);
            this.button_abortData.Name = "button_abortData";
            this.button_abortData.Size = new System.Drawing.Size(75, 23);
            this.button_abortData.TabIndex = 6;
            this.button_abortData.Text = "Abort";
            this.button_abortData.UseVisualStyleBackColor = true;
            this.button_abortData.Click += new System.EventHandler(this.button_abortData_Click);
            // 
            // button_updateData
            // 
            this.button_updateData.Enabled = false;
            this.button_updateData.Location = new System.Drawing.Point(55, 17);
            this.button_updateData.Margin = new System.Windows.Forms.Padding(2);
            this.button_updateData.Name = "button_updateData";
            this.button_updateData.Size = new System.Drawing.Size(75, 23);
            this.button_updateData.TabIndex = 5;
            this.button_updateData.Text = "Update";
            this.button_updateData.UseVisualStyleBackColor = true;
            this.button_updateData.Click += new System.EventHandler(this.button_updateData_Click);
            // 
            // button_import
            // 
            this.button_import.Location = new System.Drawing.Point(55, 72);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(75, 23);
            this.button_import.TabIndex = 7;
            this.button_import.Text = "Import...";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_close.Location = new System.Drawing.Point(193, 298);
            this.button_close.Margin = new System.Windows.Forms.Padding(2);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 8;
            this.button_close.Text = "&Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // groupBox_keys
            // 
            this.groupBox_keys.Controls.Add(this.label_quickKeyLegend);
            this.groupBox_keys.Controls.Add(this.label_quickKeyDescription);
            this.groupBox_keys.Location = new System.Drawing.Point(138, 194);
            this.groupBox_keys.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_keys.Name = "groupBox_keys";
            this.groupBox_keys.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_keys.Size = new System.Drawing.Size(135, 88);
            this.groupBox_keys.TabIndex = 9;
            this.groupBox_keys.TabStop = false;
            this.groupBox_keys.Text = "QuickKeys";
            // 
            // label_quickKeyLegend
            // 
            this.label_quickKeyLegend.AutoSize = true;
            this.label_quickKeyLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quickKeyLegend.Location = new System.Drawing.Point(5, 15);
            this.label_quickKeyLegend.Name = "label_quickKeyLegend";
            this.label_quickKeyLegend.Size = new System.Drawing.Size(61, 65);
            this.label_quickKeyLegend.TabIndex = 0;
            this.label_quickKeyLegend.Text = "G\r\nE\r\nNumPad8\r\nNumPad2\r\nESC";
            // 
            // label_quickKeyDescription
            // 
            this.label_quickKeyDescription.AutoSize = true;
            this.label_quickKeyDescription.Location = new System.Drawing.Point(72, 14);
            this.label_quickKeyDescription.Name = "label_quickKeyDescription";
            this.label_quickKeyDescription.Size = new System.Drawing.Size(41, 65);
            this.label_quickKeyDescription.TabIndex = 0;
            this.label_quickKeyDescription.Text = "- Goto\r\n- Edit\r\n- Up\r\n- Down\r\n- Abort";
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 332);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.groupBox_keys);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_address);
            this.Controls.Add(this.listBox_data);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(300, 32768);
            this.MinimumSize = new System.Drawing.Size(300, 370);
            this.Name = "DataViewer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Cache Viewer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataCacheViewer_KeyDown);
            this.groupBox_address.ResumeLayout(false);
            this.groupBox_address.PerformLayout();
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            this.groupBox_keys.ResumeLayout(false);
            this.groupBox_keys.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_data;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.Button button_gotoAddress;
        private System.Windows.Forms.GroupBox groupBox_address;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.Button button_abortData;
        private System.Windows.Forms.Button button_updateData;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.GroupBox groupBox_keys;
        private System.Windows.Forms.Label label_quickKeyLegend;
        private System.Windows.Forms.Label label_quickKeyDescription;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_export;





    }
}