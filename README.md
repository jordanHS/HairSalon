# Hair Salon

#### _C#, .NET: Hair Salon, 1/16/2020_

## Description
Create a MySql application with a database to allow users to input stylists, and add clients to the list of those added stylists

## Application should have:
- Interact with user and create new stylists, and the clients they serve.
- Separate frontend and backend logic.

## Unit Testing
 
### Input:

| StylistId | Name | Speciality |
| :------------- | :------------- |
| 0 | Jeremy | Colorist |

-----------------------------------------

| ClientId | Name | Appointment |StylistId |
| 0 | Renee | 10:45 | 0|

### Output:

#### Sylist Details
--------------

Name: Jeremy
* Renee


Clients
* Renee | Jeremy

#### Client Details
-----------------

Name: Renee
Appointment: 10:45



 


## Setup/Installation Requirements

1. Create MySql database titled jordan_safford
    - Table One: Stylists; Columns: StylistId, Name & Specialty
    - Table Two: Clients; Columns: ClientId, Name, Appointment & StylistId

2. Clone this repo:
```
https://github.com/jordanHS/HairSalon

```

3. Go into the repo and run this application: 
```
$ dotnet run
```

## Known Bugs
* List of clients not displaying for a stylist

## Support and contact details
 jordansafford@gmail.com

## Technologies Used
_Git, GitHub, C#, .NET Core & MySql_


## License
Copyright © 2020 under the MIT License
