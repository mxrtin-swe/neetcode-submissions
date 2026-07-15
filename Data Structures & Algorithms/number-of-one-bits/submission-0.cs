public class Solution {
    public int HammingWeight(uint n) {
        // &&
        // ^
        // <<
        // >>
        int bitCount = 32;
        uint count = 0;

        for (int i = 0; i < bitCount; i++) {
            uint cur = n & 1;
            count = count + cur;
            n = n >> 1;
        }
        return (int)count;
    }
}
