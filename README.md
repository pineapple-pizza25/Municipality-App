# Municipal App

## Table of Contents
- [About the Project](#about-the-project)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Data Structures](#data-structures)
- [Project Completion Report](#project-completion-report)
- [Technological Improvements](#echnological-improvements)
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

### Trees
In my application, I use a tree structure implemented with the Singleton pattern to store issue data efficiently. 
The tree is designed to be generic, allowing it to hold various types of data. 
The root of the tree is initialized with a default value, ensuring a base structure for the tree when it is first created. 
Each node in the tree represents a category stored as a string, which are set as children of the root or other parent nodes. 
The issues are stored as objects in the grandchildren nodes, providing flexibility to handle various data associated with each issue. 
This approach ensures a scalable and organized way to manage the hierarchical relationships between categories and issues, with the Singleton pattern ensuring that the tree is accessed consistently and globally throughout the application.

### Heaps
In my application, I use a priority queue implemented with heaps to manage and display the priority of each issue. 
The heap structure, specifically a min-heap, ensures that issues with the highest priority (represented by the lowest priority values) are always at the top of the queue. 
As issues are added to the queue, the heap automatically maintains the order by comparing their priority values, enabling efficient retrieval and updating. 
This allows the application to quickly process the most critical issues first, optimizing the resolution workflow. 
The use of heaps ensures that both the insertion of new issues and the removal of the highest-priority issue are done in logarithmic time, making the system highly efficient even with large numbers of issues.


## **Project Completion Report**

### **Overview**

The project was focused on developing an application that efficiently manages issues through a variety of data structures, including trees, heaps, priority queues, and other advanced collections. The goal was to implement a system that allows users to categorize and prioritize issues in a way that optimizes data retrieval and decision-making. As the project progressed, I not only gained valuable insights into designing and implementing these data structures but also had the opportunity to enhance my skills in WPF UI design and other core programming concepts such as recursion, stacks, queues, dictionaries, hashsets, and Singleton design patterns.

### **Learning Experience and Technical Development**

#### **WPF UI Design**

Initially, the project started with the development of the **WPF (Windows Presentation Foundation)** user interface. At first, I was primarily focused on learning the basics of WPF controls, data binding, and event handling. I spent significant time experimenting with different **UI tricks**, such as creating responsive layouts, designing intuitive user experiences, and handling user interactions effectively. I used various WPF features such as **Styles**, **Triggers**, **Templates**, and **DataGrid** controls to manage complex layouts and ensure that the application was user-friendly and aesthetically pleasing. This phase of the project helped me build a solid foundation in WPF and improved my understanding of UI design principles.

#### **Understanding Core Data Structures**

As the project evolved, the need for efficient data management became clear. To handle issues with different priorities and categories, I delved into several important data structures, each with its unique properties and use cases. The following sections detail the challenges and lessons learned in implementing various data structures.

1.  **Stacks and Queues**: Initially, I explored **stacks** and **queues** for managing temporary data and processing tasks in a last-in, first-out (LIFO) and first-in, first-out (FIFO) manner, respectively. These structures provided me with the foundational understanding of how to manage ordered collections and efficiently process data in a sequential manner. While these data structures proved useful, the project eventually required more sophisticated management of hierarchical and prioritized data, leading me to explore trees and heaps.

2.  **Dictionaries and HashSets**: I used **dictionaries** to map categories to their associated issue data and **hashsets** to ensure uniqueness of data entries. These collections provided efficient lookups and prevented duplicate data, which was crucial for managing large sets of issues and ensuring data integrity. I also implemented them in various parts of the UI to optimize performance and reduce unnecessary computations when handling user requests.

3.  **Recursion and Trees**: As the project required organizing issues into hierarchical structures (categories and subcategories), I learned to implement **trees** and recursively traverse through them. The **tree** structure helped organize the issues and allowed for easy management of parent-child relationships. I used **recursion** to navigate through the tree, ensuring that the application could traverse through categories and their respective issues in a depth-first manner. This helped me build a robust structure for categorizing and retrieving data based on user preferences.

4.  **Singleton Pattern**: One of the key design patterns I implemented was the **Singleton**. It was essential for ensuring that the tree structure holding the issue data was accessed globally and consistently across the entire application. This pattern also helped maintain the integrity of the data and ensured that multiple instances of the tree were not created unintentionally, which could lead to issues with data consistency. Implementing the Singleton pattern allowed me to manage the issue data more efficiently, as it centralized the access and modification of the tree structure.

5.  **Priority Queues and Heaps**: The most challenging and rewarding aspect of the project was implementing **priority queues** using **heaps**. A **priority queue** is a data structure that allows elements to be processed based on their priority. I chose to implement a **min-heap** priority queue to ensure that the most urgent issues (those with the highest priority) were always processed first.

    Heaps provided a unique challenge because they are not ordered like regular lists; instead, they are binary trees where the value of each parent node is either greater than or less than its children, depending on whether it's a **max-heap** or **min-heap**. I initially struggled with understanding how to maintain the heap property during insertion and removal operations. However, through iterative learning and debugging, I was able to implement the **heapify** process, which allowed me to maintain the order of elements in the heap efficiently.

    The heap-based priority queue enabled the application to manage issue priorities dynamically. As users assigned or updated the priority of an issue, the heap structure efficiently reorganized itself to maintain the correct order. This made the system highly responsive and optimized for managing large volumes of issues, ensuring that the most critical tasks were always addressed first.

### **Difficulties and Challenges**

1.  **Complexity of Heaps**: One of the biggest challenges I faced was understanding the intricacies of **heaps**. The logic behind the heap structure and the need for constant reordering of elements after every insertion and removal was initially confusing. I struggled with the **heapify** operation and ensuring that the heap property was maintained after each update. However, through research and experimentation, I was able to overcome this and successfully integrate a **min-heap** to manage issue priorities.

2.  **Recursion in Trees**: Working with **recursion** in trees, particularly for traversals (such as **pre-order** and **in-order**), proved to be a bit tricky at first. Managing the base cases, handling null nodes, and ensuring the correct traversal order required careful planning and debugging. Nonetheless, recursion is a powerful tool, and it eventually helped streamline the process of navigating through hierarchical data structures.

3.  **Managing Data Integrity with Singleton**: Implementing the **Singleton pattern** to manage the tree and ensure global access to the data was conceptually easy but practically challenging. Ensuring that the tree was correctly initialized only once and that data wasn't duplicated in other parts of the application required a deep understanding of the pattern and its implications on data management. I had to be cautious with thread safety and ensure that the tree instance was properly accessed and modified throughout the application.

4.  **UI and Data Structure Integration**: Another challenge was integrating the data structures with the **WPF UI**. While the WPF part of the project was initially straightforward, combining it with complex data structures like trees and heaps required efficient data binding and ensuring that changes in the data were reflected in the UI in real-time. I had to learn how to use WPF's **MVVM (Model-View-ViewModel)** design pattern to separate the logic from the UI and facilitate smooth communication between the data models and the view.

### **Conclusion**

This project provided an invaluable learning experience, where I not only honed my understanding of fundamental data structures but also learned how to apply them in practical scenarios. The combination of **trees**, **priority queues**, **heaps**, **recursion**, and **Singleton** helped create a system that efficiently manages and prioritizes issues. The integration of these advanced data structures into a WPF-based UI allowed for a seamless user experience. Despite the challenges, I was able to overcome each obstacle through persistence and research, ultimately developing a robust and efficient system for issue management.### **Project Completion Report**

### **Overview**

The project was focused on developing an application that efficiently manages issues through a variety of data structures, including trees, heaps, priority queues, and other advanced collections. The goal was to implement a system that allows users to categorize and prioritize issues in a way that optimizes data retrieval and decision-making. As the project progressed, I not only gained valuable insights into designing and implementing these data structures but also had the opportunity to enhance my skills in WPF UI design and other core programming concepts such as recursion, stacks, queues, dictionaries, hashsets, and Singleton design patterns.

### **Learning Experience and Technical Development**

#### **WPF UI Design**

Initially, the project started with the development of the **WPF (Windows Presentation Foundation)** user interface. At first, I was primarily focused on learning the basics of WPF controls, data binding, and event handling. I spent significant time experimenting with different **UI tricks**, such as creating responsive layouts, designing intuitive user experiences, and handling user interactions effectively. I used various WPF features such as **Styles**, **Triggers**, **Templates**, and **DataGrid** controls to manage complex layouts and ensure that the application was user-friendly and aesthetically pleasing. This phase of the project helped me build a solid foundation in WPF and improved my understanding of UI design principles.

#### **Understanding Core Data Structures**

As the project evolved, the need for efficient data management became clear. To handle issues with different priorities and categories, I delved into several important data structures, each with its unique properties and use cases. The following sections detail the challenges and lessons learned in implementing various data structures.

1.  **Stacks and Queues**: Initially, I explored **stacks** and **queues** for managing temporary data and processing tasks in a last-in, first-out (LIFO) and first-in, first-out (FIFO) manner, respectively. These structures provided me with the foundational understanding of how to manage ordered collections and efficiently process data in a sequential manner. While these data structures proved useful, the project eventually required more sophisticated management of hierarchical and prioritized data, leading me to explore trees and heaps.

2.  **Dictionaries and HashSets**: I used **dictionaries** to map categories to their associated issue data and **hashsets** to ensure uniqueness of data entries. These collections provided efficient lookups and prevented duplicate data, which was crucial for managing large sets of issues and ensuring data integrity. I also implemented them in various parts of the UI to optimize performance and reduce unnecessary computations when handling user requests.

3.  **Recursion and Trees**: As the project required organizing issues into hierarchical structures (categories and subcategories), I learned to implement **trees** and recursively traverse through them. The **tree** structure helped organize the issues and allowed for easy management of parent-child relationships. I used **recursion** to navigate through the tree, ensuring that the application could traverse through categories and their respective issues in a depth-first manner. This helped me build a robust structure for categorizing and retrieving data based on user preferences.

4.  **Singleton Pattern**: One of the key design patterns I implemented was the **Singleton**. It was essential for ensuring that the tree structure holding the issue data was accessed globally and consistently across the entire application. This pattern also helped maintain the integrity of the data and ensured that multiple instances of the tree were not created unintentionally, which could lead to issues with data consistency. Implementing the Singleton pattern allowed me to manage the issue data more efficiently, as it centralized the access and modification of the tree structure.

5.  **Priority Queues and Heaps**: The most challenging and rewarding aspect of the project was implementing **priority queues** using **heaps**. A **priority queue** is a data structure that allows elements to be processed based on their priority. I chose to implement a **min-heap** priority queue to ensure that the most urgent issues (those with the highest priority) were always processed first.

    Heaps provided a unique challenge because they are not ordered like regular lists; instead, they are binary trees where the value of each parent node is either greater than or less than its children, depending on whether it's a **max-heap** or **min-heap**. I initially struggled with understanding how to maintain the heap property during insertion and removal operations. However, through iterative learning and debugging, I was able to implement the **heapify** process, which allowed me to maintain the order of elements in the heap efficiently.

    The heap-based priority queue enabled the application to manage issue priorities dynamically. As users assigned or updated the priority of an issue, the heap structure efficiently reorganized itself to maintain the correct order. This made the system highly responsive and optimized for managing large volumes of issues, ensuring that the most critical tasks were always addressed first.

### **Difficulties and Challenges**

1.  **Complexity of Heaps**: One of the biggest challenges I faced was understanding the intricacies of **heaps**. The logic behind the heap structure and the need for constant reordering of elements after every insertion and removal was initially confusing. I struggled with the **heapify** operation and ensuring that the heap property was maintained after each update. However, through research and experimentation, I was able to overcome this and successfully integrate a **min-heap** to manage issue priorities.

2.  **Recursion in Trees**: Working with **recursion** in trees, particularly for traversals (such as **pre-order** and **in-order**), proved to be a bit tricky at first. Managing the base cases, handling null nodes, and ensuring the correct traversal order required careful planning and debugging. Nonetheless, recursion is a powerful tool, and it eventually helped streamline the process of navigating through hierarchical data structures.

3.  **Managing Data Integrity with Singleton**: Implementing the **Singleton pattern** to manage the tree and ensure global access to the data was conceptually easy but practically challenging. Ensuring that the tree was correctly initialized only once and that data wasn't duplicated in other parts of the application required a deep understanding of the pattern and its implications on data management. I had to be cautious with thread safety and ensure that the tree instance was properly accessed and modified throughout the application.

4.  **UI and Data Structure Integration**: Another challenge was integrating the data structures with the **WPF UI**. While the WPF part of the project was initially straightforward, combining it with complex data structures like trees and heaps required efficient data binding and ensuring that changes in the data were reflected in the UI in real-time. I had to learn how to use WPF's **MVVM (Model-View-ViewModel)** design pattern to separate the logic from the UI and facilitate smooth communication between the data models and the view.

### **Conclusion**

This project provided an invaluable learning experience, where I not only honed my understanding of fundamental data structures but also learned how to apply them in practical scenarios. The combination of **trees**, **priority queues**, **heaps**, **recursion**, and **Singleton** helped create a system that efficiently manages and prioritizes issues. The integration of these advanced data structures into a WPF-based UI allowed for a seamless user experience. Despite the challenges, I was able to overcome each obstacle through persistence and research, ultimately developing a robust and efficient system for issue management.
## **Project Completion Report**

### **Overview**

The project was focused on developing an application that efficiently manages issues through a variety of data structures, including trees, heaps, priority queues, and other advanced collections. The goal was to implement a system that allows users to categorize and prioritize issues in a way that optimizes data retrieval and decision-making. As the project progressed, I not only gained valuable insights into designing and implementing these data structures but also had the opportunity to enhance my skills in WPF UI design and other core programming concepts such as recursion, stacks, queues, dictionaries, hashsets, and Singleton design patterns.

### **Learning Experience and Technical Development**

#### **WPF UI Design**

Initially, the project started with the development of the **WPF (Windows Presentation Foundation)** user interface. At first, I was primarily focused on learning the basics of WPF controls, data binding, and event handling. I spent significant time experimenting with different **UI tricks**, such as creating responsive layouts, designing intuitive user experiences, and handling user interactions effectively. I used various WPF features such as **Styles**, **Triggers**, **Templates**, and **DataGrid** controls to manage complex layouts and ensure that the application was user-friendly and aesthetically pleasing. This phase of the project helped me build a solid foundation in WPF and improved my understanding of UI design principles.

#### **Understanding Core Data Structures**

As the project evolved, the need for efficient data management became clear. To handle issues with different priorities and categories, I delved into several important data structures, each with its unique properties and use cases. The following sections detail the challenges and lessons learned in implementing various data structures.

1.  **Stacks and Queues**: Initially, I explored **stacks** and **queues** for managing temporary data and processing tasks in a last-in, first-out (LIFO) and first-in, first-out (FIFO) manner, respectively. These structures provided me with the foundational understanding of how to manage ordered collections and efficiently process data in a sequential manner. While these data structures proved useful, the project eventually required more sophisticated management of hierarchical and prioritized data, leading me to explore trees and heaps.

2.  **Dictionaries and HashSets**: I used **dictionaries** to map categories to their associated issue data and **hashsets** to ensure uniqueness of data entries. These collections provided efficient lookups and prevented duplicate data, which was crucial for managing large sets of issues and ensuring data integrity. I also implemented them in various parts of the UI to optimize performance and reduce unnecessary computations when handling user requests.

3.  **Recursion and Trees**: As the project required organizing issues into hierarchical structures (categories and subcategories), I learned to implement **trees** and recursively traverse through them. The **tree** structure helped organize the issues and allowed for easy management of parent-child relationships. I used **recursion** to navigate through the tree, ensuring that the application could traverse through categories and their respective issues in a depth-first manner. This helped me build a robust structure for categorizing and retrieving data based on user preferences.

4.  **Singleton Pattern**: One of the key design patterns I implemented was the **Singleton**. It was essential for ensuring that the tree structure holding the issue data was accessed globally and consistently across the entire application. This pattern also helped maintain the integrity of the data and ensured that multiple instances of the tree were not created unintentionally, which could lead to issues with data consistency. Implementing the Singleton pattern allowed me to manage the issue data more efficiently, as it centralized the access and modification of the tree structure.

5.  **Priority Queues and Heaps**: The most challenging and rewarding aspect of the project was implementing **priority queues** using **heaps**. A **priority queue** is a data structure that allows elements to be processed based on their priority. I chose to implement a **min-heap** priority queue to ensure that the most urgent issues (those with the highest priority) were always processed first.

    Heaps provided a unique challenge because they are not ordered like regular lists; instead, they are binary trees where the value of each parent node is either greater than or less than its children, depending on whether it's a **max-heap** or **min-heap**. I initially struggled with understanding how to maintain the heap property during insertion and removal operations. However, through iterative learning and debugging, I was able to implement the **heapify** process, which allowed me to maintain the order of elements in the heap efficiently.

    The heap-based priority queue enabled the application to manage issue priorities dynamically. As users assigned or updated the priority of an issue, the heap structure efficiently reorganized itself to maintain the correct order. This made the system highly responsive and optimized for managing large volumes of issues, ensuring that the most critical tasks were always addressed first.

### **Difficulties and Challenges**

1.  **Complexity of Heaps**: One of the biggest challenges I faced was understanding the intricacies of **heaps**. The logic behind the heap structure and the need for constant reordering of elements after every insertion and removal was initially confusing. I struggled with the **heapify** operation and ensuring that the heap property was maintained after each update. However, through research and experimentation, I was able to overcome this and successfully integrate a **min-heap** to manage issue priorities.

2.  **Recursion in Trees**: Working with **recursion** in trees, particularly for traversals (such as **pre-order** and **in-order**), proved to be a bit tricky at first. Managing the base cases, handling null nodes, and ensuring the correct traversal order required careful planning and debugging. Nonetheless, recursion is a powerful tool, and it eventually helped streamline the process of navigating through hierarchical data structures.

3.  **Managing Data Integrity with Singleton**: Implementing the **Singleton pattern** to manage the tree and ensure global access to the data was conceptually easy but practically challenging. Ensuring that the tree was correctly initialized only once and that data wasn't duplicated in other parts of the application required a deep understanding of the pattern and its implications on data management. I had to be cautious with thread safety and ensure that the tree instance was properly accessed and modified throughout the application.

4.  **UI and Data Structure Integration**: Another challenge was integrating the data structures with the **WPF UI**. While the WPF part of the project was initially straightforward, combining it with complex data structures like trees and heaps required efficient data binding and ensuring that changes in the data were reflected in the UI in real-time. I had to learn how to use WPF's **MVVM (Model-View-ViewModel)** design pattern to separate the logic from the UI and facilitate smooth communication between the data models and the view.

### **Conclusion**

This project provided an invaluable learning experience, where I not only honed my understanding of fundamental data structures but also learned how to apply them in practical scenarios. The combination of **trees**, **priority queues**, **heaps**, **recursion**, and **Singleton** helped create a system that efficiently manages and prioritizes issues. The integration of these advanced data structures into a WPF-based UI allowed for a seamless user experience. Despite the challenges, I was able to overcome each obstacle through persistence and research, ultimately developing a robust and efficient system for issue management.


## Technological Improvements
To further improve the application, integrating a database for persistent storage would enable efficient management of issue and evemnt data, 
ensuring it is securely stored and easily retrievable. Using a relational database (such as PostgreSQL or MySQL) or NoSQL (like MongoDB) would provide scalability, enabling complex queries and better data organization. 
Implementing caching with technologies like Redis would significantly improve performance by reducing database load for frequently accessed data, ensuring faster response times. 
Additionally, adopting the MVC (Model-View-Controller) design pattern for a web application would streamline the separation of concerns, making the application more maintainable and scalable by dividing the application into distinct layers for handling logic, presentation, and data management. This architecture would allow the app to be more modular, flexible, and accessible through a web interface, facilitating easier management and better user interaction.

## References

Background Image:
The moses mabhida stadium is a stadium in Durban, South Africa, named after moses mabhida, a former general secretary of the South African..." (2024) Pinterest. Available at: https://za.pinterest.com/pin/846817536215452969/ (Accessed: 06 September 2024). 

Scroll wheel:
Chand, M. (2024) Scroll windows with WPF scrollviewer in C# and Xaml, C# Corner. Available at: https://www.c-sharpcorner.com/UploadFile/mahesh/using-xaml-scrollviewer-in-wpf/ (Accessed: 12 September 2024). 

Font:
(No date) Google fonts. Available at: https://fonts.google.com/selection?preview.text=Location (Accessed: 12 September 2024). 
