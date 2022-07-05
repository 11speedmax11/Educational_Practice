using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
    class Factories
    {
        private string table = "Factories";
        private string title = "factory_title";
        private string id = "factory_id";
        private int innerValue;

        public string Table { get { return table; } }
        public string Title { get { return title; } }
        public int Value { get { return innerValue; } set { innerValue = value; } }
        public string Id { get { return id; } }
    }
}
