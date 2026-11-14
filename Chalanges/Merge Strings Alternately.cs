using System.Text;

namespace MergeStringsAlternately
{
public class Solution 
{
    public string MergeAlternately(string word1, string word2) 
    {
        var result = new StringBuilder();

        int j = word2.Length;
        int k = word1.Length;

        for (int i = 0; i < word1.Length; i++)
        {
            if(word1.Length == word2.Length)
            {
            result.Append(word1[i]);
            result.Append(word2[i]);
            }
            if (word1.Length > word2.Length)
            {
                result.Append(word1[i]);
                j--;
                if(j >= 0)
                {
                    result.Append(word2[i]);
                } 
            }
            


        }

        if (word1.Length < word2.Length)
            {
                for (int p = 0; p < word2.Length; p++)
                { 
                    
                if(k > 0)
                {
                    result.Append(word1[p]);
                } 
                result.Append(word2[p]);
                k--;
                }
            }

        return result.ToString();
        
    }
}
}