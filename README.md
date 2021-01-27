# Hangman
### _This project is not in a complete or portfolio ready state, and should not be considered representational of professional work._<br>
#### **12/17/20**

## By _Callie Stump, Danielle Thompson_
---
## 🚩 **Description**
This application will allow a user to play the Hangman game. 

The computer will generate a word from a pre-determined list.
The user can make a Guess by entering a letter into a form. The app will inform if the letter is right or wrong, and keep track of how many guesses are left.
After the user has made a guess, you will be directed to the /hangman page to see how many wrong or right guesses you have. On the /hangman page, the letters guessed correctly so far will be displayed, just like above: b _ b b _ _. Also, the letters that have been guessed incorrectly will be displayed, as well as how many guesses they have left. Messages will appear if you have guessed correctly, incorrectly, and for "Game Over" if you're out of guesses.
Duplicate guesses are not allowed. If the user tries to guess the same letter twice they will be told to try again.

// Notes: 
Try to change the color of an element on your /hangman page based on whether the guess was right or wrong. Play around with changing the layout of your template file based on whether a guess is right or wrong, and whether or not the game is over.
Bonus: make it two-player! Create a new form page where one user can choose a word for the other user to guess.


## 🔧 **Setup/Installation Requirements**
#### The Technologies listed above are required to run this program.
1. Copy this download link: https://github.com/calliestump/Hangman.Solution.git
2. Open bash and go to the directory where you would like to store your cloned project.
3. Clone the repo.
```
git clone https://github.com/calliestump/Hangman.Solution.git
```
4. Navigate to the cloned project folder and open VS code.
```
$ cd Desktop
$ cd [known directory]
$ code .
```
5. Navigate to the testing project folder in your VS terminal initalizes dotnet.
```
dotnet restore
```
6. If you wish to see if everything is compiling correctly go to the Bakery directory and run the following:
```
dotnet build
```
7. To see if the program is functioning properly you can use:
```
dotnet run
```
This will show you if everything is compiling correctly; if otherwise you be will prompt with error messages.

#### Dont forget that in order to push any changes you need to add your own GitHub repo. to your project.
```
git remote add origin [personal Github repo. link]
```
#### Note: Do this is your main parent directory. You do not want to have git initialized in any other places.


## **Technologies Used**
* C# V:7.3
* .NET Core V:2.2
* dotnet script, REPL
* Razor View Engine
* ASP.NET Core MVC
* RESTful Routing, CRUD, & HTTP
* Bootstrap Library
* CSHTML

## 🐛 Known Bugs

## **Specs**
--Hangman--

Namespace: (Word)
Class: (List of Words)
  Method: randomizer fxn to pull up a word[i] from our list
  {List of Words}
  -stretch goal to keep track of the words a user has already tried
Class: (Letter)
  Method: (Guess(letter))
    if {List1 - both correct & incorrect}.includes(letter)
      (Duplicate letters not allowed. Please choose another letter.)
      Program.Main()
    else {List1} != include(letter)
      { //for (Word)
      if letter == true
        ("Correct!")
        Add letter to List2
        Add letter to List1
      else if letter == false
        ("Wah wahhhh")
        Add letter to List3
        Add letter to List1
      }

  Overload method/constructor: (Guess(#OfTurns))
    subtract 1 from 6 total guesses; 
      if #ofTurn == 0
        return "Dead!"
      else 
        Guess(letter)

  Method: (IncorrectGuesses(turns))

      --> route: redirect to /hangman page
        |_ /hangman page includes: 
            - display correct letters b _ bb _ _ {List2 - correct}
            - display incorrect letters {List - 3 - incorrect}
            - display current turn's correct/incorrect status
            - display # of guesses left (6 total)
            - display # of incorrect guesses
            - display 1-6 images of hangman closer to dead

<details>
<summary>Expand Specs</summary>
<table>
  <tr>
    <th>Test</th>
    <th>Input</th>
    <th>Output</th>
    <th>Completed</th>
  </tr>
  <tr>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>    
  <tr>
    <td></td>
    <td></td>
    <td></td>
    <td></td>
  </tr>
</table>  
</details>

## Legal
Copyright (c) 2020 Danielle Thompson & Callie Stump 
