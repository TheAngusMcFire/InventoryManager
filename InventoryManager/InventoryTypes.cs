using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    [Serializable]
    public class Inventory
    {
        public List<Item> ITEMS { get; set; }
        public List<TAG> TAGS { get; set; }
        public List<CompartmentContainer> CONTAINER { get; set; }
        public List<Compartment> COMPARTMENTS { get; set; }

        public Inventory()
        {
            ITEMS = new List<Item>();
            TAGS = new List<TAG>();
            CONTAINER = new List<InventoryManager.CompartmentContainer>();
            COMPARTMENTS = new List<Compartment>();
        }
    }

    [Serializable]
    public class TAG
    {
        public UInt32 ID { get; set; }
        public string NAME { get; set; }

        public TAG(UInt32 id, string name)
        {
            this.ID = id;
            this.NAME = name;
        }
    }

    [Serializable]
    public class Item
    {
        public UInt32 ID { get; set; }
        public UInt32 AMMOUNT { get; set; }
        public UInt32 COMPARTMENT_ID { get; set; }
        public string NAME { get; set; }
        public string ADD_DESCRIPTION { get; set; }
        public List<UInt32> TAG_IDs { get; set; }

        public Item(UInt32 ammount, UInt32 comp_id, string name, string add_description, List<UInt32> tag_ids)
        {
            ID = 0;
            AMMOUNT = ammount;
            COMPARTMENT_ID = comp_id;
            NAME = name;
            ADD_DESCRIPTION = add_description;
            TAG_IDs = new List<uint>();
            TAG_IDs.AddRange(tag_ids);
        }
    }

    [Serializable]
    public class CompartmentContainer
    {
        public UInt32 ID { get; set; }
        public string NAME { get; set; }
        public CompartmentContainer(UInt32 id, string name = null)
        {
            ID = id;
            NAME = name;
        }

        public override string ToString()
        {
            return string.Format("{0}     {1}", ID.ToString("X2"), NAME);
        }
    }

    [Serializable]
    public class Compartment
    {
        public UInt32 ID { get; set; }
        public UInt32 CONTAINER_ID { get; set; }
        public string NAME { get; set; }

        public Compartment(UInt32 id, UInt32 container_id, string name = null)
        {
            ID = id;
            CONTAINER_ID = container_id;
            NAME = name;
        }

        public override string ToString()
        {
            return string.Format("{0}     {1}", ((CONTAINER_ID << 8) | ID).ToString("X4"), NAME);
        }
    }
}
