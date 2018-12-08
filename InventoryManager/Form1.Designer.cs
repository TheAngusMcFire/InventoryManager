namespace InventoryManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxContainer = new System.Windows.Forms.ListBox();
            this.listBoxCompartment = new System.Windows.Forms.ListBox();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.listBoxTags = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_container = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_compartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.buttonAddItems = new System.Windows.Forms.Button();
            this.textBox_items = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btmAddTag = new System.Windows.Forms.Button();
            this.textBox_tags = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_item_name = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox_item_tags = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox_item_description = new System.Windows.Forms.RichTextBox();
            this.label_item_ammount = new System.Windows.Forms.Label();
            this.label_item_compartment = new System.Windows.Forms.Label();
            this.label_item_container = new System.Windows.Forms.Label();
            this.label_item_id = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_print = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxContainer
            // 
            this.listBoxContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxContainer.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxContainer.FormattingEnabled = true;
            this.listBoxContainer.ItemHeight = 14;
            this.listBoxContainer.Location = new System.Drawing.Point(0, 60);
            this.listBoxContainer.Name = "listBoxContainer";
            this.listBoxContainer.Size = new System.Drawing.Size(393, 340);
            this.listBoxContainer.TabIndex = 3;
            // 
            // listBoxCompartment
            // 
            this.listBoxCompartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCompartment.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCompartment.FormattingEnabled = true;
            this.listBoxCompartment.ItemHeight = 14;
            this.listBoxCompartment.Location = new System.Drawing.Point(0, 60);
            this.listBoxCompartment.Name = "listBoxCompartment";
            this.listBoxCompartment.Size = new System.Drawing.Size(376, 340);
            this.listBoxCompartment.TabIndex = 4;
            // 
            // listBoxItems
            // 
            this.listBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxItems.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 14;
            this.listBoxItems.Location = new System.Drawing.Point(0, 60);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(370, 340);
            this.listBoxItems.TabIndex = 5;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // listBoxTags
            // 
            this.listBoxTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTags.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTags.FormattingEnabled = true;
            this.listBoxTags.ItemHeight = 14;
            this.listBoxTags.Location = new System.Drawing.Point(0, 60);
            this.listBoxTags.Name = "listBoxTags";
            this.listBoxTags.Size = new System.Drawing.Size(383, 340);
            this.listBoxTags.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(14, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1549, 450);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1543, 431);
            this.splitContainer1.SplitterDistance = 777;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_container);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.listBoxContainer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_compartment);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.listBoxCompartment);
            this.splitContainer2.Size = new System.Drawing.Size(777, 431);
            this.splitContainer2.SplitterDistance = 394;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(342, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAddContainer_Click);
            // 
            // textBox_container
            // 
            this.textBox_container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_container.Location = new System.Drawing.Point(3, 32);
            this.textBox_container.Name = "textBox_container";
            this.textBox_container.Size = new System.Drawing.Size(330, 20);
            this.textBox_container.TabIndex = 5;
            this.textBox_container.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxContainerKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Containers";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(324, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAddCompartment_Click);
            // 
            // textBox_compartment
            // 
            this.textBox_compartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_compartment.Location = new System.Drawing.Point(3, 32);
            this.textBox_compartment.Name = "textBox_compartment";
            this.textBox_compartment.Size = new System.Drawing.Size(313, 20);
            this.textBox_compartment.TabIndex = 6;
            this.textBox_compartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_compartment_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Compartments";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.buttonAddItems);
            this.splitContainer3.Panel1.Controls.Add(this.textBox_items);
            this.splitContainer3.Panel1.Controls.Add(this.listBoxItems);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btmAddTag);
            this.splitContainer3.Panel2.Controls.Add(this.textBox_tags);
            this.splitContainer3.Panel2.Controls.Add(this.label2);
            this.splitContainer3.Panel2.Controls.Add(this.listBoxTags);
            this.splitContainer3.Size = new System.Drawing.Size(761, 431);
            this.splitContainer3.SplitterDistance = 371;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // buttonAddItems
            // 
            this.buttonAddItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddItems.Location = new System.Drawing.Point(318, 32);
            this.buttonAddItems.Name = "buttonAddItems";
            this.buttonAddItems.Size = new System.Drawing.Size(49, 25);
            this.buttonAddItems.TabIndex = 8;
            this.buttonAddItems.Text = "+";
            this.buttonAddItems.UseVisualStyleBackColor = true;
            this.buttonAddItems.Click += new System.EventHandler(this.buttonAddItems_Click);
            // 
            // textBox_items
            // 
            this.textBox_items.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_items.Location = new System.Drawing.Point(3, 32);
            this.textBox_items.Name = "textBox_items";
            this.textBox_items.Size = new System.Drawing.Size(307, 20);
            this.textBox_items.TabIndex = 7;
            this.textBox_items.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_items_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items";
            // 
            // btmAddTag
            // 
            this.btmAddTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmAddTag.Location = new System.Drawing.Point(331, 32);
            this.btmAddTag.Name = "btmAddTag";
            this.btmAddTag.Size = new System.Drawing.Size(49, 25);
            this.btmAddTag.TabIndex = 9;
            this.btmAddTag.Text = "+";
            this.btmAddTag.UseVisualStyleBackColor = true;
            this.btmAddTag.Click += new System.EventHandler(this.btmAddTag_Click);
            // 
            // textBox_tags
            // 
            this.textBox_tags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_tags.Location = new System.Drawing.Point(3, 32);
            this.textBox_tags.Name = "textBox_tags";
            this.textBox_tags.Size = new System.Drawing.Size(320, 20);
            this.textBox_tags.TabIndex = 8;
            this.textBox_tags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_tags_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tags";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_save);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label_item_name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.listBox_item_tags);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.richTextBox_item_description);
            this.groupBox1.Controls.Add(this.label_item_ammount);
            this.groupBox1.Controls.Add(this.label_item_compartment);
            this.groupBox1.Controls.Add(this.label_item_container);
            this.groupBox1.Controls.Add(this.label_item_id);
            this.groupBox1.Location = new System.Drawing.Point(14, 477);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 204);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ammount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "Compartment:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "Container:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 14);
            this.label11.TabIndex = 9;
            this.label11.Text = "ID:";
            // 
            // label_item_name
            // 
            this.label_item_name.AutoSize = true;
            this.label_item_name.Location = new System.Drawing.Point(105, 30);
            this.label_item_name.Name = "label_item_name";
            this.label_item_name.Size = new System.Drawing.Size(42, 14);
            this.label_item_name.TabIndex = 8;
            this.label_item_name.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(787, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tags:";
            // 
            // listBox_item_tags
            // 
            this.listBox_item_tags.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_item_tags.FormattingEnabled = true;
            this.listBox_item_tags.ItemHeight = 14;
            this.listBox_item_tags.Location = new System.Drawing.Point(791, 30);
            this.listBox_item_tags.Name = "listBox_item_tags";
            this.listBox_item_tags.Size = new System.Drawing.Size(238, 144);
            this.listBox_item_tags.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = "Description:";
            // 
            // richTextBox_item_description
            // 
            this.richTextBox_item_description.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_item_description.Location = new System.Drawing.Point(525, 30);
            this.richTextBox_item_description.Name = "richTextBox_item_description";
            this.richTextBox_item_description.Size = new System.Drawing.Size(258, 158);
            this.richTextBox_item_description.TabIndex = 4;
            this.richTextBox_item_description.Text = "";
            // 
            // label_item_ammount
            // 
            this.label_item_ammount.AutoSize = true;
            this.label_item_ammount.Location = new System.Drawing.Point(104, 143);
            this.label_item_ammount.Name = "label_item_ammount";
            this.label_item_ammount.Size = new System.Drawing.Size(63, 14);
            this.label_item_ammount.TabIndex = 3;
            this.label_item_ammount.Text = "Ammount:";
            // 
            // label_item_compartment
            // 
            this.label_item_compartment.AutoSize = true;
            this.label_item_compartment.Location = new System.Drawing.Point(104, 113);
            this.label_item_compartment.Name = "label_item_compartment";
            this.label_item_compartment.Size = new System.Drawing.Size(91, 14);
            this.label_item_compartment.TabIndex = 2;
            this.label_item_compartment.Text = "Compartment:";
            // 
            // label_item_container
            // 
            this.label_item_container.AutoSize = true;
            this.label_item_container.Location = new System.Drawing.Point(104, 82);
            this.label_item_container.Name = "label_item_container";
            this.label_item_container.Size = new System.Drawing.Size(77, 14);
            this.label_item_container.TabIndex = 1;
            this.label_item_container.Text = "Container:";
            // 
            // label_item_id
            // 
            this.label_item_id.AutoSize = true;
            this.label_item_id.Location = new System.Drawing.Point(104, 55);
            this.label_item_id.Name = "label_item_id";
            this.label_item_id.Size = new System.Drawing.Size(28, 14);
            this.label_item_id.TabIndex = 0;
            this.label_item_id.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button_print);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(1061, 477);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 206);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controls";
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(21, 132);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(182, 25);
            this.button_print.TabIndex = 8;
            this.button_print.Text = "print item label";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 25);
            this.button4.TabIndex = 9;
            this.button4.Text = "print compartment label";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 25);
            this.button5.TabIndex = 10;
            this.button5.Text = "print container label";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 695);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "InventoryManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxContainer;
        private System.Windows.Forms.ListBox listBoxCompartment;
        private System.Windows.Forms.ListBox listBoxTags;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_compartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddItems;
        private System.Windows.Forms.TextBox textBox_items;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmAddTag;
        private System.Windows.Forms.TextBox textBox_tags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_item_ammount;
        private System.Windows.Forms.Label label_item_compartment;
        private System.Windows.Forms.Label label_item_container;
        private System.Windows.Forms.Label label_item_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox_item_description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox_item_tags;
        private System.Windows.Forms.Label label_item_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

