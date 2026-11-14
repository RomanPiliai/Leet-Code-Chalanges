using System.Linq;
namespace KidsCandies
{
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
    {
        List<bool> result = [];
        for (int i = 0; i < candies.Length; i++)
        {
            
            if ((candies[i] + extraCandies) < candies.Max())
            {
                result.Add(false);
            }
            else
            {
                result.Add(true);
            }
        }
        return result.ToArray();    
    }
}
}