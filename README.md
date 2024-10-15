# Municipal App

## Table of Contents
- [About the Project](#about-the-project)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Data Structures](#data-structures)
- [References](#references)

---

## About the Project
This project was built as an application for members of a municipality to report issues and complaints aswell as view local events. The application is still in the development phase and can only be used to report issues.

## Features
- Report issues to your local municipality.
- Get notifications regarding your issues.
- View local events and announcemets.
- Filter evnts by category or search for uniquw events.
- Get recommended events based on your search.

## Installation
```bash
# Clone the repository
git clone  https://github.com/VCDN-2024/prog7312-part-1-pineapple-pizza25 

# Navigate to the project directory
cd projectname

# Install dependencies
npm install

# Start the application
npm start

```

## Usage

### Report Fault Page
1. When the user opens the app they will see the main menu.
1.1. Here they have the option to report an issue, view special events, view issue status or view notifications.
1.2 The view special events and view issue status pages are currently not implemented.

2. In the report issue page the user can enter the details for the issue before submitting.
2.1. After submitting the user will get a success notification

3. In the view notifications page the user can view a list of their notifications.
3.1. They can click the clear button to remove their notifications.


### Local Events Page

1. When the user opens the page they will be greeted with 3 upcomming events thanks to the use of quese.
1.1 If a user clicks on event the will see the deatails about this event.

2. The user can enter a calue in the text box to search for an event by name.

3. The user can select a category to filter events by category.

4. If the user clicks the clear Button they will get top recommended events based on previous searches.


### Recommended Events

This feature works by storing a users unique searches in a hashset and then comparing the hashset to an already stored dictionary of events.
The events that match the users searches best will be stored to a different hashset which will be used to display the unique events to the user.


## Data Structures

### Dictionary

The Dictionary<string, Event> Events serves as the primary repository for local events within the LocalEvents class. 
Each event is stored with a unique identifier as the key and an Event object as the value. 
This structure allows for quick lookups and efficient retrieval of event data based on unique keys, making it easy to filter events using the Search and SearchByCategory methods. 
By leveraging a dictionary, we can access and display events swiftly, ensuring a smooth user experience.

### Quese

The Queue<Event> EventStack is employed to manage events in a first-in, first-out manner. 
This design allows the application to process and display events in the order they were added, 
which is crucial for maintaining a logical flow of information. 
The queue is populated in the InitialisStack method with events from the Events dictionary, 
and events are dequeued in the LoadEvents method to create user interface elements. 
By using a queue, we ensure that the most relevant or recently added events are presented first, enhancing user engagement.

### HashSet

We use HashSet collections—specifically HashSet<string> UserSearches and HashSet<Event> RecommendedEvents—to maintain unique collections of user searches and recommended events. 
The UserSearches HashSet tracks unique search terms entered by users, preventing duplicate searches and facilitating efficient event filtering. 
This structure helps us provide relevant results based on user input while improving performance by avoiding unnecessary calculations for duplicate searches. 
Conversely, the RecommendedEvents HashSet stores events suggested to users based on their previous searches, ensuring that recommendations remain relevant and unique. 
This enhances the overall user experience by tailoring suggestions to individual preferences.


## References

Background Image:
The moses mabhida stadium is a stadium in Durban, South Africa, named after moses mabhida, a former general secretary of the South African..." (2024) Pinterest. Available at: https://za.pinterest.com/pin/846817536215452969/ (Accessed: 06 September 2024). 

Scroll wheel:
Chand, M. (2024) Scroll windows with WPF scrollviewer in C# and Xaml, C# Corner. Available at: https://www.c-sharpcorner.com/UploadFile/mahesh/using-xaml-scrollviewer-in-wpf/ (Accessed: 12 September 2024). 

Font:
(No date) Google fonts. Available at: https://fonts.google.com/selection?preview.text=Location (Accessed: 12 September 2024). 
