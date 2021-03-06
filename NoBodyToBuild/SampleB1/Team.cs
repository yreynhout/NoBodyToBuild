﻿namespace NoBodyToBuild.SampleB1 {
  public class Team {
    readonly TeamId _teamId;
    TeamMemberId _chairman;

    public Team(TeamId teamId) {
      _teamId = teamId;
    }

    public void AppointAsChairman(TeamMember member) {
      Enforce.That(member.IsPartOf(_teamId), Sorry.NotPartOfTheTeam);
      Enforce.That(member.IsMemberSinceAtLeastTwoYears(), Sorry.NotMemberSinceAtLeastTwoYears);
      _chairman = member.TeamMemberId;
    }
  }
}
