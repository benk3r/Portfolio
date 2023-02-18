using System.Diagnostics;

namespace Tools
{
  public class MathHelper
  {
    #region Arithmetic

    /// <param name="number"></param>
    /// <returns>bool representing if the number is odd.</returns>
    public static bool IsOdd(long number)
    {
      return (number % 2 == 0);
    }

    #endregion Arithmetic

    #region Trigonometry

    public static double RadiansToDegrees(double radians)
    {
      return (180 / Math.PI) * radians;
    }

    /// <summary>
    /// Uses the law of cosines to find the angle gamma(γ) between 'a' and 'b' for a triangle.
    /// </summary>
    /// <returns>The measure of the angle gamma(γ) between 'a' and 'b' in radians.</returns>
    public static double LawOfCosinesForGamma(double a, double b, double c)
    {
      return Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2))/(2 * a * b));
    }

    #endregion Trigonometry
  }
}