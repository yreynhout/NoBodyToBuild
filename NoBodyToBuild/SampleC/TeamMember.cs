namespace NoBodyToBuild.SampleC {
  public class TeamMember {
    readonly TeamId _teamId;
    readonly TeamMemberId _id;

    public TeamMember(TeamId teamId, TeamMemberId id) {
      _teamId = teamId;
      _id = id;
    }

    public TeamMemberId Id {
      get { return _id; }
    }

    public bool IsPartOf(TeamId teamId) {
      return _teamId.Equals(teamId);
    }
  }
}