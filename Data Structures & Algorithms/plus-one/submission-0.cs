public class Solution {
    public int[] PlusOne(int[] digits) {
        // Regular case; 1234 -> 1235
        // Case; 1239 -> 1240
        // Case; 999 -> 1000
        int size = digits.Length;
        for (int i = size - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        int[] newDigits = new int[size + 1];
        newDigits[0] = 1;
        return newDigits;
    }
}