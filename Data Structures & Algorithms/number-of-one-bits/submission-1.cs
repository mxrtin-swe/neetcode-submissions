public class Solution {
    public int HammingWeight(uint n) {
        int bitCount = 32;
        uint count = 0;

        for (int i = 0; i < bitCount; i++) {
            count += (n & 1);
            n >>= 1;
        }
        return (int)count;
    }
}
