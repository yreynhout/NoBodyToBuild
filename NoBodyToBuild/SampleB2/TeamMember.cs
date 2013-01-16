using System;

namespace NoBodyToBuild.SampleB2 {
  public class TeamMember {
    readonly TeamId _teamId;
    readonly TeamMemberId _teamMemberId;
    readonly DateTime _joinDate;

    public TeamMember(TeamId teamId, TeamMemberId teamMemberId, DateTime joinDate) {
      _teamId = teamId;
      _teamMemberId = teamMemberId;
      _joinDate = joinDate;
    }

    internal TeamMemberId Id {
      get { return _teamMemberId; }
    }

    bool IsPartOf(TeamId teamId) {
      return _teamId.Equals(teamId);
    }

    bool IsMemberSinceAtLeastTwoYears() {
      return _joinDate.AddYears(2) <= DateTime.Today;
    }

    internal void GuardAppointmentAsChairman(TeamId teamId) {
      Enforce.That(IsPartOf(teamId), Sorry.NotPartOfTheTeam);
      Enforce.That(IsMemberSinceAtLeastTwoYears(), Sorry.NotMemberSinceAtLeastTwoYears);
    }
  }
}