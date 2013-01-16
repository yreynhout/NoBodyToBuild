NoBodyToBuild
=============

Imagine a team of *gasp* body builders that has to appoint a team member as the new chairman. The rules are: 

- Only members of the team can become chairman.
- Only members who have been a member for at least two years can become chairman.

SampleA1/A2/B1/B2 demonstrate appointing a member as the chairman using an application service that orchestrates the collaboration of a Team object and a TeamMember object.

SampleC demonstrates the use of application and domain service, but this time putting the rule in the domain service and indirectly exposing more state on the Team/TeamMember object.

SampleD recognizes the temporal nature of the chairmanship and turns it into an explicit concept, using the collaboration of a Team object and a TeamMember object as factory.

At no point is state exposed. The choice boils down to Query methods (CQS style), Double Dispatch methods (Tell Don't Ask style), or Guard methods. 

The questions are, regardless of this example being absurdly trivial, 

- why would you pick one or the other from an 
	- encapsulation perspective?
	- information hiding perspective?
	- modeling perspective?
	- language perspective?
	- maintainability perspective?
	- readability perspective?

- could you motivate why you feel more comfortable with one approach over another or why you think some of them are complete bullocks or would be a bad idea in the long term?

Feel free to fork, add your own preferred approach, play domain expert and tweak where you see fit.
