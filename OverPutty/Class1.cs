using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPutty
{
    partial class ListBoxElement
    {
        private int id;
        private string text;

        public ListBoxElement(int id, string text)
        {
            this.id = id;
            this.text = text;
        }

        public int getId()
        {
            return id;
        }

        public string getText()
        {
            return text;
        }

        public override string ToString()
        {
            return text;
        }
    }
}
