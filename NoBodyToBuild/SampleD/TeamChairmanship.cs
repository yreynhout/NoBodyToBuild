using System;

namespace NoBodyToBuild.SampleD {
  public class TeamChairmanship {
    readonly TeamId _teamId;
    readonly TeamMemberId _teamMemberId;
    readonly DateTime _starting;

    public TeamChairmanship(TeamId teamId, TeamMemberId teamMemberId, DateTime starting) {
      _teamId = teamId;
      _teamMemberId = teamMemberId;
      _starting = starting;
    }
  }
}