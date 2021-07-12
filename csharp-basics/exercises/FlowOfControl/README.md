# Exercises

## Exercise #1

See [LargetsNumber](./FlowControl/LargetsNumber)

## Exercise #2

See [PositiveNegativeNumber](./FlowControl/PositiveNegativeNumber)

## Exercise #3

See [TenBillion](./FlowControl/TenBillion)

## Exercise #4

Write a program called PrintDayInWord which prints “Sunday”, “Monday”, ... “Saturday” if the int variable "dayNumber" is 0, 1, ..., 6, respectively.  Otherwise, it shall print "Not a valid day".

Use:

 - a "nested-if" statement
 - a "switch-case-default" statement.
 
# Exercise #5

On your phone keypad, the alphabets are mapped to digits as follows: ABC(2), DEF(3), GHI(4), JKL(5), MNO(6), PQRS(7), TUV(8), WXYZ(9).

Write a program called PhoneKeyPad, which prompts user for a String (case insensitive), and converts to a sequence of keypad digits.

Use:

 - a "nested-if" statement
 - a "switch-case-default" statement
 
Hints

 1. You can use *.toLowerCase()* to convert a *String* to lowercase.
 2. In switch-case, you can handle multiple cases by omitting the break statement, e.g.,
 
```C#
switch (inChar) 
{
    case 'a': case 'b': case 'c':  // No break for 'a' and 'b', fall thru 'c'
       Console.WriteLine(2); break;
    case 'd': case 'e': case 'f':
       ......
    default:
       ......
 }
 ```
