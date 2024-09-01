using System.Text;

namespace integer_to_roman
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            var sb = new StringBuilder();
            int i = 0;
            while (num > 0)
            {
                int digits = num % 10;
                if (i == 0)
                {
                    Update(digits, 'I', 'V', 'X', sb);
                }
                else if (i == 1)
                {
                    Update(digits, 'X', 'L', 'C', sb);
                }
                else if (i == 2)
                {
                    Update(digits, 'C', 'D', 'M', sb);
                }
                else
                {
                    Update(digits, 'M', 'M', 'M', sb);
                }

                i++;
                num /= 10;
            }
            return sb.ToString();
        }

        private void Update(int num, char one, char five, char ten, StringBuilder sb)
        {
            int index = 0;
            if (num <= 3)
            {
                for (int i = 0; i < num; i++) sb.Insert(index++, one);
            }
            else if (num == 4)
            {
                sb.Insert(index++, one); sb.Insert(index++, five);
            }
            else if (5 <= num && num < 9)
            {
                sb.Insert(index++, five);
                for (int i = 0; i < num - 5; i++) sb.Insert(index++, one);
            }
            else
            {
                sb.Insert(index++, one); sb.Insert(index++, ten);
            }
        }
    }
}
