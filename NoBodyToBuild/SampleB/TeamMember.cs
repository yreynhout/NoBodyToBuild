namespace NoBodyToBuild.SampleB {
  public class TeamMember {
    readonly TeamId _teamId;
    readonly TeamMemberId _teamMemberId;

    public TeamMember(TeamId teamId, TeamMemberId teamMemberId) {
      _teamId = teamId;
      _teamMemberId = teamMemberId;
    }

    public bool IsPartOf(TeamId teamId) {
      return _teamId.Equals(teamId);
    }
  }
}