using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class TrieWithNoChildren : ITrie
    {/// <summary>
    /// end of the word
    /// </summary>
        private bool _EmptyString = false;
        /// <summary>
        /// adds the given word to the trie
        /// </summary>
        /// <param name="s">given word</param>
        /// <returns>updated trie</returns>
        public ITrie Add(string s)
        {
            if (s == "")
            {
                _EmptyString = true;
            }
            else
            {
                return new TrieWithOneChild(s, _EmptyString);
            }
            return this;
        }
        /// <summary>
        /// determines if the given word is in the trie
        /// </summary>
        /// <param name="s">given word</param>
        /// <returns>boolean or true false representing if the given word is found</returns>
        public bool Contains(string s)
        {
            if (s == "")
            {
                return _EmptyString;
            }
            else
            {
                return false;
            }
        }
    }
}
