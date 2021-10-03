# UnityGameStateMachine

Setting up a third person character state machine correctly is fairly complex. Not only must input parameters be set up in Unity's mechanim but the inputs must also be set up in the input manager. 

In this example I also incorporated a basic climb script that uses Unity's physics engine (raycasting) to check if the player character should climb a wall as well as jumping animation. 

I've also included weapon scripts, damage and a basic health system such that the player can face AI driven characters.

All of these scripts rely on changing animation states at the right time based on the specifics of what is happening in the game.

The final video incorporated some basic assets from the Unity asset store and the code included is a very basic idle, walk, run, pivot script. Some of the state machines can end up being extremely complex node based chains that require a very complex understanding of animation, physics, math and code.

![image](https://user-images.githubusercontent.com/50190461/135763460-81e5cdf2-c1bd-4f1a-adca-33f35dce2d56.png)

![image](https://user-images.githubusercontent.com/50190461/135764373-505c3a6e-7537-42d2-b00a-5cc2e5ae462a.png)



https://user-images.githubusercontent.com/50190461/135764619-eae5d5dd-0d96-414c-b99f-37bd107cdc17.mp4


