namespace NetTopologySuite
{
    #region Intermediate-Only

    public abstract class GeographyCurve : Geography { }

    public abstract class GeographySurface : Geography { }

    public abstract class GeographyMultiCurve : GeographyCollection { }

    public abstract class GeographyMultiSurface : GeographyCollection { }

    #endregion

    #region Instantiable

    public abstract class FullGlobe : Geography { }

    public abstract class GeographyPoint : Geography { }

    public abstract class GeographyLineString : GeographyCurve { }

    public abstract class GeographyCircularString : GeographyCurve { }

    public abstract class GeographyCompoundCurve : GeographyCurve { }

    public abstract class GeographyPolygon : GeographySurface { }

    public abstract class GeographyCurvePolygon : GeographySurface { }

    public abstract class GeographyCollection : Geography { }

    public abstract class GeographyMultiPoint : GeographyCollection { }

    public abstract class GeographyMultiLineString : GeographyMultiCurve { }

    public abstract class GeographyMultiPolygon : GeographyMultiSurface { }

    #endregion
}
