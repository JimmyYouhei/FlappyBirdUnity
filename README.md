# FlappyBirdUnity
- This project is the remake of the famous Flappy Bird game.
- This project originally was one of the projects required by Funix University. However, I also included zombies in the project and using C# as the scripting language. While Funix has a guide in using JavaScript only. Moreove , I also completely ignore the guide and design the project structure and divide the scripts into many individual files based on their behaviors instead of lumping into some big file and I found the project is easier to manage as such


## Detail
- This project used Unity 2018.2.12f1 (64-bit)
- I used C# as the scripting language 
- Except for the sprites, everything is made from scratch


## How to Install
- If you have an Android OS phone you can install from [Google App Store](https://play.google.com/store/apps/details?id=com.se00409x.FlappyBirdAssignment).
Due to google app store forbid me to name or mention Flappy Bird in the title or description because of intellectual right violation (And I do think google app should do so). As a result, my title and description maybe vague
- If you use Mac or window you can download from my [google drive](https://drive.google.com/drive/folders/1dQdVpYWsO4jX_oZYUgxrap_DHrltOiWQ?usp=sharing) and choose the 86 or 64 according to your computer
- if you want to work with the source code then please download from this repository and use Unity to open

## Project Note
- The bird is not moving at all. To be precise, to emulate moving, the bird is standing still but everything else is moving
- The background I used to spawn is currently Quad. Actually it should be sprite .At first I tried to use the offset of Quad to emulate moving but failed miserably so I still leave as so

- I use a trigger to destroy the spawn object. But I know it is not performance friendly , I should recycle instead but I may address it later or not because it is a very small game

- I also make zombies spawn as obstacles as an extra feature

- I used zombie sprite and animation from a course that I enroll previously about unity. The teacher gave a greenlight to reuse his sprite for his student.So it is not mine but not stolen

- Sometimes I use public sometimes I use [serializefield] and quite arbitrary. Well I just learn C# for 3 days and although it quite like java C# mindset is somewhat different especially in Unity so I am still learning

- I also use some game objects only to adapt to different screen size and those game objects will be deleted once the game start


## Special Note
-	Unity is versatile that is similar to Java slogan: write once , run everywhere. Unity can be built for many Operating Systems and platforms . Unity can be used to make both 2D and 3D game too
-	I have already developed apps for Android before learning Unity and I found strangely at home when learning Unity . GUI developer may found Unity interface easy to use 
-	Unity Physic Engine is easy to use and to be frank it takes nearly all of the developer work. However, I wonder when developers want to customize or make a special rule about physic will it become a limitation?
-	Unity can be used for other purposes than making game .
-	Unity is increasing in popularity and I can understand why. Game developers should learn Unity and C# 
-	Once learn Java when learning C# (C# even accept both “string” and “String”) it is quite similar but the way to think is different 
-	Nothing is perfect , Unity also some time display arbitrary errors such as array out of bound while developing . Normally restating will fix it 
-	C# will be the only scripting language in the future so forget all about other old languages of Unity   
 

## License 
This project is free software and follows the MIT License. More detail can be found [here](https://github.com/JimmyYouhei/FlappyBirdUnity/blob/master/LICENSE.MD)

