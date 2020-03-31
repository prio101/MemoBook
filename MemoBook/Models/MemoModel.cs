using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoBook.Models
{
    public class MemoModel
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Memo { get; set; }
        public DateTime DateTime { get; set; }


    }
}
