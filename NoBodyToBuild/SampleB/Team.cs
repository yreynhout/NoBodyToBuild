namespace NoBodyToBuild.SampleB {
  public class Team {
    readonly TeamId _teamId;

    public Team(TeamId teamId) {
      _teamId = teamId;
    }

    public void MakeMemberChairman(TeamMember member) {
      Enforce.That(member.IsPartOf(_teamId), Sorry.NotPartOfTheTeam);
    }
  }
}
