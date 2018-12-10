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
            lbl_handler = new LabelMakerHandler();
            lbl_handler.init();
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

            UInt32 container_id = (listBoxContainer.SelectedItem as Container).ID;

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
            UInt32 container_id = (listBoxCompartment.SelectedItem as Compartment).CONTAINER_ID;
            FrmAddItem tmp = new FrmAddItem((UInt32)inventory.ITEMS.Count, compartment_id, container_id, inventory.TAGS);
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

        void updateItemList(string filter = null)
        {
            listBoxItems.Items.Clear();
            if (filter == null)
            {
                foreach (var item in inventory.ITEMS)
                {
                    listBoxItems.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in inventory.ITEMS)
                {
                    if (item.ToString().Contains(filter))
                        listBoxItems.Items.Add(item);
                }
            }
        }

        void updateItemList(TAG tag)
        {
            listBoxItems.Items.Clear();

            foreach (var item in inventory.ITEMS)
            {
                if (item.TAG_IDs.Contains(tag.ID))
                    listBoxItems.Items.Add(item);
            }
        }

        void updateTagList(string filter = null)
        {
            listBoxTags.Items.Clear();

            if (filter == null)
            {
                foreach (var item in inventory.TAGS)
                {
                    listBoxTags.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in inventory.TAGS)
                {
                    if (item.ToString().Contains(filter))
                        listBoxTags.Items.Add(item);
                }
            }
        }

        void updateCompartmentList(string filter = null)
        {
            listBoxCompartment.Items.Clear();

            if (filter == null)
            {
                foreach (var item in inventory.COMPARTMENTS)
                {
                    listBoxCompartment.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in inventory.COMPARTMENTS)
                {
                    if (item.ToString().Contains(filter))
                        listBoxCompartment.Items.Add(item);
                }
            }
        }

        void updateContainerList(string filter = null)
        {
            listBoxContainer.Items.Clear();

            if (filter == null)
            {
                foreach (var item in inventory.CONTAINER)
                {
                    listBoxContainer.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in inventory.CONTAINER)
                {
                    if (item.ToString().Contains(filter))
                        listBoxContainer.Items.Add(item);
                }
            }
        }

        #endregion

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

        private void textBoxContainerKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_container.Text != "")
                    updateContainerList(textBox_container.Text);
                else
                    updateContainerList();
            }

            if (e.KeyCode == Keys.Escape)
                textBox_container.Text = "";
        }

        private void textBox_compartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_compartment.Text != "")
                    updateCompartmentList(textBox_compartment.Text);
                else
                    updateCompartmentList();
            }

            if (e.KeyCode == Keys.Escape)
                textBox_compartment.Text = "";
        }

        private void textBox_items_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_items.Text != "")
                    updateItemList(textBox_items.Text);
                else
                    updateItemList();
            }

            if (e.KeyCode == Keys.Escape)
                (sender as TextBox).Text = "";
        }

        private void textBox_tags_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_tags.Text != "")
                    updateTagList(textBox_tags.Text);
                else
                    updateTagList();
            }

            if (e.KeyCode == Keys.Escape)
                (sender as TextBox).Text = "";
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (listBoxItems.SelectedItem as Item);

            if (item == null)
                return;

            label_item_ammount.Text = item.AMMOUNT.ToString();

            label_item_compartment.Text = inventory.getEntryById<Compartment>(item.COMPARTMENT_ID).ToString();
            label_item_container.Text = inventory.getEntryById<Container>(item.CONTAINER_ID).ToString();

            label_item_id.Text = item.ID.ToString();
            label_item_name.Text = item.NAME;
            richTextBox_item_description.Text = item.ADD_DESCRIPTION;
            listBox_item_tags.Items.Clear();

            foreach (var tag_id in item.TAG_IDs)
            {
                listBox_item_tags.Items.Add(inventory.getEntryById<TAG>(tag_id));
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            if (lbl_handler == null)
            {
                printError("Error printer needs to be initialized");
                return;
            }

            var item = (listBoxItems.SelectedItem as Item);

            if (item == null)
                return;

            lbl_handler.printLabel(item.getPrintString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lbl_handler == null)
            {
                printError("Error printer needs to be initialized");
                return;
            }

            var item = (listBoxContainer.SelectedItem as Container);

            if (item == null)
                return;

            lbl_handler.printLabel(item.getPrintString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbl_handler == null)
            {
                printError("Error printer needs to be initialized");
                return;
            }

            var item = (listBoxCompartment.SelectedItem as Compartment);

            if (item == null)
                return;

            lbl_handler.printLabel(item.getPrintString());
        }

        private void button_sort_tags_Click(object sender, EventArgs e)
        {
            var obj = listBoxTags.SelectedItem;

            if (obj == null)
            {
                updateAllLists();
                return;
            }

            updateItemList(obj as TAG);
        }

        private void btn_edit_container_Click(object sender, EventArgs e)
        {
            var obj = listBoxContainer.SelectedItem as Container;

            if (obj == null)
                return;

            FrmAddContainer tmp = new FrmAddContainer(obj);

            tmp.ShowDialog();

            //if (tmp.VALID)
            //    inventory.CONTAINER.Add(tmp.CONTAINER);

            updateContainerList();
        }

        private void btn_edit_comartment_Click(object sender, EventArgs e)
        {
            var comp = listBoxCompartment.SelectedItem as Compartment;

            if (comp == null)
                return;

            FrmAddCompartment tmp = new FrmAddCompartment(comp);
            tmp.ShowDialog();

            //if (tmp.VALID)
            //    inventory.COMPARTMENTS.Add(tmp.COMPARTMENT);

            updateCompartmentList();
        }

        private void btn_edit_item_Click(object sender, EventArgs e)
        {
            var item = listBoxItems.SelectedItem as Item;

            if (item == null)
                return;

            FrmAddItem tmp = new FrmAddItem(item, inventory.TAGS);
            tmp.ShowDialog();

            //if (tmp.VALID)
            //    inventory.ITEMS.Add(tmp.ITEM);

            updateItemList();
        }
    }
}
