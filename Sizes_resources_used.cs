using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
    class Sizes_resources_used
    {
        private string table = "Sizes_resources_used";
        private string title = "sizes_resources_used_size";
        private string id = "sizes_resources_used_id";
        private string description = "Sizes_resources_used_description";
        private int innerValue;

        public string Table { get { return table; } }
        public string Title { get { return title; } }
        public int Value { get { return innerValue; } set { innerValue = value; } }
        public string Description { get { return description; } }
        public string Id { get { return id; } }
    }
}
