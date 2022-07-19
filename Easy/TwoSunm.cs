using System;

namespace TwoSunm // Note: actual namespace depends on the project name.
{
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {
            // int i = 0, j = 0;
            // while(i < nums.Length){
            //     j = 0;
            //     while(j < nums.Length){
            //         if(i == j){
            //             j++;
            //             continue;
            //         }else if((nums[i] + nums[j]) == target){
            //             return new int[2]{i,j};
            //         }
            //         j++;
            //     }
            //     i++;
            // }
            // return new int [2] {0,0};
            var Dic = new Dictionary<int,int>();
            for(int i = 0; i<nums.Length; i++){
                int first = nums[i];
                int second = target - nums[i];
                if(Dic.ContainsKey(target -nums[i]))
                    return new int[] {i , Dic[target-nums[i]]};
                Dic[nums[i]] = i;
            }
            return new int [2] {0,0};
        }
    }
    // internal class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Solution _Sl = new Solution();
    //         int[] _arr = _Sl.TwoSum(new int[2]{3,3},6);

    //         for (int i = 0; i< _arr.Length; i++){
    //             Console.Write("[");
    //             Console.Write(_arr[i]);
    //             Console.Write(i == _arr.Length?", ":"");
    //             Console.Write("]");
    //         }
    //         Console.WriteLine("Hello World!");
    //     }
    // }
}
