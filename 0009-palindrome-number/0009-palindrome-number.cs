public class Solution {
    public bool IsPalindrome(int x) {
        
        return x.ToString()==new string(x.ToString().ToCharArray().Reverse().ToArray());

    }
}