namespace NetTopologySuite
{
    #region Intermediate-Only

    public abstract class GeographyCurve : Geography
    {
        public sealed override double Area => 0;
    }

    public abstract class GeographySurface : Geography
    {
        public sealed override int NumCurves => 0;
    }

    public abstract class GeographyMultiCurve : GeographyCollection { }

    public abstract class GeographyMultiSurface : GeographyCollection { }

    #endregion

    #region Instantiable

    public abstract class GeographyPoint : Geography
    {
        public sealed override double Area => 0;

        public sealed override int NumCurves => 0;
    }

    public abstract class GeographyLineString : GeographyCurve { }

    public abstract class GeographyCircularString : GeographyCurve { }

    public abstract class GeographyCompoundCurve : GeographyCurve { }

    public abstract class GeographyPolygon : GeographySurface { }

    // TODO: GeographyPolygon or Geography?
    public abstract class FullGlobe : GeographyPolygon { }

    public abstract class GeographyCurvePolygon : GeographySurface { }

    public abstract class GeographyCollection : Geography
    {
        public sealed override int NumCurves => 0;
    }

    public abstract class GeographyMultiPoint : GeographyCollection { }

    public abstract class GeographyMultiLineString : GeographyMultiCurve { }

    public abstract class GeographyMultiPolygon : GeographyMultiSurface { }

    #endregion
}
