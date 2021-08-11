using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTestingMVC.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        
        public string Desc{ get; set; }        
        public bool IsComplete { get; set; }
    }
}
