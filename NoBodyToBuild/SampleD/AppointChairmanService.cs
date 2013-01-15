namespace NoBodyToBuild.SampleD {
  public class AppointChairmanService : IAppointChairmanService {
    readonly ITeamRepository _teamRepository;
    readonly ITeamMemberRepository _teamMemberRepository;
    readonly ITeamChairmanshipRepository _teamChairmanshipRepository;

    public AppointChairmanService(ITeamRepository teamRepository, ITeamMemberRepository teamMemberRepository, ITeamChairmanshipRepository teamChairmanshipRepository) {
      _teamRepository = teamRepository;
      _teamMemberRepository = teamMemberRepository;
      _teamChairmanshipRepository = teamChairmanshipRepository;
    }

    public void AppointChairman(TeamId teamId, TeamMemberId teamMemberId) {
      var team = _teamRepository.Get(teamId);
      var teamMember = _teamMemberRepository.Get(teamMemberId);

      var chairmanship = team.AppointChairman(teamMember);
      _teamChairmanshipRepository.Add(chairmanship);
    }
  }
}