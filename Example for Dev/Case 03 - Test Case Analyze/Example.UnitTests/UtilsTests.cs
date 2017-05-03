using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Example.UnitTests
{
    [TestFixture]
    public class UtilsTests
    {
        [Test]
        public void Test1()
        {
            List<ScoredDocument> documents = new List<ScoredDocument>();

            ScoredDocument doc = new ScoredDocument();
            doc.Name = "Computer";
            doc.Score = -5.0;
            documents.Add(doc);

            ScoredDocument doc1 = new ScoredDocument();
            doc1.Name = "Chinese";
            doc1.Score = 82;
            documents.Add(doc1);

            ScoredDocument doc2 = new ScoredDocument();
            doc2.Name = "Maths";
            doc2.Score = 99;
            documents.Add(doc2);

            ScoredDocument doc3 = new ScoredDocument();
            doc3.Name = "English";
            doc3.Score = -9999.7;
            documents.Add(doc3);

            ScoredDocument doc4 = new ScoredDocument();
            doc4.Name = "Sport";
            doc4.Score = 60;
            documents.Add(doc4);

            Utils.SortAndFilterDocuments(documents);

            Assert.AreEqual(3, documents.Count);
            Assert.AreEqual(99, documents[0].Score);
            Assert.AreEqual(82, documents[1].Score);
            Assert.AreEqual(60, documents[2].Score);
        }
    }
}
