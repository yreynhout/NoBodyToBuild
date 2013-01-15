using System;
using System.Collections.Generic;

namespace NoBodyToBuild.SampleA2 {
  public class TeamRepository : ITeamRepository {
    readonly Dictionary<TeamId, Team> _storage;

    public TeamRepository(Dictionary<TeamId, Team> storage) {
      if (storage == null) throw new ArgumentNullException("storage");
      _storage = storage;
    }

    public Team Get(TeamId id) {
      return _storage[id];
    }
  }
}