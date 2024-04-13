<h1>EmergingSWE-UnityGame</h1>

<table>
  <tr>
    <th colspan="2"><h3>Team: Group 1</h3></th>
  </tr>
  <tr>
    <th>Member</th>
    <th>Role</th>
  </tr>
  <tr>
    <td>Tiara Grier</td>
    <td>Scrum Master/Developer</td>
  </tr>
  <tr>
    <td>Taylor Lightbourne</td>
    <td>Developer</td>
  </tr>
  <tr>
    <td>Anthony Chiu</td>
    <td>Product Owner/Developer</td>
  </tr>
  <tr>
    <td>Ryan Smith</td>
    <td>Developer</td>
  </tr>
</table>

## <h3>Resource Links</h3>
<h1>Sprint 3 Items</h1>
<ul>
  <li><a href="https://swegroup1.itch.io/sea-snake" target="_blank">Sprint 3 Game Demo</a></li>
  <li><a href="https://trello.com/b/UdariJbe/snake-game" target="_blank">Backlog - Trello</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%203/sprint3_scrum_check_evidence.PNG" target="_blank">Sprint 3: Daily Scrum Evidence</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%203/sprint3_CICD_evidence_1.png" target="_blank">Sprint 3: CI/CD Evidence 1</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%203/sprint3_CICD_evidence_2.png" target="_blank">Sprint 3: CI/CD Evidence 2</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%203/sprint3_CICD_evidence_3.png" target="_blank">Sprint 3: CI/CD Evidence 3</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%203/sprint_3_sprint_review.pdf" target="_blank">Sprint 3: Sprint Review</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%203/sprint_3_burndown_chart.png" target="_blank">Sprint 3: Sprint Burndown Chart</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%203/sprint3_test_part_1.png" target="_blank">Sprint 3: TDD Evidence 1</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%203/sprint3_test_part_2.png" target="_blank">Sprint 3: TDD Evidence 2</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%203/sprint_3_mob_evidence.png" target ="_blank">Sprint 3: Mob Process Evidence</li>
</ul>
    
## <h3>Sprint #3</h3>
<table>
<tr>
  <th colspan ="3">
    <h3>
      Story Point Forecast
    </h3> 
      
  </th>
    <tr>
    <th>Member</th>
    <th>Task & Rationale</th>
    <th>Points</th>
  </tr>
  <tr>
    <td>Anthony Chiu, Taylor Lightbourne, Tiara Grier, and Ryan Smith</td>
    <td>Implement Unity Testing Suite</td>
    <td>21</td>
    
  </tr>
      <tr>
    <td>Tiara Grier, Taylor Lightbourne</td>
    <td>Implement Title Screen</td>
    <td>5</td>
  </tr>
        <tr>
          <td></td>
    <td>Enhanced Game Over Screen</td>
    <td>15</td>
  </tr>
      <tr>
    <td>Anthony Chiu</td>
    <td>Remove DEBUG logic from SnakeMovement script</td>
    <td>1</td>
       </tr>
    <tr>
    <td>Ryan Smith</td>
    <td>Implement Player (Snake) Visuals </td>
    <td>4</td>
       </tr>
    <tr>
    <td>Anthony Chiu, Ryan Smith</td>
    <td>Music and Ambience </td>
    <td>21</td>
       </tr>
           <tr>
             <td></td>
    <td>Sound Effects </td>
    <td>13</td>
       </tr>

</tr>
  
</table>

  <p>
  Our forecast for sprint 3 consisted of 75 story points. Using Yesterday’s Forecast Pattern, 75 story points seemed manageable for our group. While we had 3 weeks to technically work on this sprint, we ended up spending 2 weeks to complete most of tasks, as many of us were particularly busy during one of these weeks. Also, based on Yesterday’s Forecast Pattern, the 75 story points as we had previously completed 85 story points during sprint 1 (when we also had 2 weeks to work on our game).  
    
  Testing continues to be one of our group’s biggest challenges, so we continue to give it 21 story points. In addition to being many members first time using Unity, many of us are new to the concepts and logic involved with developing test cases. We also delegated a total of 42 points towards making the music and sound effects and implementing them into our snake game. We wanted to make our game feel one of kind and avoid free community assets where we felt like we could. In addition to making most of the background art, the background music and SFX was composed by one of our team members. Developing music and coding it into with Unity was unfamiliar to many of us, thus justifying its high point score. While a decent amount of time was spent making the music, the result is well worth it – it helps amplify the ocean setting and evolve the classic 2D game (which has historically has had no to very little sound). 

  Finally, there is a total of 30 story points focused on creating our title screen and enhancing the game over screen. As noted in our first sprint, UI and scene management is more difficult than we expected. However, the addition of these 2 screens though does make the game feel more complete, rather than a demo that continuously loops. 

  The remainder of story points were focused on cleaning up any bugs and updating our UI. 
  </p>
  
