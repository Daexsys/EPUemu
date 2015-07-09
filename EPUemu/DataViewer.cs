using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPUemu
{
    public partial class DataViewer : Form
    {

        private string oldTextbox_address;
        private string oldTextbox_data;
        public Core core { get; set; }
        private Cache _cache;
        public Cache cache
        {
            get { return this._cache; }
            set
            {
                this._cache = value;

            }
        }

        public DataViewer(Core core, Cache cache)
        {
            InitializeComponent();
            this.core = core;
            this.cache = cache;
            populateListbox();
            listBox_data.SelectedIndex = 0;
        }

        /// <summary>
        /// Populate or update the listbox to display the data cache
        /// </summary>
        /// <param name="entries"></param>
        public void populateListbox()
        {
            // Preserve the selected index
            int oldIndex = this.listBox_data.SelectedIndex;

            listBox_data.Items.Clear();
            listBox_data.Items.AddRange(this.core.getFormattedCache(this.cache));

            // Restore the selected index
            listBox_data.SelectedIndex = oldIndex;
        }

        /// <summary>
        /// Event handler for when the 'close' button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler for when the text is updated in the 'data' textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_data_TextChanged(object sender, EventArgs e)
        {
            // The value entered must be a valid hex character.
            if (NumberHelper.validHexInput(textBox_data.Text))
            {
                // Only color the textbox if the value given is NOT identical to the value that is present in the list.
                if (this.core.readCache(this.cache, (ushort)(listBox_data.SelectedIndex)) !=
                    NumberHelper.hexToByte(textBox_data.Text))
                {
                    textBox_data.BackColor = Color.Yellow;
                    button_abortData.Enabled = true;

                    if (textBox_data.Text.Length == 2) button_updateData.Enabled = true;
                    else button_updateData.Enabled = false;
                }

                // If the value given is identical to the value that is present in the list,
                // then disable the 'abort' and 'update' buttons, and reset the textbox color.
                else
                {
                    textBox_data.BackColor = SystemColors.Window;
                    button_abortData.Enabled = false;
                    button_updateData.Enabled = false;
                }

                oldTextbox_data = textBox_data.Text;
            }
            else
                textBox_data.Text = oldTextbox_data;
        }

        /// <summary>
        /// Event handler for when the 'data' textbox receives focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_data_Enter(object sender, EventArgs e)
        {
            // Preserve textbox contents when it becomes active
            oldTextbox_data = textBox_data.Text;

            // Set the Update button as the default button
            AcceptButton = button_updateData;
        }

        /// <summary>
        /// Event handler for when the 'update' button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_updateData_Click(object sender, EventArgs e)
        {
            this.core.writeCache(
                this.cache,
                (ushort)(listBox_data.SelectedIndex),
                NumberHelper.hexToByte(textBox_data.Text));

            // Update the listbox
            populateListbox();

            // Disable the 'abort' and 'update' buttons and reset the textbox color
            textBox_data.BackColor = SystemColors.Window;
            button_abortData.Enabled = false;
            button_updateData.Enabled = false;

            // Transfer focus to the listbox
            listBox_data.Focus();
        }

        /// <summary>
        /// Event handler for when the 'abort' button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_abortData_Click(object sender, EventArgs e)
        {
            // Reset the 'data' textbox color and disable the 'abort' and 'update' buttons
            textBox_data.Text = NumberHelper.byteToHex(this.core.readCache(this.cache, (ushort)(listBox_data.SelectedIndex)));
            textBox_data.BackColor = SystemColors.Window;
            button_abortData.Enabled = false;
            button_updateData.Enabled = false;

            // Transfer focus to the listbox
            listBox_data.Focus();
        }

        /// <summary>
        /// Event handler for when the 'address' textbox receives focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_address_Enter(object sender, EventArgs e)
        {
            // Preserve textbox contents when it becomes active
            oldTextbox_address = textBox_address.Text;

            // Set the Goto button as the default button
            AcceptButton = button_gotoAddress;
        }

        /// <summary>
        /// Event handler for when the text is updated in the 'address' textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_address_TextChanged(object sender, EventArgs e)
        {
            bool dataIsEqual;

            // The value entered must be a valid hex character, AND
            // the new textbox value must not be the same as before.
            if (NumberHelper.validHexInput(textBox_address.Text) &&
                !String.Equals(textBox_address.Text, oldTextbox_address))
            {
                dataIsEqual =
                    (ushort)(listBox_data.SelectedIndex) ==
                    NumberHelper.hexToShort(textBox_address.Text);

                // Only color the textbox if the value given is NOT identical to the index number selected in the list.
                if (!dataIsEqual)
                    textBox_address.BackColor = Color.Yellow;

                // If the value given is identical to the index number selected in the list,
                // then reset the textbox color.
                else
                    textBox_address.BackColor = SystemColors.Window;

                if (textBox_address.Text.Length == 4) button_gotoAddress.Enabled = true;
                else button_gotoAddress.Enabled = false;

                oldTextbox_address = textBox_address.Text;
            }
            else
                textBox_address.Text = oldTextbox_address;
        }

        /// <summary>
        /// Event handler for when the 'goto address' button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gotoAddress_Click(object sender, EventArgs e)
        {
            this.textBox_address.BackColor = SystemColors.Window;

            // If the new address exceeds the number of items in the listbox, select the last item instead.
            ushort newAddress = NumberHelper.hexToShort(textBox_address.Text);
            if (newAddress > this.listBox_data.Items.Count)
                listBox_data.SelectedIndex = listBox_data.Items.Count - 1;
            else
                listBox_data.SelectedIndex = newAddress;

            // Transfer focus to the listbox
            listBox_data.Focus();
        }

        /// <summary>
        /// Event handler for when a different item is selected in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_dataCache_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update textbox for the address.
            textBox_address.Text = NumberHelper.shortToHex((ushort)(listBox_data.SelectedIndex));

            // Update textbox for the data.
            textBox_data.Text =
                NumberHelper.byteToHex((byte)(this.core.readCache(this.cache, (ushort)(listBox_data.SelectedIndex))));
        }

        /// <summary>
        /// Event handler for when a keypress is received
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataCacheViewer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad8:
                case Keys.NumPad4:
                    if (listBox_data.Focused)
                    {
                        if (listBox_data.SelectedIndex != 0)
                            listBox_data.SelectedIndex--;
                    }
                    break;
                case Keys.NumPad2:
                case Keys.NumPad6:
                    if (listBox_data.Focused)
                    {
                        if (listBox_data.Items.Count - 1 != listBox_data.SelectedIndex)
                            listBox_data.SelectedIndex++;
                    }
                    break;
                case Keys.G:
                    if (listBox_data.Focused)
                    {
                        textBox_address.Focus();
                        textBox_address.SelectAll(); 
                    }
                    break;
                case Keys.E:
                    if (listBox_data.Focused)
                    {
                        textBox_data.Focus();
                        textBox_data.SelectAll(); 
                    }
                    break;
                case Keys.Escape:
                    if (textBox_data.Focused)
                    {
                        button_abortData_Click(null, null);
                        e.SuppressKeyPress = true;
                    }
                    else if (textBox_address.Focused)
                    {
                        textBox_address.BackColor = SystemColors.Window;
                        textBox_address.Text = NumberHelper.shortToHex((ushort)(listBox_data.SelectedIndex));
                        listBox_data.Focus();
                        e.SuppressKeyPress = true;
                    }
                    break;
            }
        }

        /// <summary>
        /// Event handler for when an item in the listbox is doubleclicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_dataCache_DoubleClick(object sender, EventArgs e)
        {
            // Shift focus to 'data' textbox and select all text when the listbox is doubleclicked.
            textBox_data.Focus();
            textBox_data.SelectAll();
        }

        /// <summary>
        /// Event handler for when the 'export' button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_export_Click(object sender, EventArgs e)
        {
            new ExportDialog(this.core.getCache(this.cache)).ShowDialog();
        }

        /// <summary>
        /// Event handler for when the 'import' button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_import_Click(object sender, EventArgs e)
        {
            new ImportDialog(this.core.getCache(this.cache)).ShowDialog();
        }
    }
}
