# Unity ML-Agents Project: MoveToGoal Agent

## Overview

This Unity project utilizes the Unity Machine Learning Agents Toolkit (ML-Agents) to create a simple "MoveToGoal" agent. The agent is designed to navigate a 3D environment to reach a goal while avoiding obstacles. The project demonstrates the use of ML-Agents for training intelligent agents using reinforcement learning techniques.

## Features

- **Agent Navigation:** The agent learns to move towards a goal position in the environment.
- **Dynamic Environment:** The goal position changes at the start of each episode, providing a varied learning experience for the agent.
- **Reward System:** The agent receives positive rewards for reaching the goal and negative rewards for hitting obstacles (walls).
- **Material Feedback:** Visual feedback is provided by changing the floor material to indicate success (win) or failure (lose).

##Input and output of the model
-Observation of the agent: Current position of the cube (agent) and current position of the sphere (goal)
-Action space - 2 continious variable representing the move amount in x and z direction for the cube to move. 

## Dependencies

- Unity 2020.3 or later
- ML-Agents Release 2 or later

## Setup

1. **Clone the Repository:**
   Clone this repository to your local machine or download the project files.

2. **Open the Project in Unity:**
   Open Unity Hub, add the project by navigating to the cloned directory, and click "Open".

3. **Install ML-Agents:**
   Ensure that ML-Agents is installed in your Unity project. You can install ML-Agents through the Unity Package Manager by adding the package from the GitHub URL.

4. **Scene Setup:**
   Open the main scene located in `Assets/Scenes`. This scene contains the pre-configured environment with the `MoveToGoalAgent`.

5. **Agent Configuration:**
   The `MoveToGoalAgent` script is attached to the agent in the scene. You can adjust the agent's parameters and materials in the Inspector window.

## Usage

1. **Training the Agent:**
   To train the agent, you will need to set up the ML-Agents training environment on your machine. Follow the ML-Agents documentation to install the necessary training software and set up your environment.

2. **Starting Training:**
   Once the environment is set up, use the ML-Agents command-line interface to start the training process. Refer to the official ML-Agents guide for the specific commands.

3. **Observing the Agent:**
   During training, you can observe the agent's behavior in the Unity Editor. The agent will learn to navigate towards the goal while avoiding walls.

4. **Evaluating Performance:**
   After training, evaluate the agent's performance by observing its ability to reach the goal in various scenarios. Adjust training parameters as needed for improved performance.

## Project Structure

- `Assets/Scripts/MoveToGoalAgent.cs`: Contains the main logic for the agent's behavior, including observation collection, action receiving, and reward handling.

- `Assets/Materials`: Contains materials used for visual feedback in the environment.

- `Assets/Scenes`: Contains the Unity scene set up for the agent's environment.

## Contributions

We welcome contributions to this project! Whether it's improving the agent's efficiency, adding new features, or fixing bugs, your contributions are valuable to us. Please feel free to submit pull requests or open issues to discuss potential changes.



---

For more information on Unity ML-Agents, visit the [official GitHub repository](https://github.com/Unity-Technologies/ml-agents).