<table>
  <tr>
  <th colspan ="2">
    <h3>
      Decomposed Stories Into Task (start of Sprint 3)
    </h3> 
      </th>
    <tr>
    <th>Stories</th>
    <th>Task</th>
   </tr>
   <tr>
    <td>As a developer I want to design test cases that pass to know that my methods/ classes are performing as intended.</td>
    <td>Implement Unity Testing Suite</td>
  </tr>
     <tr>
    <td>As a player, I want background music and ambience to help set the tone for the game.</td>
    <td>Create Music and Ambience</td>
  </tr>
       <tr>
    <td>As a player, I want sound effects to know I have completed an action correctly (such as eating food) or when I have done something wrong (like collide with a wall, resulting in a game over)</td>
    <td>Implement Sound Effects</td>
  </tr>
           <tr>
    <td>As a developer, I want to remove any traces of Debug for easier code reading.</td>
    <td>Remove DEBUG logic from SnakeMovement</td>
  </tr>
             <tr>
    <td>As a player, I want to know when I have lost the game so that I can know what to avoid and try again.</td>
    <td>Implement Game Failure Screen</td>
  </tr>
</table>


##
<details>
<summary>Sprint #2</summary>
<h1>Sprint 2</h1>
  <h3>Resource Links</h3>

<ul>
  <li><a href="https://swegroup1.itch.io/snake-3d-sprint-1-demo" target="_blank">Sprint 2 Game Demo</a></li>
  <li><a href="https://trello.com/b/UdariJbe/snake-game" target="_blank">Backlog - Trello</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%202/scrum_check_evidence.PNG" target="_blank">Sprint 2: Daily Scrum Evidence</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%202/ci_cd_evidence.PNG" target="_blank">Sprint 2: CI/CD Evidence 1</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%202/CI_CD_evidence_2.png" target="_blank">Sprint 2: CI/CD Evidence 2</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%202/CI_CD_evidence_3.png" target="_blank">Sprint 2: CI/CD Evidence 3</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%202/sprint2_review.PNG" target="_blank">Sprint 2: Sprint Review</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%202/sprint2_burndown.PNG" target="_blank">Sprint 2: Sprint Burndown Chart</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%202/test_sprint_2.png" target="_blank">Sprint 2: TDD Evidence</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%202/mob_sprint_2.png" target ="_blank">Sprint 2: Mob Process Evidence</li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%202/mob_sprint_2_second_picture.png" target ="_blank">Sprint 2: Mob Process Evidence 2</li>
</ul>

<table>
  <tr>
    <th colspan ="3">
      <h3>
        Story Point Forecast
      </h3> 
    </th>
      <tr>
      <th>Member</th>
      <th>Task & Rationale</th>
      <th>Points</th>
    </tr>
    <tr>
      <td>Anthony Chiu, Taylor Lightbourne, Tiara Grier, and Ryan Smith</td>
      <td>Implement Unity Testing Suite</td>
      <td>21</td>
    </tr>
    <tr>
      <td></td>
      <td>Implement CI/CD Implementation for Unity</td>
      <td>21</td>
    </tr>
    <tr>
      <td>Taylor Lightbourne</td>
      <td>Implement Game Failure Screen</td>
      <td>8</td>
  </tr>
        <tr>
      <td>Tiara Grier</td>
      <td>Fix Score Bugs</td>
      <td>5</td>
    </tr>
          <tr>
      <td></td>
      <td>Update Points UI to Increase on Food Collect</td>
      <td>4</td>
    </tr>
      <tr>
      <td>Ryan Smith</td>
      <td>Environment Visuals</td>
      <td>4</td>
        </tr>
  </tr>
</table>

