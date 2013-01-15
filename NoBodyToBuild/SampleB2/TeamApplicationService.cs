namespace NoBodyToBuild.SampleB2 {
  public class TeamApplicationService {
    readonly ITeamRepository _teamRepository;
    readonly ITeamMemberRepository _teamMemberRepository;

    public TeamApplicationService(ITeamRepository teamRepository, ITeamMemberRepository teamMemberRepository) {
      _teamRepository = teamRepository;
      _teamMemberRepository = teamMemberRepository;
    }

    public void When(AppointChairmanRequest request) {
      var team = _teamRepository.Get(new TeamId(request.TeamId));
      var teamMember = _teamMemberRepository.Get(new TeamMemberId(request.TeamMemberId));

      team.AppointChairman(teamMember);
    }
  }
}