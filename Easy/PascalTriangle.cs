using System;
using System.Collections;
namespace PascalTriangle
{
    public class Solution {
        public IList<IList<int>> Generate(int numRows) {
            List<IList<int>> ans = new List<IList<int>>(){ new List<int>() { 1 }};
            for(int i = 2; i<=numRows; i++){
                 List<int> _list = new List<int>() { 1 };
                for (int j = 1; j < i - 1; j++)
                    _list.Add(ans[i - 2][j - 1] + ans[i - 2][j]);
                _list.Add(1);
                ans.Add(_list);
            }

            return ans;
        }
    }
}
