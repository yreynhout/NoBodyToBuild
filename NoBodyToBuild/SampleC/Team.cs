namespace NoBodyToBuild.SampleC {
  public class Team {
    readonly TeamId _id;
    
    TeamMemberId _chairmanId;

    public Team(TeamId teamId) {
      _id = teamId;
    }

    public TeamId Id {
      get { return _id; }
    }

    public void SetNewChairman(TeamMemberId id) {
      _chairmanId = id;
    }
  }
}
