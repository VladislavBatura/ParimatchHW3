using System.Diagnostics.CodeAnalysis;
using Hw3.Exercise3;
using Xunit;

namespace Hw3.Tests.Exercise3
{
    [SuppressMessage("Naming", "CA1707", MessageId = "Identifiers should not contain underscores")]
    public class ParimatchListTests
    {
        [Fact]
        public void ParimatchList_Tests()
        {
            var parimatchList = new ParimatchList<int>(10);

            parimatchList.Add(45);
            parimatchList.Add(100);
            Assert.Equal(2, parimatchList.Count);
            Assert.Equal(45, parimatchList.GetByIndex(0));
            Assert.Equal(100, parimatchList.GetByIndex(1));

            _ = parimatchList.DeleteAllElements();
            Assert.Equal(0, parimatchList.Count);

            parimatchList.Add(150);
            parimatchList.Add(160);
            parimatchList.Add(170);
            parimatchList.DeleteByIndex(0);
            Assert.Equal(2, parimatchList.Count);

            parimatchList.InsertAt(25, 0);
            Assert.Equal(25, parimatchList.GetByIndex(0));

            Assert.True(parimatchList.Contains(170));
            Assert.False(parimatchList.Contains(111));

            // NOTE: uncomment after implementing index & IEnumerator
            /*
            for (int i = 0; i < parimatchList.Count; i++)
            {
                Assert.Equal(parimatchList[i], parimatchList.GetByIndex(i));
            }
    
            foreach (var element in parimatchList)
            {
                Assert.True(element != 333);
            }
            */
        }
    }
}
