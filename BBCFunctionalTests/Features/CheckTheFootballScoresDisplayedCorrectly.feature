Feature: CheckTheFootballScoresDisplayedCorrectly
	In order to avoid the display on the page of the wrong score with which the given football teams played
	I want to compare it with expected

@mytag
Scenario Outline: Check that teams scores displays correctly
	Given I am on Home page
	When I go to the page where football scores and fixtures displays
	And  choose competition <Competition>
	And  choose the period in which the match took place <Period>
	Then the score from which the teams <First team> and <Second team> played should be <Number of goals scored by Thefirst team> <Number of goals scored by The second team>
	And  go to page where the teams <First team> and <Second team> details of match
	Then the names of teams should be as expected <First team> and <Second team>
	Then the score should be <Number of goals scored by Thefirst team> <Number of goals scored by The second team>
 
Examples:
 | Competition           | Period     | First team     | Second team         | Number of goals scored by Thefirst team | Number of goals scored by The second team |
 | Scottish Championship | 2020-02    | Alloa Athletic | Ayr United          | 0                                       | 2                                         |
 | Europa League         | 2020-08    | The New Saints | MSK Zilina          | 3                                       | 1                                         |
 | Scottish League Cup   | 2019-11    | Rangers        | Heart of Midlothian | 3                                       | 0                                         |
 | Womens World Cup      | 2019-07-07 | USA            | Netherlands         | 2                                       | 0                                         |
 | Club World Cup        | 2019-12    | Liverpool      | Flamengo            | 1                                       | 0                                         |