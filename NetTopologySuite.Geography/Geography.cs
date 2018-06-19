namespace NetTopologySuite
{
    /// <summary>
    /// Represents a subset of the Earth.
    /// </summary>
    public abstract partial class Geography
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

        /// <inheritdoc />
        // ToString()
        public override string ToString() => this.AsText();
    }
}
