using NUnit.Framework;

namespace EditMode.Tests
{
    /// <summary>
    /// EditMode test that intentionally fails to produce real test failure output.
    /// </summary>
    [Category("Failing")]
    public class EditModeTestsErrors
    {
        [Test]
        public void FailsEditModeSuite()
        {
            Assert.Fail("Intentional EditMode failure");
        }
    }
}
