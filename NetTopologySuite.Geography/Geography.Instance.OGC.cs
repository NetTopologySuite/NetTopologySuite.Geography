using System;
using GeoAPI.Geometries;

namespace NetTopologySuite
{
    public abstract partial class Geography
    {
        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STSrid()
        public int SpatialReferenceIdentifier { get; }

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STDimension()
        public virtual Dimension Dimension => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STGeometryType()
        public abstract string GeometryType { get; }

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STIsClosed()
        public virtual bool IsClosed => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STIsEmpty()
        public virtual bool IsEmpty => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STIsValid()
        public virtual bool IsValid => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STLength()
        public virtual double Length => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STNumGeometries()
        public virtual int NumGeometries => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// TODO: nullable?
        /// </summary>
        // STNumCurves()
        public virtual int NumCurves => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STNumPoints()
        public virtual int NumPoints => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STStartPoint()
        public Geography StartPoint => this.GetPointN(0);

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STEndpoint()
        public Geography Endpoint => this.GetPointN(this.NumPoints - 1);

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STArea()
        public virtual double Area => throw new NotImplementedException();
        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // (no direct SQL Server equivalent)
        public abstract IntersectionMatrix Relate(Geography other);

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STContains(other_geography)
        public virtual bool Contains(Geography other) => this.Relate(other).IsContains();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STDisjoint(other_geography)
        public virtual bool Disjoint(Geography other) => this.Relate(other).IsDisjoint();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STEquals(other_geography)
        public virtual bool EqualsTopologically(Geography other) => this.Relate(other).IsEquals(this.Dimension, other.Dimension);

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STIntersects(other_geography)
        public virtual bool Intersects(Geography other) => this.Relate(other).IsIntersects();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STOverlaps(other_geography)
        public virtual bool Overlaps(Geography other) => this.Relate(other).IsOverlaps(this.Dimension, other.Dimension);

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STWithin(other_geography)
        public virtual bool Within(Geography other) => this.Relate(other).IsWithin();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STAsBinary()
        public virtual byte[] AsBinary() => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STAsText()
        public virtual string AsText() => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STBuffer(distance)
        public Geography Buffer(double distance) => this.Buffer(distance, Math.Abs(distance) * 0.001, toleranceIsRelative: false);

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STConvexHull()
        public virtual Geography ConvexHull() => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STCurveN(n)
        public virtual Geography GetCurveN(int n) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STCurveToLine()
        public virtual Geography CurveToLine() => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STDifference(other_geography)
        public virtual Geography Difference(Geography other) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STDistance(other_geography)
        public virtual double Distance(Geography other) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STGeometryN(expression)
        public virtual Geography GetGeometryN(int n) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STIntersection(other_geography)
        public virtual Geography Intersection(Geography other) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STPointN(expression)
        public virtual Geography GetPointN(int n) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STSymDifference(other_geography)
        public virtual Geography SymmetricDifference(Geography other) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // STUnion(other_geography)
        public virtual Geography Union(Geography other) => throw new NotImplementedException();
    }
}
