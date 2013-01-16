using System;

namespace NoBodyToBuild.SampleC {
  public class TeamMember {
    readonly TeamId _teamId;
    readonly TeamMemberId _id;
    readonly DateTime _joinDate;

    public TeamMember(TeamId teamId, TeamMemberId id, DateTime joinDate) {
      _teamId = teamId;
      _id = id;
      _joinDate = joinDate;
    }

    public TeamMemberId Id {
      get { return _id; }
    }

    public bool IsPartOf(TeamId teamId) {
      return _teamId.Equals(teamId);
    }

    public bool IsMemberSinceAtLeastTwoYears() {
      return _joinDate.AddYears(2) <= DateTime.Today;
    }
  }
}