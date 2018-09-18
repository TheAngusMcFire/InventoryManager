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
    public partial class FrmAddCompartment : Form
    {
        public FrmAddCompartment(UInt32 id, UInt32 container_id)
        {
            COMPARTMENT = new Compartment(id, container_id);
            InitializeComponent();
        }

        public Compartment COMPARTMENT { get; set; }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                COMPARTMENT.NAME = textBox1.Text;
                this.Close();
            }
        }
    }
}
