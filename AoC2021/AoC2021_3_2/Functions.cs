namespace AoC2021_3_2
{
    internal static  class Functions
    {
        public static List<string> Reduce(List<string> input, int bit, int type)
        {

            var c = (type == 1) ? CommonChar(input, bit) : LeastChar(input, bit);
            return input.Where(x => x[bit] == c).ToList();
        }

        public static char CommonChar(List<string> input,int bit)
        {
            int ones = 0;
            int zeros = 0;
            
            foreach (var line in input)
            {
                if (line[bit] == '1') ones++;
                if (line[bit] == '0') zeros++;
            }

            return ones>=zeros ? '1' : '0';  
        }

        public static char LeastChar(List<string> input, int bit)
        {
            int ones = 0;
            int zeros = 0;

            foreach (var line in input)
            {
                if (line[bit] == '1') ones++;
                if (line[bit] == '0') zeros++;
            }

            return ones < zeros ? '1' : '0';
        }


        public static int ToInt(string line)
        {
            int result = 0;
            var l = line.Length;
            for(int i = 0;i<l;i++)
            {
                if (line[i] == '1') result += 1 << (l - i - 1);
            }
            return result;
        }


    }
}