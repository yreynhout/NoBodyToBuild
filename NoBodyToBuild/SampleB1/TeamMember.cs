using System;

namespace NoBodyToBuild.SampleB1 {
  public class TeamMember {
    readonly TeamId _teamId;
    readonly TeamMemberId _teamMemberId;
    readonly DateTime _joinDate;

    public TeamMember(TeamId teamId, TeamMemberId teamMemberId, DateTime joinDate) {
      _teamId = teamId;
      _teamMemberId = teamMemberId;
      _joinDate = joinDate;
    }

    internal TeamMemberId TeamMemberId {
      get { return _teamMemberId; }
    }

    internal bool IsPartOf(TeamId teamId) {
      return _teamId.Equals(teamId);
    }

    internal bool IsMemberSinceAtLeastTwoYears() {
      return _joinDate.AddYears(2) <= DateTime.Today;
    }
  }
}