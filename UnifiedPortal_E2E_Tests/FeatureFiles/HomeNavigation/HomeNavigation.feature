Feature: HomeNavigation
	

Scenario:verify Admin Home Label on Unified Portal Admin Home Page
	Given I am on the Unified Portal Admin Sign In Page
	And I enter Valid Admin Email Address
	And I Click on Next Button
	And I enter Valid Admin Password
	When I Click Sign in Button
	And I Click on Yes Button
	Then I Sould be able to Navigate to Unified Portal Admin Page
	And I should be able to see Admin Home Label


Scenario: Verify that Unified Portal Admin returns to the root of the application by clicking on Admin Home Label
	Given I am on the Unified Portal Admin Sign In Page
	And I enter Valid Admin Email Address
	And I Click on Next Button
	And I enter Valid Admin Password
	When I Click Sign in Button
	And I Click on Yes Button
	Then I Sould be able to Navigate to Unified Portal Admin Page
	And I should be able to Navigate to Admin Home Label
	And I Click on Accounts Tabe
	And I Click on Admin Home Label
	And I should be able to navigate to Admin Home Page


Scenario: Verify that Report Hub admin can see Admin Home Label
	Given I am on the Reposrt Hub Admin Sign In Page
	And I enter Valid Admin Email Address
	And I Click on Next Button
	And I enter Valid Admin Password
	When I Click Sign in Button
	And I Click on Yes Button
	Then I Sould be able to Navigate to Report Hub Admin Page
	And I I should be able to see Admin Home Label


Scenario: Verify that Report Hun Admin can redirected to root of an application by clicking Admin Home Label
	Given I am on the Reposrt Hub Admin Sign In Page
	And I enter Valid Admin Email Address
	And I Click on Next Button
	And I enter Valid Admin Password
	When I Click Sign in Button
	And I Click on Yes Button
	Then I Sould be able to Navigate to Report Hub Admin Page
	And I Click on any Account
	And I Click on Admin Home Label
	And I should be able to navigate to Admin Home Page


Scenario Outline: verify That User can see Reports Label
	Given I navigate to Unified Portal SignIn Page
	And I Enter "<useremail>" in Email Address field
	And I Enter "<userpassword>" in Password field
	And I Click Sign In Button
	And I should be able to Navigate to Unified Portal Home Page
	And I can see Report Hub SVG Image
	And I Click on Report Hub SVG Image
	And I should be able to Navigate to Report Hub Home Page in New Tab
	And I can see Reports Label
	And I Navigate to Any SubFolders
	When I Click on Reports Label
	Then I should be able to Navigate to Report Hub Home Page
	
	Examples: 
	| useremail					| userpassword	|
	| salpesh5@mailinator.com	| Adtesting15	|