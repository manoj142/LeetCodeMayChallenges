public class Solution {
    public int NumJewelsInStones(string J, string S) {
        var charArray=new int[256];
        for(var i=0;i<S.Length;i++){
            charArray[S[i]]++;
        }
        var result=0;
        for(var j=0;j<J.Length;j++){
           result+=charArray[J[j]];
        }
        return result;
    }
}
