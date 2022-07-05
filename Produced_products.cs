using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
  public class Produced_products
  {
    private string table = "Produced_products";
    private string title = "prod_title";
    private string id = "prod_id";
    private int innerValue;

    public string Table { get { return table; } }
    public string Title { get { return title; } }
    public int Value { get { return innerValue; } set { innerValue = value; } }
    public string Id { get { return id; } }
  }
}
