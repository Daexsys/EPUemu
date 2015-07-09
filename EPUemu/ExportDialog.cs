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
    public partial class ExportDialog : Form
    {
        private byte[] byteArray;

        public ExportDialog(byte[] byteArray)
        {
            InitializeComponent();
            this.byteArray = byteArray;

            numericUpDown_cacheStart.Maximum =
                numericUpDown_cacheStop.Value =
                numericUpDown_cacheStop.Maximum = this.byteArray.Length - 1;

            updateFields();
        }

        private void updateFields()
        {
            label_cacheStartHex.Text = NumberHelper.shortToHex((ushort)(numericUpDown_cacheStart.Value));
            label_cacheStopHex.Text = NumberHelper.shortToHex((ushort)(numericUpDown_cacheStop.Value));

            ushort bytesSelected = (ushort)(numericUpDown_cacheStop.Value - numericUpDown_cacheStart.Value + 1);
            label_bytesSelected.Text = bytesSelected.ToString();
            label_bytesSelectedHex.Text = NumberHelper.shortToHex(bytesSelected);
        }

        private void numericUpDown_cacheStart_ValueChanged(object sender, EventArgs e)
        {
            // If the cacheStart value grows larger than the cacheStop value, make them equal.
            if (numericUpDown_cacheStart.Value > numericUpDown_cacheStop.Value)
                numericUpDown_cacheStop.Value = numericUpDown_cacheStart.Value;
            updateFields();
        }

        private void numericUpDown_cacheStop_ValueChanged(object sender, EventArgs e)
        {
            // If the cacheStop value grows smaller than the cacheStart value, make them equal.
            if (numericUpDown_cacheStop.Value < numericUpDown_cacheStart.Value)
                numericUpDown_cacheStart.Value = numericUpDown_cacheStop.Value;
            updateFields();
        }

        private void button_saveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter writer = new BinaryWriter(saveFileDialog.OpenFile()))
                {
                    int arrayLength = (int)(numericUpDown_cacheStop.Value - numericUpDown_cacheStart.Value + 1);
                    byte[] subArray = new byte[arrayLength];
                    Array.Copy(this.byteArray, (int)(numericUpDown_cacheStart.Value), subArray, 0, arrayLength);
                    writer.Write(subArray);
                    writer.Close();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
