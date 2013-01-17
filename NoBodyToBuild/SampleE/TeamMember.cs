using System;

namespace NoBodyToBuild.SampleE {
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

    bool IsPartOf(TeamId teamId) {
      return _teamId.Equals(teamId);
    }

    bool IsMemberSinceAtLeastTwoYears() {
      return _joinDate.AddYears(2) <= DateTime.Today;
    }

    public void MustBePartOfTheTeam(TeamId id) {
      Enforce.That(IsPartOf(id), Sorry.NotPartOfTheTeam);
    }

    public void MustBeAMemberForAtLeastTwoYears() {
      Enforce.That(IsMemberSinceAtLeastTwoYears(), Sorry.NotMemberSinceAtLeastTwoYears);
    }
  }
}