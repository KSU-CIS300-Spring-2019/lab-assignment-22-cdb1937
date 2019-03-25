using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class TrieWithOneChild : ITrie
    {
        /// <summary>
        /// end of the word
        /// </summary>
        private bool _EmptyString;
        /// <summary>
        /// letter
        /// </summary>
        private char label;
        /// <summary>
        /// child of the trie tree
        /// </summary>
        private ITrie child;
        /// <summary>
        /// adds the given string to the trie
        /// </summary>
        /// <param name="s">word to add</param>
        /// <returns>the updated trie</returns>
        public ITrie Add(string s)
        {
            if (s == "")
            {
                _EmptyString = true;
            }
            else
            {
                if (s[0] < 'a' || s[0] > 'z')
                {
                    throw new ArgumentException();
                }
                if (s[0] == label)
                {
                    child = child.Add(s.Substring(1));
                }
                else
                {
                    return new TrieWithManyChildren(s, _EmptyString, label, child);
                }
            }
            return this;
        }
        /// <summary>
        /// determines if the given word is in the trie
        /// </summary>
        /// <param name="s">word to find</param>
        /// <returns>bool representing if the given word is in the trie</returns>
        public bool Contains(string s)
        {
            if (s == "")
            {
                return _EmptyString;
            }
            if(s[0] == label)
            {
                return child.Contains(s.Substring(1));
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// constructor for a single child trie
        /// </summary>
        /// <param name="s">string to add</param>
        /// <param name="hasEmpty">end of word</param>
        public TrieWithOneChild(string s, bool hasEmpty)
        {
            if (s == null || s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }
            _EmptyString = hasEmpty;
            label = s[0];
            child = new TrieWithNoChildren().Add(s.Substring(1));
        }

    }
}
