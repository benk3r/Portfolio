using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace Tools.Tests
{
  [TestClass]
  public class MathHelperTests
  {
    [TestMethod]
    public void LawOfCosinesForGammaTest()
    {
      Assert.IsTrue(MathHelper.LawOfCosinesForGamma(3, 4, 5) == 1.5707963267948966);
      Assert.IsTrue(MathHelper.LawOfCosinesForGamma(20, 22, 18) == 0.881021326009397);
    }
  }
}
