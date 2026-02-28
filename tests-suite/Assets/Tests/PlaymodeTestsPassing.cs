using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace PlayMode.Tests
{
    /// <summary>
    /// PlayMode test that passes for test matrix and summary table coverage.
    /// </summary>
    [Category("Passing")]
    public class PlaymodeTestsPassing
    {
        [UnityTest]
        public IEnumerator PassesPlaymodeSuite()
        {
            yield return null;
            Assert.Pass("Intentional playmode pass");
        }
    }
}
