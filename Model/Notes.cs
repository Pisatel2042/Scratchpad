using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.Model
{
    public class Notes
    {
        public Notes() {
        
        }  
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int  Number { get; set; }
    }
}
