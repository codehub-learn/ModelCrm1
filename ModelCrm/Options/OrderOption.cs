using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCrm.Options
{
    public class OrderOption
    {
        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public string CustomerName{ get; set; }

        public List<int> Products { get; set; }
    }
}
