namespace single_element_in_a_sorted_array {
    public class Solution {
        public int SingleNonDuplicate(int[] nums) {
            if (nums.Length == 1) return nums[0];
            int left = 0;
            int right = nums.Length - 1;
            int mid;
            while (left < right) {
                mid = left + (right - left) / 2;
                if (mid % 2 == 0) {
                    if (nums[mid] == nums[mid + 1]) {
                        left = mid + 2;
                    }
                    else {
                        right = mid;
                    }
                }
                else {
                    if (nums[mid] == nums[mid - 1]) {
                        left = mid + 1;
                    }
                    else {
                        right = mid;
                    }
                }
            }

            return nums[left];
        }
    }
}
