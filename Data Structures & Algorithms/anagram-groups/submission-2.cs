public class Solution {
    private string MakeHash(string str) {
        char[] hash = new char[26];
        foreach(var character in str) {
            var index = character - 'a';
            hash[index]++;
        }
        return new string(hash);
    }
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> result = new();


        foreach(var str in strs) {
            var key = MakeHash(str);
            if(result.TryGetValue(key, out var strList) == false) {
                strList = new List<string>();
                result.Add(key, strList);
            }
            strList.Add(str);
        }

        
        return result.Values.ToList();
    }
}
