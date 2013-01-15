namespace NoBodyToBuild.SampleB1 {
  public class TeamMember {
    readonly TeamId _teamId;
    readonly TeamMemberId _teamMemberId;

    public TeamMember(TeamId teamId, TeamMemberId teamMemberId) {
      _teamId = teamId;
      _teamMemberId = teamMemberId;
    }

    internal TeamMemberId TeamMemberId {
      get { return _teamMemberId; }
    }

    public bool IsPartOf(TeamId teamId) {
      return _teamId.Equals(teamId);
    }
  }
}