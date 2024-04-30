using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tema2Console
{
    public class OrderSerializer
    {
        public Order DeserializeOrder(string jsonData)
        {
            return JsonConvert.DeserializeObject<Order>(jsonData, new StringEnumConverter());
        }
    }
}
