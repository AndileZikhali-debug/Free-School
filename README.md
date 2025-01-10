# Free-School

Free School is a realistic school simulation game where players balance their grades and behavior while navigating the challenges of school life. Players must attend classes, participate in extracurricular activities, and interact with classmates and teachers to succeed.

---

## Features
- Realistic school environments (classrooms, hallways, cafeteria, playground).
- Grading system based on academic performance.
- Consequences for bad behavior (detention, suspension, etc.).
- Interactions with NPCs, including classmates and teachers.
- Opportunities for extracurricular activities like sports and clubs.

---

## Getting Started

### Prerequisites
- Install [Unity](https://unity.com/) (version 2021.3 or higher recommended).
- Install [Git](https://git-scm.com/) for version control.

### Cloning the Repository
1. Clone the repository:
   ```bash
   git clone https://github.com/AndileZikhali-debug/Free-School.git
   
How to Use:

1. Attach these scripts to appropriate objects in your Unity scene:

PlayerMovement: Attach to the player object.

GradeManager, BehaviorManager, ExtracurricularManager, GameManager: Attach to a central "Game Manager" object.

InteractionManager: Attach to the player to handle NPC interactions.

NPC: Attach to NPC game objects.



2. Create UI buttons for testing (e.g., "Attend Class," "Skip Class," "End Day") and link them to the UIManager script functions.


3. Use Unity's Inspector to configure initial values for grades, behavior, and clubs.

This code sets up the core mechanics of the game. Next steps I'll expand it by adding features like:

Dialog systems for NPCs.

Visual feedback for behavior and grades.

Storylines based on player choices.

More detailed extracurricular activities or mini-games.
