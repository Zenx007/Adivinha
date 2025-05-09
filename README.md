# Number Guessing Game 🎯

This is a simple **console-based number guessing game** written in **C#**. The game was created to help practice and reinforce understanding of C# syntax, including variables, loops, conditionals, and user input handling.

## 🧠 How It Works

- The program randomly picks a number between **1 and 100**.
- The player has **10 chances** to guess the correct number.
- After each guess, the program provides a hint:
  - `"TMuito Baixo!"` if the guess is lower than the secret number.
  - `"Muuito Alto!"` if the guess is higher than the secret number.
  - `"Coreto!"` if the player guesses right.

If the player runs out of attempts, the correct number is revealed.

## 📋 Features

- Simple and interactive gameplay via the terminal
- Basic error handling for non-numeric input
- Use of:
  - `Random` for number generation
  - `while` loop for the main game loop
  - `if/else` logic for guess evaluation
