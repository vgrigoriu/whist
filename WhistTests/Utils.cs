using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WhistTests
{
    public static class Utils
    {
        public static void AssertEquivalent<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            var expectedEnumerator = expected.GetEnumerator();
            var actualEnumerator = actual.GetEnumerator();
            bool expectedNotDone = expectedEnumerator.MoveNext();
            bool actualNotDone = actualEnumerator.MoveNext();
            while (expectedNotDone && actualNotDone)
            {
                Assert.AreEqual(expectedEnumerator.Current, actualEnumerator.Current);
                expectedNotDone = expectedEnumerator.MoveNext();
                actualNotDone = actualEnumerator.MoveNext();
            }

            Assert.IsFalse(expectedNotDone || actualNotDone);
        }
    }
}
