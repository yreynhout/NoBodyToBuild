namespace NoBodyToBuild.SampleA2 {
  public class TeamMember {
    readonly TeamId _teamId;
    readonly TeamMemberId _teamMemberId;

    public TeamMember(TeamId teamId, TeamMemberId teamMemberId) {
      _teamId = teamId;
      _teamMemberId = teamMemberId;
    }

    public void AppointChairmanOf(Team team) {
      team.SetChairman(_teamMemberId);
    }
  }
}