using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
  public class Raw_materials
  {
        private string table = "Raw_materials";
        private string title = "Raw_materials";
        private string id = "Raw_materials";
        private int innerValue;

        public string Table { get { return table; } }
        public string Title { get { return title; } }
        public int Value { get { return innerValue; } set { innerValue = value; } }
        public string Id { get { return id; } }
    }
}
