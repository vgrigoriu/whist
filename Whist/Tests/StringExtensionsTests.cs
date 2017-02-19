using WhistCore;
using Xunit;

namespace Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void CanEnumerateSupplementalCharacters()
        {
            var separateCards = "🂫🂸".AsCodePoints();
            Assert.Equal(new[] { "🂫", "🂸" }, separateCards);
        }
    }
}
