# oop_pw1_ext_2425

# Cover 9404133
# Table of contents
- [Introduction](#introduction)
- [Description](#description)
- [Problems](#problems)
- [Conclusions](#conclusions)


# Introduction
This section is dedicated to do a summary of the document, which contains different sections. 
Firstly you can see the Table of Contents that you can use in order to go directly to a specific section of the document.

Then, we have this introduction section for doing a summary of the document.

To add, we have a Description section for explaining all the design and development decisions carried out during the project develpopment followed by a class diagram.

Moreover, we have the Problems section where I will describe all the problems that have occured during the development of the project.

Finally, there is the Conclusions section where I will do a summary of what I consider most important to consider about this project and also things to remember for future projects not only for this subject but for other ones too.

# Description


CLASS DIAGRAM

+-------------------+
|     Program       |
+-------------------+
| + Main()          |
+-------------------+
        
+---------------------------+
|         Station           |
+---------------------------+
| - trains: List<Train>     |
| - platforms: List<Platform> |
+---------------------------+
| + Station(int)            |
| + AdvanceTick()           |
| + DisplayStatus()         |
| + AllTrainsDocked(): bool |
| + LoadTrainsFromFile(string): void |
+---------------------------+
        
+-------------------+
|      Train        |
+-------------------+
| - ID: string      |
| - status: Status  |
| - arrivalTime: int|
| - type: string    |
+-------------------+
| + GetID(): string          |
| + GetStatus(): Status      |
| + GetArrivalTime(): int    |
| + GetType(): string        |
| + SetStatus(Status): void  |
| + DecreaseArrivalTime(int): void |
| + ShowInfo(): string       |
+-------------------+

+-----------------------------+
|      PassengerTrain         |
+-----------------------------+
| - numberOfCarriages: int    |
| - capacity: int             |
+-----------------------------+
| + GetNumberOfCarriages(): int |
| + GetCapacity(): int          |
| + ShowInfo(): string          |
+-----------------------------+

+-----------------------------+
|        FreightTrain         |
+-----------------------------+
| - maxWeight: int            |
| - freightType: string       |
+-----------------------------+
| + GetMaxWeight(): int       |
| + GetFreightType(): string  |
| + ShowInfo(): string        |
+-----------------------------+

+-----------------------------+
|         Platform            |
+-----------------------------+
| - ID: string                |
| - status: PlatformStatus    |
| - currentTrain: Train       |
| - dockingTime: int          |
+-----------------------------+
| + GetID(): string           |
| + GetStatus(): PlatformStatus |
| + GetCurrentTrain(): Train  |
| + GetDockingTime(): int     |
| + AssignTrain(Train): void  |
| + AdvanceTick(): void       |
| + FreePlatform(): void      |
| + ShowInfo(): string        |
+-----------------------------+

+----------------+
|     Status     |
+----------------+
| EnRoute        |
| Waiting        |
| Docking        |
| Docked         |
+----------------+

+----------------------+
|   PlatformStatus     |
+----------------------+
| Free                 |
| Occupied             |
+----------------------+

# Problems
During the development of this project some problems have occured.

One of the problems I had has been loading the train.csv files when running the program as it only allows me to put the route of the file using double bars.

When running the program, after loading the existing file with all the trains and choose the Start simulation option, the program would only print Starting simulation... and nothing happened.

To add, when the simulation started, the updates of it where really fast and you could not actually see what was happening but that was solved changing the Thread.Sleep() method adding more time to the update of the program.

Moreover, I did not have an actual visual feedback of the updates of the program as it was not running well at first.
As well, I had some problems cloning the base repository to start creating the project.

Finally, THE MOST IMPORTANT PROBLEM I had was in the final of the project because, before doing the README the program would compile correctly, but, after finishing the project I tried to ran it for the last time and it could not compile and this alert showed up "No C# project is currently loaded. Please create a C# project in order to debug". However, if the project is opened directly in the pw1 folder, the program will run correctly. For that reason, I did some research in order to see what the problem was and I found that I should add a .vscode folder in order to run the program from the practical_work_i_oop.

# Conclusions
After doing this practical work I have reached some conclusions.

First thing is that it is better to distribute all the different file independently, with this I am talking about separating the different types of trains in different files, not all of them inside the Train.cs file as this makes the code and the program more structured and clean.

To add, it is really important how you pass the route of certain files in order to make the program be executed correctly because if not, the program would not work.

Finally, the resultant simulation shows 15 different trains with their specific information depending if they are a Passenger Train or a Freight Train and a Station with 6 different platforms that will update their state consecuently when the trains are docking.



