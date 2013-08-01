using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeComlete.Model
{
    public class CodeEntity
    {
        public string Title { get; set; }

        public int Index { get; set; }
    }

    public class CodeItself
    {
        public string Code { get; set; }

        public int Index { get; set; }
    }
}