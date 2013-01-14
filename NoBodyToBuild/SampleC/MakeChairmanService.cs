namespace NoBodyToBuild.SampleC {
  public class MakeChairmanService : IMakeChairmanService {
    readonly ITeamRepository _teamRepository;
    readonly ITeamMemberRepository _teamMemberRepository;

    public MakeChairmanService(ITeamRepository teamRepository, ITeamMemberRepository teamMemberRepository) {
      _teamRepository = teamRepository;
      _teamMemberRepository = teamMemberRepository;
    }

    public void MakeChairman(TeamId teamId, TeamMemberId teamMemberId) {
      var team = _teamRepository.Get(teamId);
      var teamMember = _teamMemberRepository.Get(teamMemberId);

      Enforce.That(teamMember.IsPartOf(team.Id), Sorry.NotPartOfTheTeam);
      team.SetNewChairman(teamMember.Id);
    }
  }
}