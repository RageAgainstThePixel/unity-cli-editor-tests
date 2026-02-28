using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace PlayMode.Tests
{
    /// <summary>
    /// PlayMode test that intentionally fails to generate real test failure output.
    /// </summary>
    [Category("Failing")]
    public class PlaymodeTestsErrors
    {
        [UnityTest]
        public IEnumerator FailsPlaymodeSuite()
        {
            yield return null;
            Assert.Fail("Intentional playmode failure for test matrix coverage.");
        }
    }
}
