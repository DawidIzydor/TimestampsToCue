using TimeStampsToCueAbstractions;
using TimestampsToCueLib;
using TimestampsToCueLib.TimestampProcessor;
using Xunit;

namespace TimestampsToCueTests
{
    public class ProcessorTests
    {
        private readonly TimeStampFormatConverter _timeStampFormatConverter = new();
        private readonly ColonIndexCalculator _colonIndexCalculator = new();

        private AutoProcessor CreateAutoProcessor()
        {
            return new AutoProcessor(_timeStampFormatConverter, _colonIndexCalculator);
        }

        [Theory]
        [InlineData("")]
        [InlineData("0")]
        [InlineData("00:00:00:00")]
        public void ShouldBreakOnWrongFormat(string wrongFormat)
        {
            var processor = CreateAutoProcessor();

            Assert.Throws<TimestampFormatException>(() => processor.ProcessTimestamp(wrongFormat));
        }

        [Theory]
        [InlineData("0:00 Enchanters - Dragon Age: Inquisition", "00:00:00")]
        [InlineData("1. 0:00 Enchanters - Dragon Age: Inquisition ", "00:00:00")]
        [InlineData("1:24:22  I Am The One - Dragon Age: Inquisition", "84:22:00")]
        [InlineData("36. 1:24:22  I Am The One - Dragon Age: Inquisition", "84:22:00")]
        [InlineData("14. 28:54 The Bannered Mare - TES V: Skyrim", "28:54:00")]
        [InlineData("07. Octopath Traveler - Cobbleston, Nestled in the Hills - 15:02", "15:02:00")]
        [InlineData("28. [TES V] Skyrim - Imperial Throne - 1:15:56", "75:56:00")]
        [InlineData("12. Neverwinter Nights - The Town Of Lonelywood - 29:41", "29:41:00")]
        [InlineData("12. Neverwinter Nights: The Town Of Lonelywood - 29:41", "29:41:00")]
        public void ShouldReturnTimeString(string input, string expected)
        {
            var processor = CreateAutoProcessor();
            var result = processor.ProcessTimestamp(input);

            Assert.Equal(expected, result.Time);
        }

        [Theory]
        [InlineData("0:00 Enchanters - Dragon Age: Inquisition", "Enchanters - Dragon Age: Inquisition")]
        [InlineData("1. 0:00 Enchanters - Dragon Age: Inquisition ", "Enchanters - Dragon Age: Inquisition")]
        [InlineData("1:24:22  I Am The One - Dragon Age: Inquisition", "I Am The One - Dragon Age: Inquisition")]
        [InlineData("36. 1:24:22  I Am The One - Dragon Age: Inquisition", "I Am The One - Dragon Age: Inquisition")]
        [InlineData("14. 28:54 The Bannered Mare - TES V: Skyrim", "The Bannered Mare - TES V: Skyrim")]
        [InlineData("07. Octopath Traveler - Cobbleston, Nestled in the Hills - 15:02", "07. Octopath Traveler - Cobbleston, Nestled in the Hills -")]
        [InlineData("28. [TES V] Skyrim - Imperial Throne - 1:15:56", "28. [TES V] Skyrim - Imperial Throne -")]
        [InlineData("12. Neverwinter Nights - The Town Of Lonelywood - 29:41", "12. Neverwinter Nights - The Town Of Lonelywood -")]
        [InlineData("12. Neverwinter Nights: The Town Of Lonelywood - 29:41", "12. Neverwinter Nights: The Town Of Lonelywood -")]
        public void ShouldReturnTitle(string input, string expected)
        {
            var processor = CreateAutoProcessor();
            var result = processor.ProcessTimestamp(input);

            Assert.Equal(expected, result.Title);
        }
    }
}
