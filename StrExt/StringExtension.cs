namespace ExportVocab.StrExt
{
    public static class StringExtension
    {
        public static int GetStableHashCode(string str, int tableSize)
        {
            unchecked
            {
                int hash1 = tableSize;
                int hash2 = hash1;

                for (int i = 0; i < str.Length && str[i] != '\0'; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ str[i];
                    if (i == str.Length - 1 || str[i + 1] == '\0')
                        break;
                    hash2 = ((hash2 << 5) + hash2) ^ str[i + 1];
                }

                return hash1 + (hash2 * 1566083941);
            }
        }

        public static string GetStrVal(string str, string key)
        {
            string strSeq = "";

            string[] subs = str.Split(",;", StringSplitOptions.RemoveEmptyEntries);
            foreach (var sub in subs)
            {
                int temp = sub.IndexOf(key);
                if (temp != -1)
                    strSeq = sub.Substring(0);

            }

            return strSeq;
        }
    }
}
