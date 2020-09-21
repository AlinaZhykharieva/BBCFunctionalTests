Feature: CheckTheFootballScoresDisplayedCorrectly
	In order to avoid the display on the page of the wrong score with which the given football teams played
	I want to compare it with expected

@mytag
Scenario: Check that teams scores displays correctly in Scottish Championship
	When I go to the page where football scores and fixtures displays
	And  choose competition "Scottish Championship"
	And  choose the period in which the match took place "2020-02"
	Then the score from which the teams "Alloa" and "Ayr" played should be "0" "2"
	And  go to page where the teams "Alloa" and "Ayr" details of match
	Then the names of teams should be as expected "Alloa Athletic" and "Ayr United"
	Then the score should be "0" "2"