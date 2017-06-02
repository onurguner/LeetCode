/**
 * There are N gas stations along a circular route, where the amount of gas at station i is gas[i].
 * 
 * You have a car with an unlimited gas tank and it costs cost[i] of gas to travel from station i to its next station (i+1). 
 * You begin the journey with an empty tank at one of the gas stations.
 * 
 * Return the starting gas station's index if you can travel around the circuit once, otherwise return -1.
 * 
 * Note:
 * The solution is guaranteed to be unique.
 */
 
 
public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int start = 0, totalGas = 0, totalCost = 0, currentGas = 0;
        for (int i=0; i<gas.Length; i++)
        {
            totalGas += gas[i];
            totalCost += cost[i];
            currentGas += gas[i] - cost[i];
            if (currentGas < 0)
            {
                start = i + 1;
                currentGas = 0;
            }
        }
        
        return (totalGas >= totalCost) ? start : -1;
    }
}