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
    public partial class FrmAddTag : Form
    {
        public FrmAddTag(UInt32 id)
        {
            TAG_ = new TAG(id, null);
            InitializeComponent();
        }

        public TAG TAG_ { get; set; }
        public bool VALID { get; set; } = false;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VALID = true;
                TAG_.NAME = textBox1.Text;
                this.Close();
            }
        }
    }
}
