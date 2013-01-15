namespace NoBodyToBuild.SampleB2 {
  public class TeamMember {
    readonly TeamId _teamId;
    readonly TeamMemberId _teamMemberId;

    public TeamMember(TeamId teamId, TeamMemberId teamMemberId) {
      _teamId = teamId;
      _teamMemberId = teamMemberId;
    }

    internal TeamMemberId Id {
      get { return _teamMemberId; }
    }

    bool IsPartOf(TeamId teamId) {
      return _teamId.Equals(teamId);
    }

    internal void GuardAppointmentAsChairman(TeamId teamId) {
      Enforce.That(IsPartOf(teamId), Sorry.NotPartOfTheTeam);
    }
  }
}