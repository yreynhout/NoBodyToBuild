namespace NoBodyToBuild.SampleE {
  public class AppointChairmanService : IAppointChairmanService {
    readonly ITeamRepository _teamRepository;
    readonly ITeamMemberRepository _teamMemberRepository;

    public AppointChairmanService(ITeamRepository teamRepository, ITeamMemberRepository teamMemberRepository) {
      _teamRepository = teamRepository;
      _teamMemberRepository = teamMemberRepository;
    }

    public void AppointChairman(TeamId teamId, TeamMemberId teamMemberId) {
      var team = _teamRepository.Get(teamId);
      var teamMember = _teamMemberRepository.Get(teamMemberId);

      teamMember.MustBePartOfTheTeam(team.Id);
      teamMember.MustBeAMemberForAtLeastTwoYears();
      
      team.SetNewChairman(teamMember.Id);
    }
  }
}