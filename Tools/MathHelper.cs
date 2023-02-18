using System.Diagnostics;

namespace Tools
{
  public class MathHelper
  {
    #region Trigonometry
    
    public static double RadiansToDegrees(double radians)
    {
      return (180 / Math.PI) * radians;
    }

    /// <summary>
    /// Uses the law of cosines to find the angle between 'a' and 'b' for a triangle.
    /// </summary>
    /// <returns>The measure of the angle between 'a' and 'b' in radians.</returns>
    public static double LawOfCosinesForGamma(double a, double b, double c)
    {
      return Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2))/(2 * a * b));
    }

    #endregion Trigonometry
  }
}