Feature: Title of articles on news page
	In order to make sure the headlines on the news page are correct
	Iwant to compare them with expected

@smoke test
Scenario: Check the title of main article on News page
	When I go to the News Page
	Then the title of main article should be "England region faces restrictions as cases spike"

@smoke test
Scenario: Check the secondary article titles on News page
	When I go to the News Page	
	Then the titles of secondary articles should be:
		 |Titles                                               |
         |Hopes fade in search for Beirut blast survivor       |
         |Professor who posed as black 'won't teach classes'   |
		 |Earth's 'lost species' only the tip of the iceberg   |
         | Trump refuses to condemn Russia over Navalny"       |	  
		 |Drone filmed dropping suspected cannabis over city   |
        
			  
			  
			 