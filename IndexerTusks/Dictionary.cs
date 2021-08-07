using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTusks
{
    class Dictionary
    {
        Word[] words;
        public Dictionary()
        {
            words = new Word[]
            {
                new Word("red", "красный"),
                new Word("blue", "синий"),
                new Word("green", "зелёный")
            };
        }
        public Word this [int index]
        {
            get
            {
                return words[index];
            }
            set
            {
                words[index] = value;
            }
        }

        public string this[string propName]
        {
            get
            {
                Word word = null;
                foreach (Word w in words)
                {
                    if (w.Source == propName)
                    {
                        word = w;
                        break;
                    }
                }
                return word.Target;
            }

            set
            {
                foreach (Word w in words)
                {
                    if (w.Source == propName)
                    {
                        w.Target = value;
                    }
                }
            }
        }
    }
}
