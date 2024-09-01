namespace container_with_most_water {
    public class Solution {
        public int MaxArea(int[] height) {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right) {
                int width = right - left;
                int minHeight = Math.Min(height[left], height[right]);
                maxArea = Math.Max(maxArea, width * minHeight);
                if (height[left] <= height[right]) { left++; }
                else { right--; }
            }
            return maxArea;
        }
    }
}
