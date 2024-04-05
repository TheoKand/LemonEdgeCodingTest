![LemonEdgeCodingTest](https://github.com/TheoKand/LemonEdgeCodingTest/blob/master/Documents/lemon-edge.png)

## Problem

The following diagram is of a standard telephone keypad. It consists of a 4x3 grid of buttons. Using the valid moves of a piece from the game of chess, varying combinations of 7-digit phone numbers can be derived. For example, starting in the upper-right corner (the "3" key) using a rook (which moves any number of spaces horizontally or vertically), one valid number, after pressing the initial "3" key, is: 3145289


|   |   |   |
|---|---|---|
| 1 | 2 | 3 |
| 4 | 5 | 6 |
| 7 | 8 | 9 |
| * | 0 | # |

Write a program that will count the number of valid 7-digit phone numbers that can be traced out on the keypad for every given chess piece. The following rules define a valid phone number:

* Seven digits in length
* Cannot start with 0 or 1
* Cannot contain a * or #

## Remember
* It is possible that some pieces may not have any valid phone numbers
* You must provide the correct answers for **each individual** chess piece.
* Your solution should be maintainable by someone who has not seen it.
* Object-oriented design concepts should be used where-ever they make sense.
* It should be easy to extend the program for new requirements:
    * New keyboard layouts
    * Different rules
    * New types of chess pieces

