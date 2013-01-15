using System;
using System.Collections.Generic;

namespace NoBodyToBuild.SampleD {
  public class TeamChairmanshipRepository : ITeamChairmanshipRepository {
    readonly List<TeamChairmanship> _storage;

    public TeamChairmanshipRepository(List<TeamChairmanship> storage) {
      if (storage == null) throw new ArgumentNullException("storage");
      _storage = storage;
    }

    public void Add(TeamChairmanship chairmanship) {
      _storage.Add(chairmanship);
    }
  }
}