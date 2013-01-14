using System.Collections.Generic;

namespace NoBodyToBuild.SampleA {
  public class Team {
    readonly TeamId _teamId;
    readonly List<TeamMemberId> _memberIds;

    public Team(TeamId teamId) {
      _teamId = teamId;
      _memberIds = new List<TeamMemberId>();
    }

    public void AddMember(TeamMemberId memberId) {
      _memberIds.Add(memberId);
    }

    public void MakeChairman(TeamMember member) {
      Enforce.That(member.IsPartOf(_teamId), Sorry.NotPartOfTheTeam);
    }

    public bool HasMember(TeamMemberId teamMemberId) {
      return _memberIds.Contains(teamMemberId);
    }
  }
}