using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using GeoAPI.Geometries;
using Moq;
using NUnit.Framework;

namespace NetTopologySuite
{
    public sealed class GeographyTests
    {
        [Test]
        public void SpatialReferenceIdentifierShouldYieldGivenValue()
        {
            int srid = TestContext.CurrentContext.Random.Next();
            var sut = new Mock<Geography>(srid).Object;
            Assert.That(sut.SpatialReferenceIdentifier, Is.EqualTo(srid));
        }

        [Test]
        public void UnimplementedMethodsShouldThrow()
        {
            int srid = TestContext.CurrentContext.Random.Next();
            var sut = new Mock<Geography>(srid) { CallBase = true }.Object;
            TestDelegate[] unimplementedMethods =
            {
                () => Assert.IsNull(Geography.Load(default(Stream), default)),
                () => Assert.IsNull(Geography.Load(default(ReadOnlySpan<byte>), default)),
                () => Assert.IsNull(Geography.Read(default, default)),
                () => Assert.IsNull(Geography.Parse(default, default)),
                () => Assert.IsNull(Geography.Parse(default, default, default)),
                () => Assert.IsNull(sut.Dimension),
                () => Assert.IsNull(sut.IsClosed),
                () => Assert.IsNull(sut.IsEmpty),
                () => Assert.IsNull(sut.IsValid),
                () => Assert.IsNull(sut.Length),
                () => Assert.IsNull(sut.NumGeometries),
                () => Assert.IsNull(sut.NumCurves),
                () => Assert.IsNull(sut.NumPoints),
                () => Assert.IsNull(sut.Area),
                () => Assert.IsNull(sut.AsBinary()),
                () => Assert.IsNull(sut.AsText()),
                () => Assert.IsNull(sut.BufferWithCurves(default)),
                () => Assert.IsNull(sut.Buffer(default, default, default)),
                () => Assert.IsNull(sut.ConvexHull()),
                () => Assert.IsNull(sut.GetCurveN(default)),
                () => Assert.IsNull(sut.CurveToLine()),
                () => Assert.IsNull(sut.Difference(default)),
                () => Assert.IsNull(sut.Distance(default)),
                () => Assert.IsNull(sut.GetGeometryN(default)),
                () => Assert.IsNull(sut.Intersection(default)),
                () => Assert.IsNull(sut.GetPointN(default)),
                () => Assert.IsNull(sut.SymmetricDifference(default)),
                () => Assert.IsNull(sut.Union(default)),
            };
            Assert.That(unimplementedMethods, Is.All.Matches(Throws.InstanceOf<NotImplementedException>()));
        }

        [Test]
        public void StartPointShouldYieldFirstPoint()
        {
            var expected = Mock.Of<Geography>();
            var sut = Mock.Of<Geography>(x => x.GetPointN(0) == expected);
            Assert.That(sut.StartPoint, Is.EqualTo(expected));
        }

        [Test]
        public void EndpointShouldYieldLastPoint()
        {
            int numPoints = TestContext.CurrentContext.Random.Next();
            var expected = Mock.Of<Geography>();
            var sut = Mock.Of<Geography>(x => x.NumPoints == numPoints && x.GetPointN(numPoints - 1) == expected);
            Assert.That(sut.Endpoint, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsShouldUseRelate()
        {
            var other = Mock.Of<Geography>();
            var sut = Mock.Of<Geography>(x => x.Relate(other) == new IntersectionMatrix("20FF10FF2"));
            Mock.Get(sut).CallBase = true;
            Assert.That(sut.Contains(other), Is.True);
        }

        [Test]
        public void DisjointShouldUseRelate()
        {
            var other = Mock.Of<Geography>();
            var sut = Mock.Of<Geography>(x => x.Relate(other) == new IntersectionMatrix("FF2FF1222"));
            Mock.Get(sut).CallBase = true;
            Assert.That(sut.Disjoint(other), Is.True);
        }

        [Test]
        public void EqualsTopologicallyShouldUseRelate()
        {
            var other = Mock.Of<Geography>();
            var sut = Mock.Of<Geography>(x => x.Relate(other) == new IntersectionMatrix("10FFFFFF2"));
            Mock.Get(sut).CallBase = true;
            Assert.That(sut.EqualsTopologically(other), Is.True);
        }

        [Test]
        public void IntersectsShouldUseRelate()
        {
            var other = Mock.Of<Geography>();
            var sut = Mock.Of<Geography>(x => x.Relate(other) == new IntersectionMatrix("F1FFFFFF2"));
            Mock.Get(sut).CallBase = true;
            Assert.That(sut.Intersects(other), Is.True);
        }

        [Test]
        public void OverlapsShouldUseRelate()
        {
            var other = Mock.Of<Geography>();
            var sut = Mock.Of<Geography>(x => x.Dimension == Dimension.Point && x.Relate(other) == new IntersectionMatrix("000FFF0F2"));
            Mock.Get(sut).CallBase = true;
            Assert.That(sut.Overlaps(other), Is.True);
        }

        [Test]
        public void WithinShouldUseRelate()
        {
            var other = Mock.Of<Geography>();
            var sut = Mock.Of<Geography>(x => x.Relate(other) == new IntersectionMatrix("2FF22F122"));
            Mock.Get(sut).CallBase = true;
            Assert.That(sut.Within(other), Is.True);
        }

        [Test]
        public void BufferShouldPassDefaultParameters()
        {
            double distance1 = TestContext.CurrentContext.Random.Next(1000);
            double distance2 = -TestContext.CurrentContext.Random.Next(1000);
            var expected1 = Mock.Of<Geography>();
            var expected2 = Mock.Of<Geography>();
            var sut = Mock.Of<Geography>(x => x.Buffer(distance1, distance1 * 0.001, false) == expected1 &&
                                              x.Buffer(distance2, distance2 * -0.001, false) == expected2);
            Mock.Get(sut).CallBase = true;
            Assert.That(sut.Buffer(distance1), Is.EqualTo(expected1));
            Assert.That(sut.Buffer(distance2), Is.EqualTo(expected2));
        }

        [Test]
        public void ToStringShouldUseAsText()
        {
            string expected = TestContext.CurrentContext.Random.GetString(20);
            var sut = Mock.Of<Geography>(x => x.AsText() == expected);
            Mock.Get(sut).CallBase = true;
            Assert.That(sut.ToString(), Is.EqualTo(expected));
        }
    }
}
