using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
  public class Type_models_uses
  {
    private string table = "Type_models_uses";
    private string title = "type_models_uses_type";
    private string id = "type_models_uses_id";
    private string description = "type_models_uses_description";
    private int innerValue;

    public string Table { get { return table; } }
    public string Title { get { return title; } }
    public int Value { get { return innerValue; } set { innerValue = value; } }
    public string Description { get { return description; } }
    public string Id { get { return id; } }
  }
}
