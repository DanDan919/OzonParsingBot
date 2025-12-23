using System.IO;

namespace Utils
{
    public static class State
    {
        private const string FilePath = "ozon_last_checked_id.txt";

        public static long ReadLastCheckedId()
        {
            if (!File.Exists(FilePath))
                return 1;

            var text = File.ReadAllText(FilePath);
            return long.TryParse(text, out var id) ? id : 1;
        }

        public static void SaveLastCheckedId(long id)
        {
            File.WriteAllText(FilePath, id.ToString());
        }
    }
}