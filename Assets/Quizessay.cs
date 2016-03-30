//Instructions, Identify and explain each line in this script using comments.
//this is a comment.
using UnityEngine;
// this declares the database or the program this is for. 
// using is a declaration of what system is used. UnityEngine is the program used.
// ; ends the line
using System.Collections;
// this declares the table it is going to use. using is a declaration of what system is used.
// System.Collections is the table in the program that is being referenced. 
// ; ends the line

public class MidTerm : MonoBehaviour {
	//this sets up the whole file, and has to contain the name of the file it is in.
	// public is the access modifier, used for global or local variables.
	// class is a construct that sets the behaviour of the file
	// midterm is the name of the file
	// : is syntax for class declaration
	// MonoBehaviour is the behaviour of the whole program
	// { is the start bracket of the program

	public int myInt = 6;
	// public is the access modifier, used for global or local variables. Sets it as a global variable
	// int is setting up for a variable, myInt is the variable, = is the syntax to set it's value.
	// 6 is the value of the variable, ; ends the line
	float coffeeTemperature = 85.0f;
	// float is the type of variable, coffeeTemperature is the variable, = is the syntax to set it's value.
	// 85.0f is the value of the variable, ; ends the line.
	private float hotLimitTemperature = 70.0f;
	// private is the access modifier, used for global or local variables. sets it as a local variable.
	// float is the type of variable, hotLimitTemperature is the variable, = is the syntax to set it's value.
	// 70.0f is the value of the variable, ; ends the line.
	public float coldLimitTemperature = 40.0f;
	// public is the access modifier, used for global or local variables. sets it as a global variable.
	// float is the type of variable, coldLimitTemperature is the variable, = is the syntax to set it's value.
	// 40.0f is the value of the variable, ; ends the line.
	int numEnemies = 3;
	// int is setting up for a variable, numEnemies is the variable, = is the syntax to set it's value.
	// 3 is the value of the variable, ; ends the line
	private MidTerm myMidterm;
	// private is the access modifier, used for global or local variables. sets it as a local variable.
	// MidTerm is the variable, myMidterm is the string value it is set as. ; ends the line.
	public GameObject[] players;
	// public is the access modifier, used for global or local variables. sets it as a global variable.
	// GameObject is an array, [ is the start of the array, ] is the closing of the array. players is what is put into the array,
	// ; ends the line.

	void Start ()
	// void is a function argument, it means no value, start is when the function starts, ( is the first bracket for referencing something
	// 	) is the ending bracket for the reference.

	{
		// { is the first bracket for the function
		TemperatureTest();
		// TemperatureTest is the variable, ( is the first bracket for the value of the variable, ) is the ending bracket for the variable, ; ends the line

		Debug.Log (myInt);
		// debug.log is the code that will post the value of whatever item is specified, 
		//( is the first bracket for the value of the variable, myInt is the variable, ) is the ending bracket for the variable, ; ends the line

		for(int i = 0; i < numEnemies; i++)
			// for is the start of a bool, ( is the first bracket for the scecifcations of the bool, int is specifiying the variable,
			// i is the variable, = sets the value equal to, 0 is the value, ; ends the value ditermiation, i is the value, < is less than,
			// numEnemies is the other value being compared, ; ends the comparison, i is the value, ++ increases the value by 1 each time,
			// ) closes the start of the bool.
		{
			// { is the begining of the content for the bool.
			Debug.Log("Creating enemy number: " + i);
			// debug.log is the code that will post the value of whatever item is specified, 
			// ( is the first bracket for the value of the variable, " starts a section of the text that will be printed,
			// Creating enemy number: is the statement to be printed, " ends the text that will be printed,
			// + will add something to the previous statement, i is the value,
			// ) is the ending bracket for the variable, ; ends the line

		}
		// } is the closing bracket for the bool.
		myMidterm = GetComponent<MidTerm>();
		// myMidterm is the string or varible, = sets it equal to, GetComponent allows us to specify a certian varible that is local somewhere,
		// < is the bracket for accessing local varibles, MidTerm is the varible, > is the end bracket for local varibles,
		//( is the first bracket for referencing something,	) is the ending bracket for the reference, ; ends the line.
		for(int i = 0; i < players.Length; i++)
			// for is the start of a bool, ( is the first bracket for the scecifcations of the bool, int is specifiying the variable,
			// i is the variable, = sets the value equal to, 0 is the value, ; ends the value ditermiation, i is the value, < is less than,
			// players is the variable, . is syntax, Length is the length of players as a number, ; ends the comparison, i is the value, ++ increases the value by 1 each time,
			// ) closes the start of the bool.
		{
			// { is the begining of the content for the bool.
			Debug.Log("Player Number "+i+" is named "+players[i].name);
			// debug.log is the code that will post the value of whatever item is specified, 
			// ( is the first bracket for the value of the variable, " starts a section of the text that will be printed,
			// Player Number is the statement to be printed, " ends the text that will be printed,
			// + will add something to the previous statement, i is the value, + will add something to the previous statement,
			// " starts a section of the text that will be printed,
			// is named is the statement to be printed, " ends the text that will be printed, + will add something to the previous statement,
			// players is the variable, 







			// ) is the ending bracket for the variable, ; ends the line
		} 
		// } is the closing bracket for the bool.

		Direction myDirection;

		myDirection = Direction.North;

		ReverseDirection (myDirection);

	}
	// } is the end bracket for the function.
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();

		coffeeTemperature -= Time.deltaTime * 5f;
	}

	void TemperatureTest ()
	{
		string tooHot = "Coffee is too hot.";
		if(coffeeTemperature > hotLimitTemperature)
		{
			print(tooHot);
		}
	}

	enum Direction{North, East, South, West};

	void ReverseDirection (Direction dir)
	{
		if(dir == Direction.North)
			dir = Direction.South;


	}

	void Greet()
	{
		switch (myInt)
		{
		case 5:
			print ("Why hello there good sir! Let me teach you about Trigonometry!");
			break;
		case 4:
			print ("Hello and good day!");
			break;
		case 3:
			print ("Whadya want?");
			break;
		case 2:
			print ("Grog SMASH!");
			break;
		case 1:
			print ("Ulg, glib, Pblblblblb");
			break;
		default:
			print ("Incorrect intelligence level.");
			break;
		}
	}


