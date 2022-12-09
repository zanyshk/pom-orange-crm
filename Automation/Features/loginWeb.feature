Feature: loginWeb

A short summary of the feature

@tag1
Scenario: validate successfull login of website with valid credentials
	Given userId is 'admin'
	And password is 'admin123'
	When  clicks the login button
	Then it redirects to search page

@tag2
Scenario: validate unsuccessfull login of website with invalid credentials
	Given userId is 'aaaa'
	And password is 'aaaa'
	When  clicks the login button
	Then it shows invalid credentials

	@tag3
Scenario: validate login of website with null userid and password
	Given userId is ''
	And password is ''
	When  clicks the login button
	Then it shows required username