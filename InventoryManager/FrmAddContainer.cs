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
    public partial class FrmAddContainer : Form
    {
        public FrmAddContainer(UInt32 id)
        {
            CONTAINER = new CompartmentContainer(id);
            InitializeComponent();
        }

        public CompartmentContainer CONTAINER { get; set; } = null;
        public bool VALID { get; set; } = false;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VALID = true;
                CONTAINER.NAME = textBox1.Text;
                this.Close();
            }
        }
    }
}
