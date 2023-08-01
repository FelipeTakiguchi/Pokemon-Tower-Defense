![alt text](https://i0.wp.com/multarte.com.br/wp-content/uploads/2019/03/pokemon-png-logo.png?fit=2000%2C736&ssl=1)
# Pokemon-Tower-Defense
<h2>a Pokémon game programmed with C# and Windows Forms.</h2>
<h3>Features:</h3>
<ul>
  <li>Caught system</li>
  <li>Inventory</li>
  <li>Phases and waves</li>
  <li>Actually, almost 80 different pokémons</li>
</ul>

## Description
<h2>Classes</h2>
	<h3>Game</h3>
		<ul>
  			<li>Money</li>
			<li>CapturedPokemons[] class Pokémon</li>
			<li>IsPaused</li>
			<li>Phase</li>
		</ul>
		<h5>Methods</h5>
		<ul>
			<li>Start()</li>
			<li>Pause()</li>
		</ul>
	<h3>Pokémon</h3>
		<h4>Turret:</h4>
		<ul>
			<li>Name</li>
			<li>Level</li>
			<li>Experience</li>
			<li>Attack class Attack</li>
			<li>SpecialAttack class Attack</li>
			<li>Evolutions</li>
		</ul>
			<h5>Methods</h5>
			<ul>
				<li>GiveDamage()</li>
			</ul>
		<h4>Wild:</h4>
		<ul>
			<li>Name</li>
			<li>Life</li>
			<li>Level</li>
			<li>Speed</li>
			<li>Weakness ?</li>
			<li>Resist. ?</li>
			<li>Location class Point</li>
		</ul>
			<h5>Methods</h5>
			<ul>
				<li>GoTo() (for com continue)</li>
				<li>ReceiveDamage()</li>
			</ul>
	<h3>Attack</h3>
		<ul>
			<li>Damage</li>
			<li>Sprites[]</li>
			<li>Cooldown</li>
			<li>Type?</li>
			<li>Target class Pokemon</li>
		</ul>
	<h3>Path</h3>
		<ul>
			<li>PhaseId</li>
			<li>Points[] class Point</li>
		</ul>
	<h3>Point</h3>
		<ul>
			<li>X</li>
			<li>Y</li>
		</ul>
	<h3>Wave</h3>
		<ul>
			<li>WildPokemons[] Pokémon</li>
			<li>End</li>
		</ul>
	<h3>Phase</h3>
		<ul>
			<li>Id<li>
			<li>Waves[] class Wave</li>
			<li>End</li>
			<li>PhasePath class Path</li>
		</ul>
		<h5>Methods</h5>
		<ul>
			<li>Next(Locations[] class Point)</li>
		</ul>
	<h3>Pokeball</h3>
		<ul>
		<li>Location class Point</li>
		</ul>
		<h5>Methods</h5>
		<ul>
			<li>CapturePokemon()</li>
		</ul>

