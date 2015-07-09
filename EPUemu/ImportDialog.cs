using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EPUemu
{
    public partial class ImportDialog : Form
    {
        private byte[] byteArray;
        private long fileSize;
        private int clearance;

        public ImportDialog(byte[] byteArray)
        {
            InitializeComponent();

            this.byteArray = byteArray;
            this.fileSize = 0;
            this.clearance = (int)(this.byteArray.Length - numericUpDown_insertAt.Value);

            numericUpDown_insertAt.Maximum = this.byteArray.Length - 1;
            updateFields();
        }

        private void updateFields()
        {
            label_fileStartHex.Text = NumberHelper.shortToHex((ushort)(numericUpDown_fileStart.Value));
            label_fileStopHex.Text = NumberHelper.shortToHex((ushort)(numericUpDown_fileStop.Value));

            label_insertAtHex.Text = NumberHelper.shortToHex((ushort)(numericUpDown_insertAt.Value));

            ushort bytesSelected;
            if (button_accept.Enabled)
                bytesSelected = (ushort)(numericUpDown_fileStop.Value - numericUpDown_fileStart.Value + 1);
            else
                bytesSelected = 0;
            label_bytesSelected.Text = bytesSelected.ToString();
            label_bytesSelectedHex.Text = NumberHelper.shortToHex(bytesSelected);
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog oldDialog = openFileDialog;

                this.fileSize = new FileInfo(openFileDialog.FileName).Length;

                // Restore the previous file information if the selected file is too large
                if (this.fileSize > int.MaxValue)
                {
                    MessageBox.Show("The chosen file is too large.");
                    openFileDialog = oldDialog;
                    return;
                }

                numericUpDown_fileStart.Maximum = (int)(this.fileSize) - 1;
                numericUpDown_fileStop.Maximum = (int)(this.fileSize) - 1;

                numericUpDown_fileStop.Value = ((this.fileSize > this.byteArray.Length) ?
                    this.byteArray.Length : (int)(this.fileSize)) - 1;

                numericUpDown_fileStart.Enabled = true;
                numericUpDown_fileStop.Enabled = true;
                numericUpDown_insertAt.Enabled = true;
                button_accept.Enabled = true;
                updateFields();
            }
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void numericUpDown_fileStart_ValueChanged(object sender, EventArgs e)
        {
            // If the fileStart value grows larger than the fileStop value, make them equal.
            if (numericUpDown_fileStart.Value > numericUpDown_fileStop.Value)
                numericUpDown_fileStop.Value = numericUpDown_fileStart.Value;
            // If the fileStart value grows smaller so that the range covers more bytes than there is clearance in the array,
            // decrease the fileStop value.
            if ((numericUpDown_fileStop.Value - numericUpDown_fileStart.Value + 1) > this.clearance)
                numericUpDown_fileStop.Value = numericUpDown_fileStart.Value + this.clearance - 1;
            updateFields();
        }

        private void numericUpDown_fileStop_ValueChanged(object sender, EventArgs e)
        {
            // If the fileStop value grows smaller than the fileStart value, make them equal.
            if (numericUpDown_fileStop.Value < numericUpDown_fileStart.Value)
                numericUpDown_fileStart.Value = numericUpDown_fileStop.Value;
            // If the fileStop value grows larger so that the range covers more bytes than there is clearance in the array,
            // increase the fileStart value.
            if ((numericUpDown_fileStop.Value - numericUpDown_fileStart.Value + 1) > this.clearance)
                numericUpDown_fileStart.Value = numericUpDown_fileStop.Value - this.clearance + 1;
            updateFields();
        }

        private void numericUpDown_insertAt_ValueChanged(object sender, EventArgs e)
        {
            // If insertAt is set to a value where importing the set range of bits will exceed the array limit,
            // decrease the fileStop value to make it fit.
            int range = (int)(numericUpDown_fileStop.Value - numericUpDown_fileStart.Value) + 1;
            this.clearance = (int)(this.byteArray.Length - numericUpDown_insertAt.Value);
            if (range > this.clearance)
                numericUpDown_fileStop.Value -= range - this.clearance;
            updateFields();
        }
    }
}
