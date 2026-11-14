public class Solution 
{
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
        int count = 0;

        for (int i = 0; i < flowerbed.Length; i++)
        {

        int next = 0;
        
        if ((i + 1) < flowerbed.Length)
        {
            next = flowerbed[i+1];
        }

        int previous = 0;

        if ((i - 1) >= 0)
        {
            previous = flowerbed[i-1];
        }

        int current = flowerbed[i];

        if (current == 0 && previous == 0 && next == 0)
            {
                count++;
                i++;
            }
        if (n <= count)
        {
            break;
        }
        }
        if (n <= count)
        {
            return true;
        }
        return false;
    }
}