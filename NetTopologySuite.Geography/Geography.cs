using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

using GeoAPI.Geometries;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]

namespace NetTopologySuite
{
    /// <summary>
    /// Represents a subset of the Earth.
    /// </summary>
    public abstract class Geography
    {
        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        internal Geography()
            : this(0)
        {
        }

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        protected Geography(int spatialReferenceIdentifier) => this.SpatialReferenceIdentifier = spatialReferenceIdentifier;

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
        // [geography]::STGeomFromWKB(WKB_geography, SRID)
        public static Geography Load(Stream wkb, int spatialReferenceIdentifier) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // [geography]::STGeomFromWKB(WKB_geography, SRID)
        public static Geography Load(ReadOnlySpan<byte> wkb, int spatialReferenceIdentifier) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // [geography]::STGeomFromText(geography_tagged_text, SRID)
        public static Geography Read(TextReader wkt, int spatialReferenceIdentifier) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // [geography]::STGeomFromText(geography_tagged_text, SRID)
        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        public static Geography Parse(ReadOnlySpan<char> wkt, int spatialReferenceIdentifier)
        {
            int x = 0;
            x++;
            int y = x;
            throw new NotImplementedException();
            string z = y.ToString();
        }

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // [geography]::STGeomFromText(geography_tagged_text, SRID)
        public static Geography Parse(ReadOnlySpan<byte> wkt, Encoding encoding, int spatialReferenceIdentifier) => throw new NotImplementedException();

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
        // BufferWithCurves(distance)
        public virtual Geography BufferWithCurves(double distance) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // BufferWithTolerance(distance, tolerance, relative)
        public virtual Geography Buffer(double distance, double tolerance, bool toleranceIsRelative) => throw new NotImplementedException();

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

        /// <inheritdoc />
        // (no direct SQL Server equivalent)
        public override string ToString() => this.AsText();
    }
}
