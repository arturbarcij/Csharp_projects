using Library;
using NUnit.Framework;
using PersonNS;
using System;

namespace Tests {
    [TestFixture]
    public class Test {
        [SetUp]
        public void Init() {
            gen = new Generator();
        }

        private Generator gen;

        
        // public void DummyTest() {
        //     Assert.AreEqual(1, 1);
        // }
        [Test]
        public void TestTooLow() {
                IComparable[] array1 = gen.NextArray(10,10);
                var res = Search.Binary(array1,-1);
                Assert.AreEqual(res,-1);
            }

        [Test]
        public void TestTooHigh() {
            IComparable[] array2 = gen.NextArray(10,10);
            var res1 = Search.Binary(array2,10);
            Assert.AreEqual(res1,-1);
        }

        [Test]
        public void TestElement() {
            IComparable[] array012 = new IComparable[]{0,1,2};
                var res2 = Search.Binary(array012,1);
                Assert.AreEqual(res2,1);
        }

        [Test]
        public void TestEmptyArray() {
            IComparable[] emptyarr = gen.NextArray(0,1);
            for (int i = -100; i < 101; i++) {
                Assert.AreEqual(Search.Binary(emptyarr,i), -1);
            }
        }

        [Test]
        public void TestNegArray() {
            IComparable[] arrayTestNeg = new IComparable[]{0,-1,-2};
                var res2 = Search.Binary(arrayTestNeg,1);
                Assert.AreEqual(res2,-1);
        }

        // [Test]
        // public void TestPerson() {
        //     Person p0 = new Person ("p0",20);
        //     Person p1 = new Person ("p1",20);
        //     Person[] arrPerson = new Person {p0,p1};
        //         var res2 = Search.Binary(arrPerson,Person);
        //         Assert.AreEqual(arrPerson,Person);
        // }



        
    }
}
