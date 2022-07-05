using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
    class Chroma_models_uses
    {
        private string table = "Chroma_models_uses";
        private string title = "chroma_models_uses_chroma";
        private string id = "chroma_models_uses_id";
        private string description = "chroma_models_uses_description";
        private int innerValue;

        public string Table { get { return table; } }
        public string Title { get { return title; } }
        public int Value { get { return innerValue; } set { innerValue = value; } }
        public string Description { get { return description; } }
        public string Id { get { return id; } }
    }
}
