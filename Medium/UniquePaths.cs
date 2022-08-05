namespace UniquePaths
{
    public class Solution {
        public int UniquePaths(int m, int n) {
            if(m==1||n==1)
                return 1;
            --m;
            --n;
            ulong ans = 1;
            ulong deR = (ulong)m+1;
            ulong deD = 1;

            while(n-->0){
                ans*=deR;
                ans/=deD;
                deR++;
                deD++;
            }
            return (int)ans;
        }
    }
}
