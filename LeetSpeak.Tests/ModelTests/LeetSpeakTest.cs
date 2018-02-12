using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTest
  {
    [TestMethod]
    public void IsLeetSpeak_kIsk_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("k", testLeetSpeak.Translate("k"));
    }
    [TestMethod]
    public void IsLeetSpeak_EIs3_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("3", testLeetSpeak.Translate("e"));
    }
    [TestMethod]
    public void IsLeetSpeak_OIs0_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("0", testLeetSpeak.Translate("o"));
    }
    [TestMethod]
    public void IsLeetSpeak_IIs1_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("1", testLeetSpeak.Translate("I"));
    }
    [TestMethod]
    public void IsLeetSpeak_TIs7_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("7", testLeetSpeak.Translate("t"));
    }
    [TestMethod]
    public void IsLeetSpeak_SIsZ_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("szz", testLeetSpeak.Translate("sss"));
    }

    [TestMethod]
    public void IsLeetSpeak_FullSentence_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual(
        "D0n'7 y0u l0v3 7h3z3 's7ring' 3x3rciz3z? 1 d0!",
        testLeetSpeak.Translate(
        "Don't you love these 'string' exercises? I do!"
        )
      );
    }
  }
}
