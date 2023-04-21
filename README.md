# UnityTests
I use this repo for my Unity Tests, and sharing projects for my Peers to check them out (and help me whenever there is a weird bug.)

## Input System Test
### Project
My idea is having a 2D game where the world is round. Nevertheless, instead of the player moving, the world is the one that rotates, and the player handles the jumping. 

### Current questions
For some reason, the Player Input component is not working as expected. I have created an Input Action Asset, that has two maps: a World and a Player. And an XBox Controller scheme (as it is the main Input I am currently trying.) The world should be the one hearing the movement (from an XBox controller left stick) and the player the Jumping (by pressing South on the XBox controller). Because I know the Character Game object is the Player, and the World Game Object is the World, then I am manually assigning the Default Map to each of them.

<img title="World Game Object" alt="World has Player Input Controller" src="/Images/WorldComponent.png">