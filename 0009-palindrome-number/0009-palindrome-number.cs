public class Solution {
    public bool IsPalindrome(int x) {
        string ReverseX=new string(x.ToString().ToCharArray().Reverse().ToArray());
        return x.ToString()==ReverseX;

    }
}