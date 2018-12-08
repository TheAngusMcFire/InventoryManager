using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    [Serializable]
    public class ObjectSerializer
    {
        public byte[] serialize(object obj)
        {
            using (MemoryStream mem_stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(mem_stream, obj);
                return mem_stream.ToArray();
            }
        }

        public object deSerialize(byte[] byte_data)
        {
            using (MemoryStream mem_stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                mem_stream.Write(byte_data, 0, byte_data.Length);
                mem_stream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(mem_stream);                
            }
        }
    }

    [Serializable]
    public class Inventory : ObjectSerializer
    {
        public List<Item> ITEMS { get; set; }
        public List<TAG> TAGS { get; set; }
        public List<Container> CONTAINER { get; set; }
        public List<Compartment> COMPARTMENTS { get; set; }

        public Inventory()
        {
            ITEMS = new List<Item>();
            TAGS = new List<TAG>();
            CONTAINER = new List<InventoryManager.Container>();
            COMPARTMENTS = new List<Compartment>();
        }

        public void save(string file_name)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(file_name, FileMode.OpenOrCreate)))
            {
                var byte_data = this.serialize(this);
                writer.Write(byte_data, 0, byte_data.Length);
                writer.Flush();
            }
        }

        public void load(string file_name)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(file_name, FileMode.Open)))
            {
                var data_size = reader.BaseStream.Length;

                if (data_size == 0)
                    return;

                var data_bytes = new byte[data_size];
                reader.Read(data_bytes, 0, data_bytes.Length);
                Inventory tmp = deSerialize(data_bytes) as Inventory;

                this.ITEMS = tmp.ITEMS;
                this.TAGS = tmp.TAGS;
                this.CONTAINER = tmp.CONTAINER;
                this.COMPARTMENTS = tmp.COMPARTMENTS;
            }
        }

        public void clear()
        {
            COMPARTMENTS.Clear();
            TAGS.Clear();
            CONTAINER.Clear();
            ITEMS.Clear();
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

        public override string ToString()
        {
            return string.Format("{0,10}   {1}", ID.ToString("X2"), NAME);
        }
    }

    [Serializable]
    public class Item
    {
        public UInt32 ID { get; set; }
        public UInt32 COMPARTMENT_ID { get; set; }
        public UInt32 CONTAINER_ID { get; set; }

        public UInt32 AMMOUNT { get; set; }
        public string NAME { get; set; }
        public string ADD_DESCRIPTION { get; set; }
        public List<UInt32> TAG_IDs { get; set; }

        public Item(UInt32 id, UInt32 ammount, UInt32 comp_id, UInt32 container_id, string name, string add_description, List<UInt32> tag_ids)
        {
            ID = id;
            AMMOUNT = ammount;
            COMPARTMENT_ID = comp_id;
            CONTAINER_ID = container_id;
            NAME = name;
            ADD_DESCRIPTION = add_description;
            TAG_IDs = new List<uint>();

            if(tag_ids != null)
                TAG_IDs.AddRange(tag_ids);
        }

        public override string ToString()
        {
            return string.Format("{0,10}   {1}", ((CONTAINER_ID << 24) | (COMPARTMENT_ID << 12) | ID).ToString("X6"), NAME);
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
            return string.Format("{0,10}   {1}", ((CONTAINER_ID << 12) | ID).ToString("X4"), NAME);
        }
    }

    [Serializable]
    public class Container
    {
        public UInt32 ID { get; set; }

        public string NAME { get; set; }
        public Container(UInt32 id, string name = null)
        {
            ID = id;
            NAME = name;
        }

        public override string ToString()
        {
            return string.Format("{0,10}   {1}", ID.ToString("X2"), NAME);
        }
    }
}
