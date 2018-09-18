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
            inventory = new Inventory();
        }

        private LabelMakerHandler lbl_handler = null;
        private Inventory inventory = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            //lbl_handler = new LabelMakerHandler();
            //lbl_handler.init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbl_handler == null)
            {
                printError("Error printer needs to be initialized");
                return;
            }

            lbl_handler.printLabel(richTextBox1.Text);
        }

        private void printError(string msg, Exception exc = null)
        {
            MessageBox.Show($"{msg} \n {exc}");
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            FrmAddContainer tmp = new FrmAddContainer((UInt32)inventory.CONTAINER.Count);
            tmp.ShowDialog();
            inventory.CONTAINER.Add(tmp.CONTAINER);
            updateContainerList();
        }       

        private void btnAddCompartment_Click(object sender, EventArgs e)
        {
            if (listBoxContainer.SelectedItem == null)
            {
                printError("No Container Selected");
                return;
            }

            UInt32 container_id = (listBoxContainer.SelectedItem as CompartmentContainer).ID;

            FrmAddCompartment tmp = new FrmAddCompartment((UInt32)inventory.COMPARTMENTS.Count, container_id);
            tmp.ShowDialog();
            inventory.COMPARTMENTS.Add(tmp.COMPARTMENT);
            updateCompartmentList();
        }

        void updateCompartmentList()
        {
            listBoxCompartment.Items.Clear();
            foreach (var item in inventory.COMPARTMENTS)
            {
                listBoxCompartment.Items.Add(item);
            }
        }

        void updateContainerList()
        {
            listBoxContainer.Items.Clear();
            foreach (var item in inventory.CONTAINER)
            {
                listBoxContainer.Items.Add(item);
            }
        }
    }
}
