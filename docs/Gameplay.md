# Baseball Gameplay

## Description

This document shows the different Gameplay's aspects of our **Baseball game**.

The project Github is available [here](https://github.com/NewBieBR/Baseball).

-------------------------------------------------------------

## Summary
  - Game : modes - rules
  - Play : user interactions

-------------------------------------------------------------

## Game

> It's not a Baseball simulation; it's a Baseball's inspired funny game.

The game will be divided into several game mode. </br>
Each mode has its own rules and the difficulty varies. </br>
A shop will be added to.


To begin, we'll focus on the easiest who will be the Arcade Mode.

### 1. Arcade Mode

The arcade is an "unlimited" mode where the difficulty grows little by little.

The Pitcher is a AI who sends balls to the Batter.
She randomly sends a ball or a bomb. We can think about some other objects who can give bonuses (Fruit, Powerade...) </br>

For the bombs, we will use probability :
  - After 1 ball   : 1/10
  - After 5 balls  : 2/10
  - After 10 balls : 4/10

For the difficulty, we can:
ball’s speed change, effects are added..  </br>


The player takes place as a Baseball Batter. He has to wait for the ball, and has to hit (or not) her at the right moment.


The player got three live points.

### 2. The shop

The shop will include different item who will influence his game experience :
  - Baseball bats
  - Different balls
  - Cosmetics items.

The main idea is to propose item who'll affect the game experience but who don't make our game a Pay2Win. </br>

I will explain how we'll do this.

I took the baseball bats as example but it will be the same for the balls, there will be different type of shape.</br>
- Some Baseball bats will be really big and it'll we easier to hit the ball, but you will earn less points while playing with this one. It's the perfect one for the beginners.
- Some will be just as a real Baseball bat so it's the intermediate level. You earn more points and it's not too difficult to hit the ball.
- The last type will be very thin Baseball bats. With them, you win a lot of points, but you have to be really good.

With this approach, the player has the choice on how he want to play. And he can do combos as use a Thin baseball bat with a Intermediate ball for example.

The cosmetics change nothing on the game but the Baseball fan can play a player from the team they love for example, or change the stadium.

Some adds will be added to earn coins and it will be possible to buy coins.

## Play

### 1. Arcade Mode

In this mode, the player just has to wait the right moment to touch his screen to launch the Batter Animation.
He had to hit as many balls as possible and dodge the bombs to stay alive.

For each ball missed or bomb hitted, the player loses a Lifepoint. </br>
For each ball hitted, the player wins coins that he can use in the shop and his score increase.

The goal is to do the best score.


### 2. The shop

The player will have to find the perfect combos to do the best score. He will have to try different couple of items to find what is the best for him.

He has the possibility to buy coin to have what he wants faster but it's not necessary.
He has the possibility to watch a add each day to earn some coins.

If he is fan of a team, he can buy the shirt for his player.
