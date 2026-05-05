public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> first = new();
        foreach(var c in s) {
            if(first.ContainsKey(c) == false) {
                first[c] = 0;
            }
            first[c] += 1;
        }
        foreach(var c in t) {
            if(first.ContainsKey(c) == false) {
                return false;
            }
            first[c] -= 1;
            if(first[c] == 0) {
                first.Remove(c);
            }
        }

        var hasValue = first.Count > 0;
        return !hasValue;
    }
}
