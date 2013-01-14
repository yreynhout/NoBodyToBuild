namespace NoBodyToBuild.SampleC {
  public class TeamApplicationService {
    readonly IMakeChairmanService _service;

    public TeamApplicationService(IMakeChairmanService service) {
      _service = service;
    }

    public void When(MakeChairmanRequest request) {
      _service.MakeChairman(
        new TeamId(request.TeamId), 
        new TeamMemberId(request.TeamMemberId));
    }
  }
}