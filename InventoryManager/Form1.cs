using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Form1 : Form
    {
        private string file_name = null;
        private LabelMakerHandler lbl_handler = null;
        private Inventory inventory = null;

        public Form1(string[] args)
        {
            if (args.Length > 0)
                file_name = args[0];

            InitializeComponent();
            inventory = new Inventory();
        }

        public void loadOrInitFile()
         {
            try
            {
                if (File.Exists(file_name))
                {
                    inventory.load(file_name);
                    
                }
                else
                    inventory.save(file_name);
            }
            catch (Exception exc)
            {
                printError("Error while loading or initializing inventorx file", exc);
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (file_name == null)
            {
                OpenFileDialog dia = new OpenFileDialog();
                DialogResult result = dia.ShowDialog();

                if (result == DialogResult.OK)                
                    file_name = dia.FileName;                
                else
                {
                    printError("Error no file provided or selected");
                    Application.Exit();
                }
            }

            loadOrInitFile();
            updateAllLists();

            //DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo); 
            //lbl_handler = new LabelMakerHandler();
            //lbl_handler.init();
        }

        #region btn add event handlers

        /// <summary>
        /// btn event for container adding
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            FrmAddContainer tmp = new FrmAddContainer((UInt32)inventory.CONTAINER.Count);
            tmp.ShowDialog();

            if (tmp.VALID)
                inventory.CONTAINER.Add(tmp.CONTAINER);

            updateContainerList();
        }

        /// <summary>
        /// btn event for compartment adding 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            if (tmp.VALID)
                inventory.COMPARTMENTS.Add(tmp.COMPARTMENT);

            updateCompartmentList();
        }

        /// <summary>
        /// btn event for tag adding
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btmAddTag_Click(object sender, EventArgs e)
        {
            FrmAddTag tmp = new FrmAddTag((UInt32)inventory.TAGS.Count);
            tmp.ShowDialog();

            if (tmp.VALID)
                inventory.TAGS.Add(tmp.TAG_);

            updateTagList();
        }

        /// <summary>
        /// btn event for edding items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddItems_Click(object sender, EventArgs e)
        {
            if (listBoxCompartment.SelectedItem == null)
            {
                printError("No Container Selected");
                return;
            }

            UInt32 compartment_id = (listBoxCompartment.SelectedItem as Compartment).ID;
            FrmAddItem tmp = new FrmAddItem((UInt32)inventory.ITEMS.Count, compartment_id, inventory.TAGS);
            tmp.ShowDialog();

            if (tmp.VALID)
                inventory.ITEMS.Add(tmp.ITEM);

            updateItemList();
        }

        #endregion

        #region methods for updating the gui lists

        void updateAllLists()
        {
            updateItemList();
            updateTagList();
            updateCompartmentList();
            updateContainerList();
        }

        void updateItemList()
        {
            listBoxItems.Items.Clear();
            foreach (var item in inventory.ITEMS)
            {
                listBoxItems.Items.Add(item);
            }
        }

        void updateTagList()
        {
            listBoxTags.Items.Clear();
            foreach (var item in inventory.TAGS)
            {
                listBoxTags.Items.Add(item);
            }
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

        #endregion

        public void saveFile()
        {

        }

        private void btn_tmp_print(object sender, EventArgs e)
        {
            if (lbl_handler == null)
            {
                printError("Error printer needs to be initialized");
                return;
            }

            //lbl_handler.printLabel(richTextBox1.Text);
        }


        /// <summary>
        /// prints error mesagebox if exception is not null trace is printed
        /// </summary>
        /// <param name="msg">The general message</param>
        /// <param name="exc">The exception with the stack trace</param>
        private void printError(string msg, Exception exc = null)
        {
            MessageBox.Show($"{msg} \n {exc}");
        }

        private void btn_save(object sender, EventArgs e)
        {
            try
            {
                inventory.save(file_name);
            }
            catch (Exception exc)
            {
                printError("Error while saving", exc);
            }
        }
    }
}
