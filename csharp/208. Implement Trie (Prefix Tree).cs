/*
Implement a trie with insert, search, and startsWith methods.

Note:
You may assume that all inputs are consist of lowercase letters a-z.
*/

public class TrieNode {
    private const int size = 26;
    private bool isEnd = false;
    private TrieNode[] childrens;
    
    public bool IsEnd {
        get { return isEnd; }
        set { isEnd = value; }
    }
    
    public TrieNode() {
        childrens = new TrieNode[26];
    }
    
    public void set(char ch) {
        if (childrens[ch - 'a'] == null) {
            childrens[ch - 'a'] = new TrieNode();
        }
    }
    
    public TrieNode get(char ch) {
        return childrens[ch - 'a'];
    }
    
    public bool contains(char ch) {
        return (childrens[ch - 'a'] != null);
    }
}

public class Trie {
    TrieNode root = null;
    /** Initialize your data structure here. */
    public Trie() {
        root = new TrieNode();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        TrieNode node = root;
        for (int i=0; i<word.Length; i++) {
            char ch = word[i];
            node.set(ch);
            node = node.get(ch);
        }
        node.IsEnd = true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        TrieNode node = root;
        for (int i=0; i<word.Length; i++) {
            char ch = word[i];
            if (node.contains(ch) == false) {
                return false;
            }
            node = node.get(ch);
        }
        return node.IsEnd;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        TrieNode node = root;
        for (int i=0; i<prefix.Length; i++) {
            char ch = prefix[i];
            if (node.contains(ch) == false) {
                return false;
            }
            node = node.get(ch);
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */