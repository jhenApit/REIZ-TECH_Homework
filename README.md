# REIZ TECH Homework Assignment

## Clock Lesser Angle Calculator App
For the first part of this assignment, the task was to implement a program that would compute the lesser angle between the hands of a clock given a specific time input. To accomplish this, I researched different formulas for calculating the angle between clock hands and decided to use the second method outlined in this article: 
<br/>
<br/>
https://www.omnicalculator.com/math/clock-angle#clock-angles-the-angle-between-clock-hands

This method calculates the angle between the hour hand and minute hand based on their positions on the clock face and their relative distances from the 12 o'clock position. To implement this formula in code, I first extracted the hour and minute values from the user's input and then calculated their positions on the clock face. I then used the formula to compute the angle between the hands and returned the lesser angle between the two possible angles.

I implemented the clock and angle calculator as separate classes. The `Clock` class stores the hours and minutes of the clock, and the `ClockAngleCalculator` class takes a `Clock` object as input and computes the lesser angle between the hour and minute hands.

## Tree Structure Depth Calculator App
For the second part of the Assignment, it reminded me of a Binary Tree traversal so I used the same recursive algorithm for calculating the depth of the tree. 

The `CalculateDepth` method in the `BranchDepthCalculator` class is similar to a traversal algorithm, where we check if the current node has any child branches and recursively traverse them to calculate their depth. We use a base case to handle the situation where the current node has no child branches, and we return a depth of 1.

In the recursive case, we calculate the depth of each child branch and return the maximum depth among all child branches plus 1, which represents the depth of the current node. This algorithm ensures that we traverse the entire tree and return the correct depth of the structure.

By using this recursive approach, we can easily calculate the depth of the tree regardless of its size or complexity.

## Notes
I would like to thank **Reiz Tech** for this fun and quite challenging Assignment and I hope that I was able to provide helpful and clear explanations for the tasks assigned. It was a great opportunity for me to showcase my skills and knowledge in programming, and I appreciate the chance to work on this project.

- Jhen Sarah Apit
