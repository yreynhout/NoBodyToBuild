namespace NoBodyToBuild.SampleD {
  public class TeamApplicationService {
    readonly IAppointChairmanService _service;

    public TeamApplicationService(IAppointChairmanService service) {
      _service = service;
    }

    public void When(AppointChairmanRequest request) {
      _service.AppointChairman(
        new TeamId(request.TeamId), 
        new TeamMemberId(request.TeamMemberId));
    }
  }
}