public partial class Solution {
    public int FindComplement(int num) {
        int mask = ~0;
        while ((num & mask) != 0) {
            mask <<= 1;
        }
        
        return ~mask & ~num;
    }
}