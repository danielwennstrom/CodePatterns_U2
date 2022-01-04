using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    class Tag : ITag
    {
        public Tag()
        {
            TagName = "";
            TagElementStart = "";
            TagElementEnd = "";
        }
        public string TagName;
        public string TagElementStart;
        public string TagElementEnd;
        public string GetTagEnd()
        {
            return TagElementStart;
        }

        public string GetTagStart()
        {
            return TagElementEnd;
        }
    }
}
