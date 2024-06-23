namespace PC_SHOP
{
    public abstract class Filter
    {
        private static string stringValue = null;
        private static char[] invalidSymbols = " ,/.\\|\';:\"?><{}[]+=_-!@#$%^&*()".ToCharArray();


        public static string CheckValid(string value)
        {
            Filter.stringValue = value;

            Filter.stringValue = Filter.stringValue.Trim(invalidSymbols);
            Filter.FindInvalidSymbols();

            return Filter.stringValue;
        }

        private static void FindInvalidSymbols()
        {
            int indexes = Filter.stringValue.IndexOfAny(Filter.invalidSymbols);
            switch (indexes)
            {
                case -1:
                    return;
            }
            for (; indexes != -1; indexes = Filter.stringValue.IndexOfAny(Filter.invalidSymbols))
            {
                Filter.stringValue = Filter.stringValue.Remove(indexes, 1);
            }
        }
    }
}
