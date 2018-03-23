# Trasalum
## Project for Back-End Capstone

#### By _Greg Turner_

## Documentation

Trasalum (read as "Trace Alumn") allows an authenticated NSS staff user to maintain current details on recently gradualted Alumni, referred to as "Alums." The user can log contact attempts to Alums and consequently update the Alum's details. 

Trasalum users are able to schedule events / engagments in which technologies or other revelent knowledge can be taught to current NSS students. Alums and/or Meetup groups are designated as speakers/sponsors for the events. Users can more effectively schedule the most valuable events for the students based on the knowledge (technologies) proficiencies of the Alum speaker or Meetup group and those the students are endevoring to study in their Cohorts.

The application is ASP.NET MVC in C# language and utilizes SQL Server 2017 to manage the captured data. Visual Studio Community 2017 was the text editor used to create Trasalum.


## Features

#### Register/Login

A new user launching Trasalum must register as a new NSS Staff Member. Once authenticated, a new navigation bar is visible at the top of the application. The user can either search for an Alum using the search bar in the navigation bar or utilize the buttons and dropdown menues to navigate the application.

#### NSS -> Cohort

After clicking the NSS button and selecting Cohorts, a complete listing of the NSS Cohorts with start date, demo date, instructor(s), and technologies taught is revealed.

#### NSS -> Staff

Selecting Staff from the NSS dropdown lists all NSS staff and their department. Existing staff can be updated or new staff added.

#### NSS -> Technologies

The technology selection reveals a list of technical knowledge and the "TechType" (Language, Framework, Process, Tool) trackable within the application. New tech can be added, while existing cann be updated or deleted. (Note: Subsequent versions should change the delete functionality to "Disabling.")

#### Alum

The Alum button shows a paginated list of Alums initially ordered by last name. If preferred, the Cohort column title can be clicked to order the Alums by Cohort. The user can use a link to Add a new Alum, update the Alum, view the details of the Alum, or log a new contact attempt for each Alum listed.

     Edit: Currently, any detail can be changed for the Alum as last names and contact information can change. 
     Technologies known by the Alum can also be recorded by a seledction of checkboxes.
     
     Details: The detailed view of the Alum also shows a list of past contact attempts to the Alum. The user 
     can use links at the bottom of the page to navigate to edit, log a new contact, or return to the list of
     Alums.
     
     Log a New Contact: A form for a new contact includes the currently logged in staff member as the "Initiator" 
     and the date and time of the attempt in addition to the method of contact and notes are all captured.
     
#### Events

The Events button reveals a table of upcoming events which can be Updated, Viewed, or Deleted. Below this is a table of past event which can be viewed in detail. (Note: Past events cannot be updated or deleted.) A Schedule Event link allows the user to record the date/time, description, event type (speaker for a cohort, company sponsored event, or Meetup event), any tech topic, any associated Meetup group, and any Alum speaker involved. Finally, the user can include comments. All of these can be updated or changes in the Update page and updating comments with feedback is advantageous.

#### External Groups -> Meetups

Selecting Meetups under the External Groups navbar button takes the user to a paginated list of Meetup groups. These can be edited, view details, or deleted. An Add Meetup link above takes the user to a form to collect details about the group, including the primary technology knowledge on which the group may focus. 

## Database Tables

![alt text](https://github.com/Greg-Turner/Trasalum/blob/master/ERD.PNG)

### License

*This project is considered open sourse, and would fall under a MIT license*

Copyright (c) 2018 **_Greg Turner_**
