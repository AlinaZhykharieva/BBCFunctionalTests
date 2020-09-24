Feature: CheckFormOnYourCoronavirusStoryPage
	In order to avoid submitting a form with blank required fields
	I want to send a form with empty required fields and check that the error messages are displayed


@negative
Scenario Outline: User can not submit a question to BBC with NameField blank
	Given I am on Home page
    When I go to the page where the form is located
	And  I fill form with the data and send it to server
	     |<Tell us your story.>| <Name> |<I am over 16 years old>| <I accept the>|
	Then error message are displayed

 Examples:
    | Tell us your story. | Name     | I am over 16 years old | I accept the |
    | My story            |          | Yes                    | Yes          |
    |                     | Alina    | Yes                    | Yes          |
    | My story            | Alina    | Yes                    | No           |
	| My story            | Alina    | No                     | Yes          |