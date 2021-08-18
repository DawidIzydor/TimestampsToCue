namespace TimestampsToCueLib
{
    public class WordExtractor
    {
        public string GetWordAtIndex(string timeStampString, int colonIndex)
        {
            var beginning = timeStampString.LastIndexOf(' ', colonIndex, colonIndex-1)+1;

            var end = timeStampString.IndexOf(' ', colonIndex);
            if (end < 0)
            {
                end = timeStampString.Length;
            }

            return timeStampString.Substring(beginning, end-beginning);
        }
    }
}