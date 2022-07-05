using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
    class Max_roll_diameter_resources_used
    {
        private string table = "Max_roll_diameter_resources_used";
        private string title = "max_roll_diameter_resources_size";
        private string id = "max_roll_diameter_resources_used_id";
        private int innerValue;

        public string Table { get { return table; } }
        public string Title { get { return title; } }
        public int Value { get { return innerValue; } set { innerValue = value; } }
        public string Id { get { return id; } }
    }
}
