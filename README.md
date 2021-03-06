<p align="center">
  <img width="250" height="250" src="https://coding-assets.s3-us-west-2.amazonaws.com/img/stickerslug-logo3.png">
</p>

<br>

# Scrabble

#### _A Game of Words_	

#### By _**Tristan Emmerson, Allison Sadin, Cody Fritz**_

<br>

## **DESCRIPTION**

This application will allow the user to play scrabble with the console. The user may input a word and the application will return a number of points for every letter played.

<br>

 ## **SPECIFICATIONS**

| Spec 	| Input 	| Output 	|
|-	|-	|-	|
| Create object constructor that will accept a UserInput 	| "sparkle" 	| Your scrabble word is "sparkle" 	|
| Validate UserInput against criteria (no non-alpha) 	| R2d2 	| "no non-alpha characters" 	|
| Parse validated UserInput to WordArray 	| sparkle 	| WordArray =["sparkle"] 	|
| Split UserInput WordArray to individual characters (array elements) 	| WordArray=["sparkle"] 	| 1+3+1+1+5+1+1<br>s+p+a+r+k+l+e 	|
| Compare individual array elements against associated PtTotal 	| "k" 	| "k" = 5 points 	|
| Sum the individual PtTotal to a TotalScore 	| "sparkle" 	| 1+3+1+1+5+1+1<br>s+p+a+r+k+l+e 	|
| Return TotalScore 	| "sparkle" 	| "Your scrabble word score is: 13 pts" 	|




















<br>

## **SETUP & INSTALL**

* _This program utilizes .NET version 2.2, and is a required instal for this program to function. Ensure .NET version 2.2 is installed before progressing._

*  _Recommended browser for everything in life. [Google Chrome](https://www.google.com/chrome/)_.

*  _Github [repository](https://github.com/tmemmerson/Scrabble.Solution.git)_



*  **Windows/Mac Users:** If modifying for personal use, dl Git [here](https://git-scm.com/downloads/) (v2.62.2)

* Download [Visual Studio Code](https://code.visualstudio.com/) (v1.45)

* Download ZIP [here](https://github.com/tmemmerson/Scrabble.Solution.git) OR if you are comfortable cloning a repo, copy the link as shown below.

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone.gif "How to clone repo")

* this image shows you where to paste your copied link into VSCode

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif "Cloning from Github within VSCode")

* Once cloned, navigate to the {yourProgramName}.Tests file using $ cd {yourProgramName}.Tests and use $ dotnet restore to create bin and obj directories. Make sure to hide those files in your .gitignore.

* Once the program has been built, navigate to your root directory using $ cd .. and type in command $ dotnet run

<br>

## **PROTECTING YOUR DATA**

* Step 1: create a .gitignore file in the top level of your project directory. populate the file as shown in step 1 of the image below.

* Step 2: commit that .gitignore file (this prevents your sensitive information being shown to others). **DO NOT PROCEED TO UNTIL YOU DO THIS!**

* Step 3: ignore step 3 for this project, as it does not utilize an API Key.

![setup](https://coding-assets.s3-us-west-2.amazonaws.com/img/readme-image.jpg "Set up instructions")


<br>

## **Known Bugs**

 _No Known Bugs: 7/16/2020_

<br>

## **Support and contact details**

_Questions, comments and concerns can be directed to the author(s) [Tristan Emmerson](tristan@stickerslug.com)_

<br>

## **Technologies Used**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Image work:** [Adobe Photoshop](https://www.adobe.com/products/photoshop.html/)_

_C#_ 

_.NET version 2.2_

_MSTest_


<br>

## **License**
![alt text][logo]

[logo]: https://img.shields.io/bower/l/bootstrap "MIT License"

Copyright (c) 2020 **_ [Allison Sadin](aesadin@gmail.com)_**



