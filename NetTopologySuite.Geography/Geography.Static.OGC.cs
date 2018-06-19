using System;
using System.IO;
using System.Text;

namespace NetTopologySuite
{
    public abstract partial class Geography
    {
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
        public static Geography Parse(ReadOnlySpan<char> wkt, int spatialReferenceIdentifier) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // [geography]::STGeomFromText(geography_tagged_text, SRID)
        public static Geography Parse(ReadOnlySpan<byte> wkt, Encoding encoding, int spatialReferenceIdentifier) => throw new NotImplementedException();
    }
}
