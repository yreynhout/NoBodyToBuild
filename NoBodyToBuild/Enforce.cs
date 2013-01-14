using System;

namespace NoBodyToBuild {
  public static class Enforce {
    public static void That(bool condition, Sorry error) {
      if (!condition)
        throw new InvalidOperationException(error.ToString());
    }
  }
}