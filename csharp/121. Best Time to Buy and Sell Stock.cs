/**
 * Say you have an array for which the ith element is the price of a given stock on day i.
 * 
 * If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the stock), 
 * design an algorithm to find the maximum profit.
 * 
 * Example 1:
 * 	Input: [7, 1, 5, 3, 6, 4]
 * 	Output: 5
 * 
 * 	max. difference = 6-1 = 5 (not 7-1 = 6, as selling price needs to be larger than buying price)
 * Example 2:
 * 	Input: [7, 6, 4, 3, 1]
 * 	Output: 0
 * 
 * 	In this case, no transaction is done, i.e. max profit = 0.
 */
 
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length == 0)
            return 0;
        int buy = prices[0];
        int profit = 0, max_profit = 0;
        for (int i=1; i < prices.Length; i++)
        {
            profit = prices[i] - buy;
            if (profit > max_profit)
            {
                max_profit = profit;
            }
            if (prices[i] < buy)
            {
                buy = prices[i];
            }
        }
        return max_profit;
    }
}