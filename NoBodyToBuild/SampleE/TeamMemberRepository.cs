using System;
using System.Collections.Generic;

namespace NoBodyToBuild.SampleE {
  public class TeamMemberRepository : ITeamMemberRepository {
    readonly Dictionary<TeamMemberId, TeamMember> _storage;

    public TeamMemberRepository(Dictionary<TeamMemberId, TeamMember> storage) {
      if (storage == null) throw new ArgumentNullException("storage");
      _storage = storage;
    }

    public TeamMember Get(TeamMemberId id) {
      return _storage[id];
    }
  }
}