<p>
  Our forecast for sprint 2 consisted of 63 points. This is close to our Sprint 1 which had 85 story points. We did yesterday's forcast pattern to account that 3/11-3/15 was KSU's Spring Break period, so we planned to do a little bit less this sprint to give every one some well deserved rest. 21 of our points were focused on creating more test cases; this was an unexpected challenge for everyone during Sprint 1 due to our limited knowledge of testing in software. We suspected that this would be another challenge during this sprint and gave it 21 story points. The other 21 story points were also focused on implementing a CI/CD which was a new concept for everyone on the team. We feel we scored this appropriately as part of this task included researching what CI/CD are available (and ideally free), and learning how to integrate with Github. We ended up using Github Action. These 2 tasks were are most challenging parts of Sprint 2, which is why every team member was involved. We focused more of our energy on these tasks over this 1 week span; based on previous sprint, it seems the team can handle ~40 story points per week with a full team. While 23 remaining story points may seem like a lot, most of them were focused on either implementing features we were working on towards the end of Sprint 1 but did not finish, or making small tweaks and bug fixes to the game's appearance. These tasks were not as complicated as testing or CI/CD, and thus were completed relatively quickly with little strain on the team.   
</p>

<table>
  <tr>
  <th colspan ="2">
    <h3>
      Decomposed Stories Into Task (start of Sprint 2)
    </h3> 
      </th>
    <tr>
    <th>Stories</th>
    <th>Task</th>
   </tr>
   <tr>
    <td>As a developer I want to design test cases that pass to know that my methods/ classes are performing as intended.</td>
    <td>Implement Unity Testing Suite</td>
  </tr>
     <tr>
    <td>As a developer I want to design CI/CD that should pass all of the team's test to ensure everything in our repository works properly.</td>
    <td>Implement CI/CD Implementation for Unity/Git</td>
  </tr>
       <tr>
    <td>As the player, I would like a visually appealing world to play in.</td>
    <td>Environment Visuals</td>
  </tr>
           <tr>
    <td>As a player, I want to make sure my Hi-Score saves without issues. </td>
    <td>Fix Score Bugs</td>
  </tr>
             <tr>
    <td>As a player, I want to know the progress of my score.</td>
    <td>Update Point Progress Bar</td>
  </tr>

  <tr>
    <td>As the player, I want to have a into/ title screen to help set the atmosphere of the game, and also prompt me to start the game when I am ready. </td>
    <td>Implement Title Screen</td>
  </tr>


  <tr>
    <td>As the player, I want to be able to add additional features, like go back to the main menu/ title screen again.</td>
    <td>Enhanced Game Over Screen</td>
  </tr>
</table>

</details>








##
<details>
<summary>Sprint #1</summary>
<h1>Sprint 1</h1>
<h3>Resource Links</h3>
  
<ul>
  <li><a href="https://swegroup1.itch.io/snake-3d-sprint-1-demo" target="_blank">Sprint 1 Game Demo</a></li>
  <li><a href="https://trello.com/b/UdariJbe/snake-game" target="_blank">Backlog - Trello</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%201/scrum_standup_evidence.PNG" target="_blank">Sprint 1: Daily Scrum Evidence</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%201/Sprint%201%20Review.pdf" target="_blank">Sprint 1: Sprint Review</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%201/burndown.png" target="_blank">Sprint 1: Sprint Burndown Chart</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%201/test_driven_development_evidence.png" target="_blank">Sprint 1: TDD Evidence</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%201/Mob%20Process.png" target ="_blank">Sprint 1: Mob Process Evidence</li>
</ul>
    
<table>
<tr>
  <th colspan ="3">
    <h3>
      Story Point Forecast
    </h3> 
  </th>
    <tr>
    <th>Member</th>
    <th>Task & Rationale</th>
    <th>Points</th>
  </tr>
  <tr>
    <td>Anthony Chiu</td>
    <td>Implement Snake Speed Increase</td>
    <td>15</td>
  </tr>
  <tr>
    <td></td>
    <td>Implement Snake Collision with Snake Segment</td>
    <td>14</td>
          <tr>
    <td></td>
    <td>Implement Snake Collison with Walls</td>
    <td>14</td>
  </tr>
  </tr>
    <tr>
    <td></td>
    <td>Implement Snake Speed Increase</td>
    <td>6</td>
  </tr>
      <tr>
    <td>Anthony Chiu & Taylor Lightbourne</td>
    <td>Collectable Food Object</td>
    <td>8</td>
  </tr>
      <tr>
    <td>Tiara Grier</td>
    <td>Make UI Dynamically Scale with Screen</td>
    <td>3</td>
  </tr>
        <tr>
    <td></td>
    <td>Update Points UI to Increase on Food Collect</td>
    <td>4</td>
  </tr>
    <tr>
    <td>Ryan Smith</td>
    <td>Skybox Visual</td>
    <td>4</td>
       </tr>
       <tr>
          <td>Ryan Smith & Anthony Chiu</td>
    <td>Implement Camera That Follows Snake Object</td>
    <td>17</td>
  </tr>
