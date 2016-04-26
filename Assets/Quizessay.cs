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
			// is named is the statement to be printed, " ends the text that will be printed,
			// + will add something to the previous statement, players is a variable,
			// [ start bracket, i is a value, ] ending bracket, . syntax, name is a varible, ) is the end bracket for the whole value
			// ; ends the line
		} 
		// } is the closing bracket for the bool.

		Direction myDirection;
		// direction is the start of a function, myDirection is the name of a variable, ; ends the line

		myDirection = Direction.North;
		// myDirection is the name of a variable, = sets it equal to, direction is the function, . is syntax, North is a string value,
		// ; ends the line

		ReverseDirection (myDirection);
		//ReverseDirection is the function, ( is the start bracket, myDirection is the string variable, ) is the closing bracket,
		// ; ends the line

	}
	// } is the end bracket for the function.
	void Update ()
	// void is a function argument, it means no value, Update is the time the function "fires", ( opening bracket, ) closing bracket
	{
		// { is the opening bracket for the function.
		if(Input.GetKeyDown(KeyCode.Space))
// if is the type of function statement, (is the opening bracket, Input is the input recievied, . syntax, GetKeyDown is the type of input,
			// ( is the opening bracket, KeyCode is the specific input it's looking for, . syntax, Space is the spacebar key, 
			// ) is the ending bracket, ) is the ending bracket
			TemperatureTest();
		// TemperatureTest is the name of a function, ( opening bracket, ) Closing bracket, ; ends the line

		coffeeTemperature -= Time.deltaTime * 5f;
		// coffeeTemperature is the variable, -= means to decrease by "this" every time, Time is a variable, . syntax, 
		// deltaTime is the time in seconds what the last frame took, * is the multiplyer, 5f is the value, ; ends the line.
	}
	// } closes the function
	void TemperatureTest ()
	// void is a function argument, it means no value, TemperatureTest is the function, ( opening bracket, ) closing bracket
	{
		//{ opens the function
		string tooHot = "Coffee is too hot.";
		// string is the type of variable, tooHot is the name of the string variable, = equal to, "starts the text to be printed
		// coffee is too hot. is the text, " ends the to be printed text, ; ends the line
		if(coffeeTemperature > hotLimitTemperature)
	// if is the type of function statement, (is the opening bracket, coffeeTemperature is the variable, > is greater than,
	// hotLimitTemperature is a variable, ) is the ending bracket
		{
			// { is the opening bracket
			print(tooHot);
			// print is the command to print, ( is a opening bracket, tooHot is the variable, ) is the closing bracket, ; ends the line
		}
		// } closes
	}
	// } closes

	enum Direction{North, East, South, West};
	// enum is the, Direction is the variable, { is the start bracket for the enumeration, North is a value it can have,
	// East is a value it can have, SOuth is a value it can have, West is a value it can have, } is the ending bracket, ; ends the line

	void ReverseDirection (Direction dir)
	// void is a function argument, it means no value, ReverseDirection is the name of the function, ( starting bracket, 
	// Direction sets the amount of values dir can have, dir is the variable, ) closing bracket
	{
		// { opening Bracket
		if(dir == Direction.North)
			// if starts an if statement, ( opening Bracket, dir is the variable, == sets it equal to, Direction.North is the value, 
			// ) is the closeing bracket
			dir = Direction.South;
		//dir is the variable, = sets it equal to, Direction.South is the value, ; ends the line
		// This will detect if the variable is north and if it is north it will change the value to be south.


	}
	// } closing bracket
	void Greet()
	// void is a function argument, it means no value, Greet is the function, ( opening bracket, ) Closing bracket
	{
		// { opening bracket for a function
		switch (myInt)
		// switch is the start of a switch statement, ( opening bracket, myInt is the value it pulls, ) closing bracket
		{
		// { opening bracket
		case 5:
			// case is the label that specifies a constant value, 5 is the value, : is the syntax to start what happens when it's value is the same
			print ("Why hello there good sir! Let me teach you about Trigonometry!");
			// print will print out a string to the console, ( opening bracket, "Why hello there good sir! Let me teach you about Trigonometry!" is what is printed) closing bracket, ; ends the line
			break;
			// break is the command that will stop the function from running. usally it's after the main part of the function.
		case 4:
			// case is the label that specifies a constant value, 4 is the value, : is the syntax to start what happens when it's value is the same
			print ("Hello and good day!");
			// print will print out a string to the console, ( opening bracket, "Hello and good day!" is the string to be printed, ) closing bracket, ; ends the line
			break;
			// break is the command that will stop the function from running. usally it's after the main part of the function.
		case 3:
			// case is the label that specifies a constant value, 3 is the value, : is the syntax to start what happens when it's value is the same
			print ("Whadya want?");
			// print will print out a string to the console, ( opening bracket, "Whadya want?" is the string to be printed, ) closing bracket, ; ends the line
			break;
			// break is the command that will stop the function from running. usally it's after the main part of the function.
		case 2:
			// case is the label that specifies a constant value, 2 is the value, : is the syntax to start what happens when it's value is the same
			print ("Grog SMASH!");
			// print will print out a string to the console, ( opening bracket, "Grog SMASH!" is the string to be printed) closing bracket, ; ends the line
			break;
			// break is the command that will stop the function from running. usally it's after the main part of the function.
		case 1:
			// case is the label that specifies a constant value, 1 is the value, : is the syntax to start what happens when it's value is the same
			print ("Ulg, glib, Pblblblblb");
			// print will print out a string to the console, ( opening bracket, "Ulg, glib, Pblblblblb" is the string to be printed) closing bracket, ; ends the line
			break;
			// break is the command that will stop the function from running. usally it's after the main part of the function.
		default:
			// default is the anything else, if it wasen't covered in the case statements then it's here where it will be catched, : is the syntax to start what happens.
			print ("Incorrect intelligence level.");
			// print will print out a string to the console, ( opening bracket, "Incorrect intelligence level." is the string to be printed) closing bracket, ; ends the line
			break;
			// break is the command that will stop the function from running. usally it's after the main part of the function.
		} 
		// closing bracket
	}
	// closing bracket


