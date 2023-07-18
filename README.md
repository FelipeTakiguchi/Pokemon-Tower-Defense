# Pokemon-Tower-Defense

## Description
Classes
	Game
		- Money
		- CapturedPokemons[] class Pokémon
		- IsPaused
		- Phase
		Methods
			- Start()
			- Pause()
			- 
	Pokémon
		Turret:
			- Name
			- Level
			- Experience
			- Attack class Attack
			- SpecialAttack class Attack
			- Evolutions
			Methods
				- GiveDamage()
		Wild:
			- Name
			- Life
			- Level
			- Speed
			- Weakness ?
			- Resist. ?
			- Location class Point
			Methods
				- GoTo() (for com continue)
				- ReceiveDamage()
	Attack
		- Damage
		- Sprites[]
		- Cooldown
		- Type?
		- Target class Pokemon
	Path
		- PhaseId
		- Points[] class Point
	Point
		- X
		- Y
	Wave
		- WildPokemons[] Pokémon
		- End
	Phase
		- Id
		- Waves[] class Wave
		- End
		- PhasePath class Path
		Methods
			- Next(Locations[] class Point)
	Pokeball
		- Location class Point
		Methods
			- CapturePokemon()

