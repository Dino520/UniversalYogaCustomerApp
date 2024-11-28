using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalYogaCustomerApp.Models;

public class YogaClass
{
    public int Id { get; set; }
    public string Day { get; set; }
    public string Time { get; set; }
    public int Capacity { get; set; }
    public int Duration { get; set; }
    public double Price { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
}

