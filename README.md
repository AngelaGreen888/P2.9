# P2.9

Project2.Group9

# Final Presentation on December 9, 2019:

Link to the finished game: https://angelagreen888.github.io/P2.9/

## About the game

Our game is called "Obstacles".

This is an obstacle dodging game.

The player will control a player model (using the left and right arrow keys) to dodge incoming obstacles that progressively get faster the longer the game is played. The goal is to get to the end of the path without hitting an obstacle, or the player will restart from the beginning. (This game is meant to be frustrating with the ultimate satifacation of finishing the game without hitting a single obstacle.)

The game has a start screen, followed by an instructions screen at the start of the game. We've included a "Tries" counter at the top of the screen during the game, so the player can know how many attempts they've had. When the player hits an obstacle or falls off the path, the game will give the player 2 seconds of animation and then reset to the beginning of the path. Once the player reaches the end of the path there will be an end screen showing how many attempts it took the player to finish the game.
We didn't include any sounds in the game, as we felt that it would be a distraction from the intense gameplay.

We've incorporated colors to help the player better understand the elements of the game.

![](AssetColors.png)

## Our change in plans

We realize that the finished game does not include the machine learning mechanics through the camera control system as was originally planned to be implemented at the start of this project. This was an ambitious and difficult mechanic to implement, and we couldn't get it to work properly without any errors/issues by the deadline. We had a few of our developers attempt to implement the feature, however it still wasn't operating correctly. This is why the commits appear to be skewed and not equally dispersed.

However after the user study and discussing with various testers of our game, we decided it would be better suited to just use the arrow keys to play our game. Many of the users found the game to be difficult enough to play using the arrow keys already. If we were to implement the camera control system to move the player model, we thought it'd make the game too difficult to play and not enjoyable for the player. The arrow keys control system provides the correct amount of difficulty to allow the game to still be challenging and enjoyable. The simpler control interface also allows the player to start playing the game faster because they don't have to set up the camera control system before playing the game.

## Gif of the Game

![](/gifs/p2Final.9.gif)

## About our team

![](P2.9.GroupPicture.jpg)

From right to left: Timothy Bell, Angela Green, Stanley Yoang, Abraham Esparza, and Jack Chen

Angela Green - Team Leader. Update the README file. Keep everyone on task, make sure we're hitting benchmarks. Help where needed. Keeping everyone updated and distributed the tasks. Making sure everyone has what they need to accomplish their tasks. Implement UI for the start, instructions, and end screens and the game's overall look while applying the design principles talked about in class.

Timothy Bell - Utilize Unity to create the functionality of the game (moving an object left and right per user input of the arrow keys). Understand the architecture of the unity game file.

Stanley Yoang - Sketch the ideas that we all come up with to provide a basis for the UI. Make sure the UI/UX in the sketch will be similar to how it will be implemented. Implementing the menu design from the sketches and making sure that the product looks how we planned it during the beginning phase. Research and try to implement machine learning in unity.

Abraham Esparza - Research and utilize the machine learning that we learned from class under the project 1 resources. Research and tried to implement the capture of the user's camera, and be able to take a picture for the machine learning process. Helped connect the screens to each other.

Jack Chen - Research and try to implement the machine learning that we learned from class under the project 1 resources. Research and tried to implement the functionality of the machine learning process, in inputting a picture taken from Abraham to be utilized in the controls of moving the player model to the left or right. Helped change the elements to follow the asset colors.

---

---

# User Study Presentation 2 on December 2, 2019:

Demo link: https://angelagreen888.github.io/P2.9/

Task Description: Move the player model left and right (using the left and right arrow keys respectively) to dodge incoming obstacles. Make it to the end of the game without hitting a single obstacle.

Hypothesis: We believe that the users will be able to move the player model easily using the simple controls. They will collide with the premade obstacles and/or fall off of the stage and the game will restart after a few seconds of physics animation of how the blocks will move with each individual collision. We believe that it will be basic, and that the users should be able to complete the game within 5 - 10 minutes of playing. We also assume that due to the game being basic and incomplete, they will question the colors of the obstacles in the game to better differentiate ramps and obstacles.

Game Status Currently, and What we plan from here: The game has basic functionality in the current time. We will add more descriptions and embellished start and end screens in order to make sure that it's intuitive for the player to go through from the start of the game to the end. Also we initially intended on using machine learning to control the movement of the player model. It's very difficult to implement machine learning in Unity, so it will take a good amount of time to complete. We know the color issue of the obstacles and ramps to be confusing and will add this to the final product.

---

---

# Sketch Presentation 1 on November 22, 2019:

## About the game

This is an obstacle dodging game.
The player will control a player model using machine learning with camera functionality to dodge incoming obstacles that progressively get faster the longer the game is played. The controls will be camera operated where the user will take pictures of what they will do to go left and pictures of what they will do to go rght for the machine learning aspect of the project. The goal is to go as far as possible without hitting an obstacle, or they will restart from the beginning. (This game is meant to be frustrating with the ultimate satifacation of finishing the game without hitting a single obstacle.)

## About our team

![](P2.9.GroupPicture.jpg)

From right to left: Timothy Bell, Angela Green, Stanley Yoang, Abraham Esparza, and Jack Chen

Angela Green - Team Leader. Update the README file. Keep everyone on task, make sure we're hitting benchmarks. Help where needed. Keeping everyone updated and distributed the tasks. Making sure everyone has what they need to accomplish their tasks. Research UI for the start menu screen, the control setup screen, and the game's overall look while applying the design principles talked about in class.

Timothy Bell - Research and utilize Unity to create the functionality of the game (moving an object left and right per user input). Research machine learning and implement it to apply to our game (taking pictures for the controls, storing them, understand how it works, etc.).

Stanley Yoang - Sketch the ideas that we all come up with. Make sure the UI/UX in the sketch will be similar to how it will be implemented. Implementing the menu design from the sketches and making sure that the product looks how we planned it during the beginning phase. Researching Unity and help create assets that are needed in the game.

Abraham Esparza - Research and utilize the machine learning that we learned from class under the project 1 resources. Implementing the capture of the user's camera, and be able to take a picture for the machine learning process.

Jack Chen - Research and utilize the machine learning that we learned from class under the project 1 resources. Implement the functionality of the machine learning process, in inputting a picture taken from Abraham to be utilized in the controls of moving the player model to the left or right.

## Our sketches

![](/sketches/main.PNG)

Current Condition: <br/>
-User has started and loaded the game

Action: <br/>
-User presses start button

![](/sketches/controls.PNG)

New Conditions: <br/>
-Games shows controls menu and how to set up game to work properly <br/>
-User is able to click on take picture button to teach the game how to move

Action: <br/>
-User presses play button

![](/sketches/start.png)

New Conditions: <br/>
-Game displays rules and countdown until the game starts <br/>
-User can see him/herself in camera at the bottom of screen

Action: <br/>
-Timer runs down so the game has started <br/>
-User tilts head towards the left

![](/sketches/left.PNG)

New Conditions: <br/>
-Player model moves to the left

Action: <br/>
-User tilts head towards the right

![](/sketches/right.PNG)

New Conditions: <br/>
-Player model moves to the right

## What we've done

Started researching everything we need, played around with Unity individually to get familiar with the interface. Tasks were distributed. Independently planned out what needs to be done to accomplish our designated tasks.

## Plan moving forward

Create the Unity game file, and create clones on everyone's computers. Focus on the distributed tasks, and get those accomplished. If we run into road blocks, we'll ask each other to knowledge share and overcome everything together.
