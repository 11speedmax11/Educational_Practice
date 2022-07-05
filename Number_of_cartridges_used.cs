using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
  public class Number_of_cartridges_used
  {
    private string table = "Number_of_cartridges_models_used";
    private string title = "number_of_cartridges_models_used_number_of_cartridges";
    private string id = "number_of_cartridges_models_used_id";
    private int innerValue;

    public string Table { get { return table; } }
    public string Title { get { return title; } }
    public int Value { get { return innerValue; } set { innerValue = value; } }
    public string Id { get { return id; } }
  }
}
