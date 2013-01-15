namespace NoBodyToBuild {
  public class TeamMemberId {
    public static readonly TeamMemberId NoOne = default(TeamMemberId);

    protected bool Equals(TeamMemberId other) {
      return _value == other._value;
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((TeamMemberId)obj);
    }

    public override int GetHashCode() {
      return _value;
    }

    readonly int _value;

    public TeamMemberId(int value) {
      _value = value;
    }
  }
}