using System;
using System.Xml;

namespace NetTopologySuite
{
    public abstract partial class Geography
    {
        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // EnvelopeAngle()
        public virtual double EnvelopeAngle => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // EnvelopeCenter()
        public virtual Geography EnvelopeCenter => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // HasM
        public virtual bool HasM => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // HasZ
        public virtual bool HasZ => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // AsBinaryZM()
        public virtual byte[] AsBinaryZM() => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // AsGml()
        public virtual XmlReader AsGml() => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // AsTextZM
        public virtual string AsTextZM() => throw new NotImplementedException();

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
        // CurveToLineWithTolerance(tolerance, relative)
        public virtual Geography CurveToLineWithTolerance(double tolerance, bool toleranceIsRelative) => throw new NotImplementedException();

        /// <summary>
        /// TODO: xmldoc.
        /// </summary>
        // Filter(other_geography)
        public virtual bool MightIntersect(Geography other) => throw new NotImplementedException();
    }
}
