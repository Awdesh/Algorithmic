using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class LongestConsecutiveSequence
    {
        //use a hashmap as supporting ds.
        //think the sequence as an interval with [left, right]
        //traverse the array, check if neighbors exist, if yes update the intervals
        //The tricky part(where I got stuck) was how to save the intervals and update them
    //    public int longestConsecutive(int[] num) {
    //    // Start typing your Java solution below
    //    // DO NOT write main() function
    //    if(num.length == 0) return 0;
    //    int max = 1;
    //    HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
    //    for(int d : num){
    //        if(!map.containsKey(d)){
    //            map.put(d, 1);
    //            if(map.containsKey(d-1)) max = Math.max(max, mergeInterval(map, d-1, d));
    //            if(map.containsKey(d+1)) max = Math.max(max, mergeInterval(map, d, d+1));
    //        }
    //    }
    //    return max;
    //}
    //    public int mergeInterval(HashMap<Integer, Integer> map, int left, int right)
    //    {

    //        int leftBorder = left - map.get(left) + 1;
    //        int rightBorder = right + map.get(right) - 1;
    //        int len = rightBorder - leftBorder + 1;
    //        map.put(leftBorder, len);
    //        map.put(rightBorder, len);
    //        return len;
    //    }
    }
}
