using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
  public class Models
  {
    private string table = "Models";
    private string title = "models_title";
    private string id = "models_id";
    private string producerTitle = "models_producer_title";
    private string price = "models_price";
    private int innerValue;

    public string Table { get { return table; } }
    public string Title { get { return title; } }
    public int Value { get { return innerValue; } set { innerValue = value; } }
    public string ProducerTitle { get { return producerTitle; } }
    public string Id { get { return id; } }
    public string Price { get { return price; } }
  }
}
