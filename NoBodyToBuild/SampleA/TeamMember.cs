namespace NoBodyToBuild.SampleA {
  public class TeamMember {
    readonly TeamId _teamId;
    readonly TeamMemberId _teamMemberId;

    public TeamMember(TeamId teamId, TeamMemberId teamMemberId) {
      _teamId = teamId;
      _teamMemberId = teamMemberId;
    }

    public TeamMemberId TeamMemberId {
      get { return _teamMemberId; }
    }

    public bool IsPartOf(TeamId teamId) {
      return _teamId.Equals(teamId);
    }

    public void MakeChairmanOf(Team team) {
      Enforce.That(team.HasMember(TeamMemberId), Sorry.NotPartOfTheTeam);
      //... carry on
    }
  }
}