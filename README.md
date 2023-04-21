# UnityTests
I use this repo for my Unity Tests, and sharing projects for my Peers to check them out (and help me whenever there is a weird bug.)

## Input System Test
### Project
My idea is having a 2D game where the world is round. Nevertheless, instead of the player moving, the world is the one that rotates, and the player handles the jumping. 

### Current questions
For some reason, the Player Input component is not working as expected. I have created an Input Action Asset, that has two maps: a World and a Player. And an XBox Controller scheme (as it is the main Input I am currently trying.) The world should be the one hearing the movement (from an XBox controller left stick) and the player the Jumping (by pressing South on the XBox controller). Because I know the Character Game object is the Player, and the World Game Object is the World, then I am manually assigning the Default Map to each of them.

<img title="World Game Object" alt="World has Player Input Controller" src="/Images/WorldComponent.png">
<img title="Character Game Object" alt="Character has Player Input Controller" src="/Images/CharacterComponent.png">

Here is how the Input Controller looks like:
<img title="World Input Controller Map" src="/Images/WorldInputControllerMap.png">
<img title="Player Input Controller Map" src="/Images/PlayerInputControllerMap.png">

Even though my understanding is that both GameObjects should be able to hear the Input events, it is not the case. When both GameObjects (Character and World) are active in the scene, only the Character Game Object (the player) is able to hear the input from the XBox controller. And so, whenevr I click the South button, it jumps. But the World is not able to hear the movement from the left stick. And, whenever I start the game with the Character inactive, the World is now able to hear the Movement Input event. 

It is like the Character is hijacking the event information.

### What I have tried
I have changed the order in the hierarchy, so that the World is on top of the Character. The World is still not able to hear the movement event when the scene is started with the Character active.
I have started the game with the Character active, and then at runtime deactivated the character. The world still does not hear the Move event.

If only one GameObject is able to hear my Player input, I believe that this could be "solved"by either having two Input Controllers, or having both Gameobjects inside of one parent GameObject that broadcasts the events. Nevertheless, I want to figure out what is actually going on, just out of curiosity. Because I believe it should be possible for two game Objects to hear one Input Controller, specially since they are not even mapped to the same Map. 

I will continue to update on the situation. And, please, correct me if I am wrong in my understanding! See ya!


