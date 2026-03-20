"# apbd-tut3-s30002" 

## Project Description

This project is a console application for managing a university equipment rental system.
It allows users to rent and return equipment, track availability, and generate reports.

## Design Decisions

### User hierarchy
User is implemented as an abstract class because there is no generic user in the system.
Student and Employee define their own rental limits using polymorphism.