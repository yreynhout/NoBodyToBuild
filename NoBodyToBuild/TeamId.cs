namespace NoBodyToBuild {
  public class TeamId {
    public static readonly TeamId NoTeam = default(TeamId);

    protected bool Equals(TeamId other) {
      return _value == other._value;
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((TeamId) obj);
    }

    public override int GetHashCode() {
      return _value;
    }

    readonly int _value;

    public TeamId(int value) {
      _value = value;
    }
  }
}