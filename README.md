# Rock Paper Scissors

#### C# Week Two Practice Project _March 4th 2020_

#### By _**Keturah Howard**_

## Description

Two player game- one player coming soon. Play Rock papaer scissors against your friend(or foe), win by selecting the object that beats your friends obect!

Rock beats scissors
scissors beats paper
Paper beats Rock

 This project is being created with the intention of practing object-in-object functionality, and MSTesting with C#.

## Specifications:


| Specification for Backend | Example Input | Example Output |
| :------------- |:-------------| :-------------------|
| Create **players** | create player 1 and player 2 | *2 seperate players exist* |
| Create players with names | create player 1(john) and player 2(jeff) | *john and jeff exist* |
| Players write in weapons | john.getWeapon("paper") | *johns weapon from weapon propert:* "paper" |
| **Weapon objects** exist | createPaper, createRock, createScissors | *rock, paper, scissors exist* |
| Players choose **weapon** out of available weapons | *rock paper or scissors* jeff.getWeapon(scissors) | *jeff has scissors as weapon  property* |
| Victory/Draw/Lose **statuses** are created | createVictory, createDraw, createLose | *victory, draw, lose exist* |
| **Battle** is created with weapon props | create battle(paper, scissors) | *battle of paper and scissors exists* |
| Battle compares weapon props | create battle(paper, scissors) | *battle output:* paper and scissors |
| Battle returns Victory/Loose/Draw statuses based on weapon combinations | create battle(paper, scissors) | *paper **Lose**, scissors **Victory*** |
| Battle holds two players | create battle(jeff, john) | *battle of jeff and john exists* |
| Battle results in two seperate statuses depending on assaigned weapons | battle holds: john-paper and jeff-scrissors | *john **Lose**, jeff **Victory*** |

#### Brainstorm Notes
- gameplay class: weapons, result status
- setup class: players, battle

## Setup/Installation Requirements

  ### Installing .NET Core

  #### macOS
  * Download a .NET Core SDK from Microsoft Corp
  * Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.

  #### on Windows
  * Download the 64-bit .NET Core SDK from Microsoft Corp.
  * Open the .exe file and follow the steps provided by the installer for your OS.

  ### Installing This Application

  1. Click on the *clone or download* button of this repository. You can download the project file clicking the **"Download Zip"** button, double clicking the file in downloads, and navigating to the index.html file and double clicking that. *Or*, you can copy the link that pops up when you've clicked the *clone or download* button above this README.md file...
  2. Navigate to your terminal, where you have previously installed git (if you have not done this yet, go ahead and do so now).
  3. In terminal, change your directory to desktop, and then type **git clone https://github.com/KeturahDev/**.
  4. When you've pressed enter, my project will be cloned onto your desktop, and now you can change directory into it and type **"code ."** to open the projects files in Visual Studio Code!
  5. At the root directory for this project in your chosen command promt program, enter the command "dotnet build" followed by "dotnet run". You can now begin to play Banana Bakery!

## Technologies Used

* Git
* VS Code
* C#
* .NET


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email me at keturah.dev@gmail.com.

## License

This HTML web page is licensed under the MIT license.

## Copyright

Copyright (c) 2020 Keturah Howard.