</tr>
</table>

<p>
Our forecast for sprint 1 consisted of 85 points. The tasks that we wanted to accomplish during this sprint were related to implementing the core gameplay components of a snake game, such as the snake increasing in speed and length when consuming food, and the player receiving a game over when the snake either hits a wall or one of its own body segements. Story points were also given to items that improved the aesthetic of the game and providing a score UI for players. More points were placed onto tasks that focused on the gameplay, and movement of our game. Camera movement has the most story points (17) because we suspected there would be a lot of challenges in implementing a camera system that feel like you are tailing behind the snake (similar to how the camera is in Mario Kart), while also being mindful of providing a non-disorienting viewpoint for the player as the navigate the snake in a 3D space. This is the first time many of the team members are using Unity, and we anticipated this would be the most difficult portion of this scrum. In reality, some of these tasks ended being a lot easier than expected, so some their story points could have been decreased.
</p>
<p>
On the flip side, we anticipated the UI to be one of the easier tasks compared to the gameplay mechanics, thus those related tasks were given much lower story points; however, in reality, these ended up being some of our more challenging aspects of the project. On reflection, we maybe should have given them more points since it was the first time we were designing a UI with Unity and its tools.
</p>



<table>
  <tr>
  <th colspan ="2">
    <h3>
      Decomposed Stories Into Task
    </h3> 
      </th>
    <tr>
    <th>Stories</th>
    <th>Task</th>
   </tr>
   <tr>
    <td>As a player, I want my input to control the Snake character so that my actions have an effect on the game.</td>
    <td>Implement Controllable Snake Object</td>
  </tr>
  <tr>
      <td>As a player, I want to be able to see the snake character and what is in front of me so that I can engage with the game world.</td>
      <td>Implement Camera That Follows Snake Object</td>
  </tr>
       <tr>
    <td>As a player, I want to be able to see game information in a HUD so that I can be motivated to know my status working towards the game objective.</td>
    <td>Implement Points UI</td>
  </tr>
         <tr>
    <td>As a player, I want the Snake's speed to increase as I collect food so that I can be challenged by the games increasingly difficulty.</td>
    <td>Implement Snake Speed Increase</td>
  </tr>
          <tr>
    <td>As a player, I want to be penalized when the Snake character collides with itself so that I can be challenged to avoid it.</td>
    <td>Implement Snake Collision with Walls</td>
  </tr>
            <tr>
    <td>As a player, I want to be penalized when the Snake character collides with itself so that I can be challenged to avoid it.</td>
    <td>Implement Snake Collision with Snake Segment</td>
  </tr>
              <tr>
    <td>As a player, I want the Snake's length to increase as I collect food so that I can be challenged by the games increasingly difficulty.</td>
    <td>Implement Snake Length Increase</td>
  </tr>
                <tr>
    <td>As a player, I want the Snake's length to increase as I collect food so that I can be challenged by the games increasingly difficulty.</td>
    <td>Implement Snake Length Increase</td>
  </tr>
                  <tr>
    <td>As the player, I want the UI interface to adapt to the window size of the game for an easy to read and flexible game experience.</td>
    <td>Make UI dynamically scale with screen</td>
  </tr>
                    <tr>
    <td>As the player, I want to have a visually appealing background (skybox) that will make the game feel more realistic.</td>
    <td>Implement Skybox Visuals</td>
  </tr>
     <tr>
    <td>As a player, I want to be able to collect food objects in the game so that I have an objective while playing.</td>
    <td>Implement Collectable Food Object</td>
  </tr>
       <tr>
    <td>As a player, I want to be able to see the UI update to display my current points when I collect food so that I can know my progress in the game.</td>
    <td>Update Points UI to Increase On Food Collectt</td>
  </tr>
         <tr>
    <td>As the player, I would like a visually appealing representation of the snake that is more advanced and detailed than the traditional 2D snake.</td>
    <td>Model 3D Snake in Blender</td>
  </tr>
           <tr>
    <td>As a player, I want the game to reset at certain points so that I can continue playing.</td>
    <td>Implement Scene Reset Function</td>
  </tr>
             <tr>
    <td>As a player, I want to know when I have lost the game so that I can know what to avoid and try again.</td>
    <td>Implement Game Failure Screen</td>
  </tr>
</table>
</details>

<details>
<summary>Part 1: Product Inception and Planning</summary>
<br>
<h3>Product Vision</h3>
<p>Our product is for gamers who originally played the Snake game. This new and improved Snake is a three-dimensional game that reimagines and expands on the retro 2D Snake game. Unlike the original game, which has limited potential and restricted movement and environments, our product will grow the World of Snake giving the player a better visual experience and making players feel they have more control of the snake in a more open environment.</p>

