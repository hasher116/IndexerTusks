using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTusks
{
    class Word
    {
        public string Source { get; }
        public string Target { get; set; }
        public Word (string source, string target)
        {
            Source = source;
            Target = target;
        }
    }
}
