using DYMO.Label.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryManager
{
    public class LabelMakerHandler
    {
        private IPrinter printer = null;
        private ILabel label = null;

        public void init()
        {
            var printers = Framework.GetPrinters().ToList();

            if (printers.Count != 1)
                throw new Exception($"Error invalid ammount of printers found: {printers.Count }");

            printer = printers[0];

            label = Label.OpenXml(config.label_config_small);
        }

        public void printLabel(string txt)
        {
            var object_names = label.ObjectNames.ToList();

            if (object_names.Count != 1)
                throw new Exception($"Error invalid ammount of object tags found in label: {object_names.Count }");

            label.SetObjectText(object_names[0], txt);
            label.Print(printer);
        }
    }
}
