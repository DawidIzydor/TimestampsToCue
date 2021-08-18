using TimeStampsToCueAbstractions;
using TimestampsToCueLib;
using TimestampsToCueLib.TimestampProcessor;
using Xunit;

namespace TimestampsToCueTests
{
    public class WordExtractorTests
    {
        [Theory]
        [InlineData("Lorem ipsum 0:00 dolor", 13, "0:00")]
        public void ShouldExtractWord(string inputString, int position, string expected)
        {
            var extractor = new WordExtractor();
            var result = extractor.GetWordAtIndex(inputString, position);

            Assert.Equal(expected, result);
        }
    }

    public class TimeStampConverterTests
    {
        private TimeStampFormatConverter _converter = new TimeStampFormatConverter();

        [Theory]
        [InlineData("1:23", "01:23:00")]
        [InlineData("12:34", "12:34:00")]
        [InlineData("1:23:45", "83:45:00")]
        public void ShouldConvert(string input, string expected)
        {
            var result = _converter.ToCueFormat(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("asd")]
        [InlineData("1:234:5")]
        [InlineData("1:23:456")]
        public void ShouldThrow(string input)
        {
            Assert.Throws<TimestampFormatException>(() => _converter.ToCueFormat(input));
        }
    }
}