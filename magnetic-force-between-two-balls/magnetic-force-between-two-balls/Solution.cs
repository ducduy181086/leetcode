namespace magnetic_force_between_two_balls
{
    public class Solution
    {
        public int MaxDistance(int[] position, int m)
        {
            Array.Sort(position);
            QuickSortArray(position, 0, position.Length - 1);
            int left = 1;
            int right = position[position.Length - 1] - position[0];
            int result = 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (Check(position, m, mid))
                {
                    result = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }

        private static bool Check(int[] position, int m, int min)
        {
            int count = 1;
            int pointerValue = position[0];

            int length = position.Length;
            for (int i = 1; i < length; i++)
            {
                if (position[i] - pointerValue >= min)
                {
                    count++;
                    pointerValue = position[i];
                    if (count == m) { return true; }
                }
            }

            return false;
        }

        private static void QuickSortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSortArray(array, left, pivotIndex - 1);
                QuickSortArray(array, pivotIndex + 1, right);
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (array[i] == array[j]) return;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }
    }
}
