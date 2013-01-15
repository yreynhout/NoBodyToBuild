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

    public TeamChairmanship AppointChairman(TeamMember teamMember) {
      Enforce.That(teamMember.IsPartOf(_id), Sorry.NotPartOfTheTeam);
      return new TeamChairmanship(_id, teamMember.Id, DateTime.Today);
    }
  }
}
