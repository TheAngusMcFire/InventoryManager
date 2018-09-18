using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private LabelMakerHandler lbl_handler = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_handler = new LabelMakerHandler();
            lbl_handler.init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_handler.printLabel(richTextBox1.Text);
        }
    }
}
