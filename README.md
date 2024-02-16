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
<ul>
  <li><a href="https://trello.com/b/UdariJbe/snake-game" target="_blank">Trello</a></li>
</ul>

## <h3>Product Vision</h3>
<p>Our product is for gamers who originally played the Snake game. This new and improved Snake is a three-dimensional game that reimagines and expands on the retro 2D Snake game. Unlike the original game, which has limited potential and restricted movement and environments, our product will grow the World of Snake giving the player a better visual experience and making players feel they have more control of the snake in a more open environment.</p>

## <h3>The rationale for Product Backlog Order</h3>
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
