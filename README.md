# FlappyBirdUnity
- This project is the remake of the famous Flappy Bird.
- This project original was one of the projects required by Funix University. However, I also included zombie in the project and using C# as the scripting language while Funix have the guide in JavaScript only. Moreover , I also completely ignore the guide and design the project structural and divide the scripts into many individual files based on their behaviors instead of lumping into some big file as guided and I found the project is easier to mange as such 

## Detail
- This projects used Unity 2018.2.12f1 (64-bit) 
- I used C# as the scripting language for Unity game
- Except for the sprites , everything is made from scratch

## How to Install
- If you have an Android OS phone you can install from [Google App Store](https://play.google.com/store/apps/details?id=com.se00409x.FlappyBirdAssignment)
Due to google app store forbid me to name or mention Flappy Bird in the title or description because of intellectual right violation.And I do think google app should do so. As a result mydescription maybe vauge 
- If you use Mac or window you can download from my [google drive](https://drive.google.com/drive/folders/1dQdVpYWsO4jX_oZYUgxrap_DHrltOiWQ?usp=sharing) and choose the 86 or 64 according to your computer
- if you want to work with the source code then please download from this repository and use Unity to open

## Project Note
- the background I use to spawn is currently Quad. Actually it should be sprite .At first I tried to use offset of Quad to emulate moving but failed miserably so I still leave as so

- I use trigger to destroy spawn object. But I know it is not quite performance friendly , I should recycle instead but I may address it later or not because it is a very small game 

- I also make zombie spawn as obstacle as extra feature

- I used zombie sprite and animation from a course that I enroll previous about unity. The teacher gave a greenlight to reuse his sprite for his student
So it is not mine but not stolen 

- Sometimes I use public sometimes I use [serializefield] and quite arbitrary. Well I just learn C# for 3 days and although it quite like java
but C# mindset is somewhat different especially in Unity so I am still learning 
- I also use some game objects only as a way to adapt to different screen size and those game objects will be deleted once the game start 

## Special Note
-	Unity is quite versatile that is quite similar to Java slogan: write once , run everywhere. Unity can be build for many operating Systems and platforms . Unity can be used to make both 2D and 3D game too
-	I have already develop app for Android before learning Unity and I found strangely at home when learning Unity . GUI developer may found Unity interface easy to use 
-	Unity Physic Engine is quite easy to use and to be frank it works nearly all the developer work. However, I wonder when developer want to customize or make special rule about physic will it become a limitation?
-	Unity can be used for other purpose than game .
-	Unity is increasing in popularity and I can understand why. Game developer should learn Unity and C# 
-	Once learn Java when learn C# (C# even accept both “string” and “String”) it is quite similar but the way to think is different 
-	Nothing is perfect , Unity also some time display arbitrary error such as  array out of bound while developing . Normally restating will fix it 
-	C# will be the only scripting language in the future so forget all about other old language of Unity   

## License 
This project is a free software and follow MIT License. More detail can be find [here](https://github.com/JimmyYouhei/FlappyBirdUnity/blob/master/LICENSE.MD)

