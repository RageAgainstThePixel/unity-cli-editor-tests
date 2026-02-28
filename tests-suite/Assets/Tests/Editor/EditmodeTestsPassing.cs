using NUnit.Framework;

namespace EditMode.Tests
{
    /// <summary>
    /// EditMode test that passes for test matrix and summary table coverage.
    /// </summary>
    [Category("Passing")]
    public class EditModeTestsPassing
    {
        [Test]
        public void PassesEditModeSuite()
        {
            Assert.Pass("Intentional EditMode pass");
        }
    }
}
