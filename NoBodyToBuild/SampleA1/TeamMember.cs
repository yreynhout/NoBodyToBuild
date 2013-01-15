namespace NoBodyToBuild.SampleA1 {
  public class TeamMember {
    readonly TeamId _teamId;
    readonly TeamMemberId _teamMemberId;

    public TeamMember(TeamId teamId, TeamMemberId teamMemberId) {
      _teamId = teamId;
      _teamMemberId = teamMemberId;
    }

    public void AppointChairmanOf(Team team) {
      Enforce.That(team.HasMember(_teamMemberId), Sorry.NotPartOfTheTeam);
      team.SetChairman(_teamMemberId);
    }
  }
}