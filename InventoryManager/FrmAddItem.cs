using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class FrmAddItem : Form
    {
        public FrmAddItem(UInt32 id, UInt32 compartment_id, UInt32 container_id, List<TAG> tags)
        {
            ITEM = new Item(id, 0, compartment_id, container_id, null, null, null);
            InitializeComponent();
            listBox1.Items.AddRange(tags.ToArray());
        }

        public Item ITEM { get; set; }
        public bool VALID { get; set; } = false;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ITEM.AMMOUNT = Convert.ToUInt32(textBoxAmmount.Text);
                ITEM.NAME = textBoxName.Text;
                ITEM.ADD_DESCRIPTION = richTextBox1.Text;

                foreach (var item in listBox1.SelectedItems)
                {
                    ITEM.TAG_IDs.Add((item as TAG).ID);
                }

                VALID = true;
                this.Close();
            }
            catch (Exception exc)
            {

            }
        }
    }
}
