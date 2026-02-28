using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace PlayMode.Tests
{
    /// <summary>
    /// PlayMode test that is skipped for test matrix and summary table coverage.
    /// </summary>
    [Category("Skipped")]
    public class PlaymodeTestsSkipped
    {
        [UnityTest]
        [Ignore("Intentional playmode skip")]
        public IEnumerator SkippedPlaymodeSuite()
        {
            yield return null;
            Assert.Fail("Should not run");
        }
    }
}
