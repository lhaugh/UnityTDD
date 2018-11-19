using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

namespace Project.Feature.Tests
{
    public class StandardUserStoreTests {

#region CreateUser()
        [Test]
        public void CreateUser_ReturnsUser_WhenCalled()
        {
            StandardUserStore store = new StandardUserStore();

            IUser result = store.CreateUser();

            Assert.IsTrue(((IUser)result) != null);
        }
#endregion

        [Test]
        public void StandardUserStoreTestsSimplePasses() {
            // Use the Assert class to test conditions.
        }

        // A UnityTest behaves like a coroutine in PlayMode
        // and allows you to yield null to skip a frame in EditMode
        [UnityTest]
        public IEnumerator StandardUserStoreTestsWithEnumeratorPasses() {
            // Use the Assert class to test conditions.
            // yield to skip a frame
            yield return null;
        }
    }
}
