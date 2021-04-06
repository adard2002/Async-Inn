# Async-Inn

# Name: Adara Townsend

# Date
- 4/5/21

# Image of ERD
![Async-InnERD](../assets/Lab11ERD.jpg)


# Requirements in Lab11: 
You have been tasked with creating a web based API for a local hotel chain. Here are the requirements that you obtained from your client during your exploration and requirements meeting.

- The hotel is named “Async Inn” and has many nationwide locations. Each location will have a name, city, state, address, and phone number.
- Async Inn prides themselves on their unique layout designs of each hotel room. They advertise as it being your “apartment for the night”. This means they have invested a lot of resources into how each room looks and feels. Some have one bedroom, others have 2 bedrooms, while a few are more of a cozy studio. The team mentioned that they like to label each room with a nickname to better tell the difference between each of the layouts and amenities each room has to offer. (for example, the Seattle location has two 2-bedroom suites, but one is named “Seahawks Snooze” while the other is named “Restful Rainier”, each with their own amenities.)
- They also take pride in the amenities that each room has to offer. This can consist of features like “air conditioning”, “coffee maker”, “ocean view”, “mini bar”, the list goes on…They requested that they would like the amenities associated with each of the rooms as they do vary.
- The rooms vary in price, per location, as well as per room number. They also have a few rooms that they want to advertise as pet friendly.
- The number of rooms for each hotel varies. Some hotels have only a few rooms, while others may have dozens.


# Writeup for Lab11
Async Inn has a couple of classifications for different rooms. "SeahawksSnooze" and "Restful Rainier" which both have their own ammenities.
Petfriendly is a bool and is in the Layout ID because the room can be either true or false according to whether or not the room is allowed pets.
Amenities are what is freely provided when the guest arrives there. Like an AC unit or ocean view or minibar. And services are what the guest has to pay for in order to recieve. Number of bedrooms is indeed how many rooms are included in one apartment.



### Defining where arrows point and why
- Location: Contains the Name, City, State, Address, and PhoneNumber of the hotel. This has a one to many relationship connecting to the Bedroom table because you can't have a bedroom without knowing it's location. <br>

- Bedroom: This table contains the Number of rooms, occupancy, studio, price, room number, and room floor. This is not pointing to any other table but has other tables pointing to it.

- BedroomNick: Contains the Nicknames Seahawks Snooze and Restful Rainier which differs in amenities and different providancies. This table has a one to many relationship connecting to both the Bedroom table and Amenities. Bedroom because the bedroom and the nickname both rely on eachother indicating which room and amenities you are going to get. <br>

- Services: This has different services that can be provided. This is different from amenities because with amenities it's free while services you must pay for. This table contains everything from RoomService to wifi and transportation. This has a many to many relationship with the fees table because it effects the fees in which you must pay for. <br>

- Amenities: This has different things that are provided for free. Such as; AC, Minibar, Pool, etc. This does not point to any other tables but does have BedroomNick pointing to it which reason is explained above. 

- Fees: This has a one to many relationship with both Location and BedroomNick. This is because the price of the rooms depend on which room you are going to because some have more or less benefits than others. 

- BedroomNickID and LocationID both have a one to many relationship to the LayoutID because you can't have a bedroom without a nickname and you can't have a room without a Location. 
- FeesID has a one to many relationship with both BedroomNickID and LocationID. Because the fee or cost relies on which room nickname/classification of the room you are in. And with LocationID it depends on where the room is and whether or not you have a fancy view of the ocean and such.
- ServiceID has a many to many relationship with FeesID because in relation to the services you may have the more fees or cost you will have to pay. 
- BedroomNick has a one to many relationship with both Amenities and LayoutID. Because the ammenities depends on what type of room your room is.
- 
