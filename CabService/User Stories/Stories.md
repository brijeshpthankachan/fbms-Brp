
    1    Registration & Authentication    
   
        1.1 	user
		    1.1.1 	Registered user
			    1.1.1.1	An Existing User will be to sign in using Provided Username and Password 
			    1.1.1.2	An existing user should be able to sign out
			    1.1.1.3	Existing user should be able to reset password upon clicking forgot password
				    1.1.1.3.1	On clicking  forgot password user should get an account reset link
				    1.1.1.3.2	System should send an one time password to the users registered mobile number
				    1.1.1.3.3	User should be able to change the password upon entering the correct OTP
		    1.1.2 	new customer
			    1.1.2.1	A new user will be able to sign up by creating  a new account.
				New user should provide the following information
				
				        • Mobile no
				        • Email
				        • Name
				        • Username
				        • Password
				    1.1.2.1.1	System should verify the Mobile no using an OTP      
			    1.1.2.2	A user will be able to sign in  using third party accounts
				    1.1.2.2.1	User should able to signup using google
				    1.1.2.2.2	User should be able to sign up using twitter
				    1.1.2.2.3	User should be able to sign up using Facebook
	    1.2 	Cab
		    1.2.1	Existing cab
			    1.2.1.1	An Existing cab will be to sign in using Provided Username and Password 
			    1.2.1.2	An existing cab should be able to sign out
			    1.2.1.3	System should be able to keep track of the validity of each document and notify cab for revoking verification
			    1.2.1.4	Existing cab should be able to reset password   upon clicking forgot password
				    1.2.1.4.1	On clicking  forgot password cab should get an account reset link
				    1.2.1.4.2	System should send an one time password to the cab's registered mobile number
				    1.2.1.4.3	cab should be able to change the password upon entering the correct OTP
		    1.2.2	New cab
			    1.2.2.1	A new cab will be able to sign up by creating  a new account.
				    New cab should provide the following information / Documents
				
				        1. Driver Information
				                a. Licence Number
				                b. Driver Name
				                c. Identification Document
				                d. Mobile number
				                e. Address
				                f. Police clearance certificate
				        2. Cab information
				                a. RC Information
				                b. Registration number
				                c. Fitness Certificate
				                d. Pollution Certificate
				    1.2.2.1.1	System should able to send all the documents to the verification team
				    1.2.2.1.2	Cab should be able to see the verification status
			    1.2.2.2	Cab should able to sign in after completing verification
	
	
	
	
	2	Service Booking
		2.1	User should able to see nearby available cabs
			2.1.1	System should able to fetch users current location
		2.2	User should be able to see cab details
		2.3	User should be able to see driver details of a selected cab
		2.4 	User should be able to see cab rating
		2.5	User should be able to see cabs live location
		2.6 	User should be able to request a ride of his/her preference
			2.6.1	User must wait for the cab driver to accept for a specified amount of time
			2.6.2	User should get notified if rejected
			2.6.3 	User should be able to go to home page and start over again
		2.7 	User should be able to see estimated arrival time if accepted by the cab
		2.8	User should be able to chat or call with the cabdriver
		2.9	User should be able to see the fair upon reaching the destination
		2.10	User should be able to pay the cab after reaching the destination
			2.10.1	User should be able to pay using net banking
			2.10.2	User should be able to pay using credit card
			2.10.3	User should be able to pay using debit card
			2.10.4	User should be able to pay using UPI
			2.10.5	User should be able to pay using cash
		2.11	System must generate a detailed bill to user after successful payment
		2.12	User should be able to leave a rating
			2.12.1	User should be able to write a detailed review if rating is lower than a specified amount
		n
	
	
	3	Service request view
		3.1	Cab should be able to see all the service requests
			3.1.1	Service requests should be filtered by distance
			3.2.2	Cab should be able to see distance along with service request
		3.3	Cab should be able to either accept or decline a service request
		3.4	Cab should be able to see location of customer if accepted
		3.5	Cab should be able to chat / talk to the customer 
		3.6	Cab should get directions to the customer
			3.6.1	Cab should be able to integrate with google maps
		
		
	4	Cab status
		4.2 	Cab can select either on service or of service
			4.2.1	On service
				4.2.1.1	cabs will be able to receive service requests
				4.2.1.2	Cabs should transmit live location
				4.2.1.3	Cabs should maintain one of the bellow status while on service 
					4.2.1.3.1	Idle 
					4.2.1.3.2	On the way
					4.2.1.3.3	Passenger on board
			4.2.2	Of service
				4.2.2.1	Cabs will not receive any service requests
				
				
	5 	Finance
		5.1	System should integrate it's self with a ERP Finance Module
	
	
	
	
	6	Non Functional Requirements
		6.1 	Usability
			6.1.1	Should Work With Screen Readers
			6.1.2	Should Usable For Colour Blind Persons
		6.2	Reliability
			6.2.1	Should be Available For 24*7
			6.2.1	Should Have a Recovery Time less than 30 minutes
		6.3	Performance
			6.3.1	Should Handline up to 10000 Concurrent Transactions in a single server
			6.3.2	Should have a response time less than 2 sec
			6.3.3	Should be scalable to up to 1000 servers
