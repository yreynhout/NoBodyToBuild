using System.Collections.Generic;

namespace NoBodyToBuild.SampleA1 {
  public class Team {
    readonly TeamId _teamId;
    readonly List<TeamMemberId> _memberIds;

    TeamMemberId _chairman;

    public Team(TeamId teamId) {
      _teamId = teamId;
      _memberIds = new List<TeamMemberId>();
    }

    public void AddMember(TeamMemberId memberId) {
      _memberIds.Add(memberId);
    }

    internal bool HasMember(TeamMemberId teamMemberId) {
      return _memberIds.Contains(teamMemberId);
    }

    internal void SetChairman(TeamMemberId teamMemberId) {
      _chairman = teamMemberId;
    }
  }
}