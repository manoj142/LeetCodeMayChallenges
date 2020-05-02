public class Solution : VersionControl {
    
    public int FirstBadVersion(int n) {
        var badVersion=1;
        var l=1;
        var r=n;
        while(l<=r){
            int mid=l+(r-l)/2;
            if(!IsBadVersion(mid)&&IsBadVersion(mid+1)){
                return mid+1;
            }else if(!IsBadVersion(mid)&&!IsBadVersion(mid-1)&&!IsBadVersion(mid+1)){
                l=mid+1;
            }else{
                r=mid-1;
            }
        }
        return badVersion;
    }
}