## <h3>Rationale for Product Backlog Order</h3>
<ol>
  <li>The first user story will focus on implementing a controllable snake object, as it will serve as the game's main character. This is essential for players to be able to navigate the game by moving the snake forward and changing its direction.</li>
  <li>We will incorporate a camera feature that tracks the snake and follows the snake's movements. This will ensure that players have a clear view of the snake's path and the length of its body at all times.</li>
  <li>To build the original game, we will need to introduce a food object for the snake to consume. This element will allow users to earn points and contribute to increasing the game's difficulty as it progresses.</li>
  <li>Next, we will implement a scoring system, which will be displayed on the user interface.</li>
  <li>The next user story will be to develop the functionality for the score to increment whenever the snake collects food. This feature can be developed in parallel with the next two user stories (6 and 7).</li>
  <li>In the next user story, we will introduce the ability for the snake to grow in length upon consuming the food object.</li>
  <li>In line with enhancing the snake's capabilities upon consuming food, we will implement a feature that increases the snake's speed when it eats the food object.</li>
  <li>We will develop the ability to detect when the snake collides with its own body. This development will be vital for future features, so we ordered it to occur prior to those user stories.</li>
  <li>Following this, we will introduce a scene reset function for players to reset the game and start again. Initially, this functionality will be triggered manually for testing, but it will be needed in the last user story when the user loses the game.</li>
  <li>We predict the last user story will focus on implementing a game failure condition. This condition will be triggered when the snake collides with its own body, resulting in the game ending and the scene resetting.</li>
</ol>

## <h3>Definition of Ready</h3>
<ol>
  <li>Implement Controllable Snake Object
    <ul>
      <li><b>Story Points:</b> 7</li>
      <li><b>User Story:</b> As a player, I want my input to control the Snake character so that my actions have an effect on the game.</li>
    </ul>
  </li>
  <li>Implement Camera That Follows Snake Object
    <ul>
      <li><b>Story Points:</b> 17</li>
      <li><b>User Story:</b> As a player, I want to be able to see the snake character and what is in front of me so that I can engage with the game world.</li>
    </ul>
  </li>
  <li><b>Implement Collectable Food Object</b>
    <ul>
      <li><b>Story Points:</b> 8</li>
      <li><b>User Story:</b> As a player, I want to be able to collect food objects in the game so that I have an objective while playing.</li>
    </ul>
  </li>
  <li><b>Implement Points UI</b>
    <ul>
      <li><b>Story Points:</b> 3</li>
      <li><b>User Story:</b> As a player, I want to be able to see game information in a HUD so that I can be motivated to know my status working towards the game objective.</li>
    </ul>
  </li>
  <li><b>Update Points UI to Increase On Food Collect</b>
    <ul>
      <li><b>Story Points:</b> 4</li>
      <li><b>User Story:</b> As a player, I want to be able to see the UI update to display my current points when I collect food so that I can know my progress in the game.</li>
    </ul>
  </li>
  <li><b>Implement Snake Length Increase</b>
    <ul>
      <li><b>Story Points:</b> 15</li>
      <li><b>User Story:</b> As a player, I want the Snake's length to increase as I collect food so that I can be challenged by the games increasingly difficulty.</li>
    </ul>
  </li>
  <li><b>Implement Snake Speed Increase</b>
    <ul>
      <li><b>Story Points:</b> 6</li>
      <li><b>User Story:</b> As a player, I want the Snake's speed to increase as I collect food so that I can be challenged by the games increasingly difficulty.</li>
    </ul>
  </li>
  <li><b>Implement Snake Collision with Snake Segment</b>
    <ul>
      <li><b>Story Points:</b> 14</li>
      <li><b>User Story:</b> As a player, I want to be penalized when the Snake character collides with itself so that I can be challenged to avoid it.</li>
    </ul>
  </li>
  <li><b>Implement Scene Reset Function</b>
    <ul>
      <li><b>Story Points:</b> 13</li>
      <li><b>User Story:</b> As a player, I want the game to reset at certain points so that I can continue playing.</li>
    </ul>
  </li>
  <li><b>Implement Game Failure Condition</b>
    <ul>
      <li><b>Story Points:</b> 8</li>
      <li><b>User Story:</b> As a player, I want to know when I have lost the game so that I can know what to avoid and try again.</li>
    </ul>
  </li>
</ol>
</details>

