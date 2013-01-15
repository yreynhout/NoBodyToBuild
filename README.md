NoBodyToBuild
=============

Imagine a team of *gasp* body builders that has to appoint a team member as the new chairman. The rule is: Only members of the team can become chairman.

SampleA1/A2/B demonstrate appointing a member as the chairman using an application service that orchestrates the collaboration of a Team object and a TeamMember object.

SampleC demonstrates the use of application and domain service, but this time putting the rule in the domain service and exposing more state on the Team/TeamMember object.

SampleD recognizes the temporal nature of the chairmanship and turns it into an explicit concept, using the collaboration of a Team object and a TeamMember object as factory.

The question is, regardless of this example being absurdly trivial, why would you pick one or the other from an

- encapsulation perspective
- information hiding perspective
- modeling perspective
- language perspective

