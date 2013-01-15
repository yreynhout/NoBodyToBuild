namespace NoBodyToBuild.SampleB2 {
  public class Team {
    readonly TeamId _teamId;

    TeamMemberId _chairman;

    public Team(TeamId teamId) {
      _teamId = teamId;
    }

    public void AppointChairman(TeamMember member) {
      member.GuardAppointmentAsChairman(_teamId);
      _chairman = member.Id;
    }
  }
}