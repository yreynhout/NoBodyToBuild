using System;

namespace NoBodyToBuild.SampleA1 {
  public class TeamMember {
    readonly TeamId _teamId;
    readonly TeamMemberId _teamMemberId;
    readonly DateTime _joinDate;

    public TeamMember(TeamId teamId, TeamMemberId teamMemberId, DateTime joinDate) {
      _teamId = teamId;
      _teamMemberId = teamMemberId;
      _joinDate = joinDate;
    }

    public void AppointAsChairmanOf(Team team) {
      Enforce.That(team.HasMember(_teamMemberId), Sorry.NotPartOfTheTeam);
      Enforce.That(IsMemberSinceAtLeastTwoYears(), Sorry.NotMemberSinceAtLeastTwoYears);
      team.SetChairman(_teamMemberId);
    }

    bool IsMemberSinceAtLeastTwoYears() {
      return _joinDate.AddYears(2) <= DateTime.Today;
    }
  }
}