using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Example.UnitTests
{
    [TestFixture]
    public class UtilsTests_Good
    {
        [Test]
        public void SortAndFilterDocuments_BasicSortAndFilter_ListHas3And2()
        {
            List<ScoredDocument> documents = new List<ScoredDocument>();
            AddScoredDocument(documents, -5.0);
            AddScoredDocument(documents, 82);
            AddScoredDocument(documents, 99);
            AddScoredDocument(documents, -9999.7);
            AddScoredDocument(documents, 60);

            Utils.SortAndFilterDocuments(documents);
            
            Assert.Multiple(() =>
            {
                Assert.AreEqual(3, documents.Count);
                Assert.AreEqual(99, documents[0].Score);
                Assert.AreEqual(82, documents[1].Score);
                Assert.AreEqual(60, documents[2].Score);
            });
        }

        private void AddScoredDocument(List<ScoredDocument> aDocuments, double aScore)
        {
            ScoredDocument doc = new ScoredDocument();
            doc.Name = "Dummy";
            doc.Score = aScore;
            aDocuments.Add(doc);
        }
    }
}
