## Puzzle Solver (A* Algorithm) ##

This project is a C# Windows Form application that solves the 8-puzzle game using the A* algorithm. The 8-puzzle consists of a 3x3 grid with numbered tiles from 1 to 8 and one empty space. The goal is to move the tiles up, down, left, or right to reach the target state from the initial state.

**Features**

- Implementation of the A* search algorithm
- Heuristic function defined as F = G + H formula
- User-definable start and goal states
- Step-by-step visualized solution
- Easy-to-use Windows Form interface

**Usage**

- Launch the application
- Set the initial position in the Initial State panel (enter 0 for the empty space)
- Set the target position in the Goal State panel
- Click the START button to begin the solution process
- After the algorithm runs, the solution steps will be visualized

**Technical Details**

**A Star Algorithm**

- The A* algorithm is a best-first search algorithm based on the formula:

![image](https://github.com/user-attachments/assets/a644162b-af1a-4685-96b6-f422ccd88771)

**Where:**

- G(n): The cost from the start state to the current state (number of moves made)
- H(n): The estimated cost from the current state to the goal state (heuristic function)
- F(n): The total estimated cost

In this project, Manhattan distance is used for H(n). This measures how far each tile is from its target position.


**State Representation**

Each state is represented as a 3x3 matrix, and the following operators are used:

- Move right
- Move left
- Move up
- Move down

The cost of each move is 1 unit.


**Algorithm Steps**

- **1.** Add the initial state to the open list
- **2.** Select the node with the lowest F value from the open list
- **3.** If this node is the goal state, the solution is found, and backtrack
- **4.** Otherwise, move this node to the closed list
- **5.** Generate all neighbors of the node (new states created by possible moves)
- **6.** For each neighbor:
  
  - If it's in the closed list, skip
  - If it's not in the open list, add it to the open list
  - If it's already in the open list and the new path is better, update it


Return to step 2

## Screenshots ##

**Opening Screen**
![image](https://github.com/user-attachments/assets/3d776e48-5f6e-4707-9ad5-3af8d3caa3e4)



**Initial values have been entered**
![image](https://github.com/user-attachments/assets/852570f3-aebc-45b5-8d9b-2d08e2e60ce1)


**States of processing**
![image](https://github.com/user-attachments/assets/715dbb24-fe56-49e5-9e96-acca891401bd)


**Final Screen**
![image](https://github.com/user-attachments/assets/75d6000e-8dff-4b4f-ae9f-edd190c1ca9f)


**Requirements**

- .NET Framework 4.5 or higher
- Windows operating system

**Installation**

- Clone or download the project
- Open the solution in Visual Studio
- Build and run the project

**Contributing**

- Fork this repository
- Create a new feature branch (git checkout -b new-feature)
- Commit your changes (git commit -m 'Added new feature')
- Push to the branch (git push origin new-feature)
- Create a Pull Request
