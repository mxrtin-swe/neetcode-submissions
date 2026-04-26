public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int currentMax = 0;

        // look at the previous min
        for (int i = 1; i < prices.Length; i++)
        {
            int todaysMaxProfit = prices[i] - minPrice;
            if (todaysMaxProfit > currentMax )
            {
                currentMax = todaysMaxProfit;
            }
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
        }
        return currentMax;
    }
}
