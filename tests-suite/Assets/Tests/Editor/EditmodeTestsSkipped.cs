using NUnit.Framework;

namespace EditMode.Tests
{
    /// <summary>
    /// EditMode test that is skipped for test matrix and summary table coverage.
    /// </summary>
    [Category("Skipped")]
    public class EditModeTestsSkipped
    {
        [Test]
        [Ignore("Intentional EditMode skip")]
        public void SkippedEditModeSuite()
        {
            Assert.Fail("Should not run");
        }
    }
}
