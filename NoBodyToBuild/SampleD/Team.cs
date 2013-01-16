using System;

namespace NoBodyToBuild.SampleD {
  public class Team {
    readonly TeamId _id;

    public Team(TeamId teamId) {
      _id = teamId;
    }

    public TeamId Id {
      get { return _id; }
    }

    public TeamChairmanship AppointChairman(TeamMember member) {
      Enforce.That(member.IsPartOf(_id), Sorry.NotPartOfTheTeam);
      Enforce.That(member.IsMemberSinceAtLeastTwoYears(), Sorry.NotMemberSinceAtLeastTwoYears);
      return new TeamChairmanship(_id, member.Id, DateTime.Today);
    }
  }
}
