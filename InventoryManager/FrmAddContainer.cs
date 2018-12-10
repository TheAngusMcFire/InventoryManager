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
            CONTAINER = new Container(id);
            InitializeComponent();
        }

        public FrmAddContainer(Container container)
        {
            CONTAINER = container;
            InitializeComponent();
            textBox1.Text = CONTAINER.NAME;
        }

        public Container CONTAINER { get; set; } = null;
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

        private void FrmAddContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
