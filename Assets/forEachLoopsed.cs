using UnityEngine;
using System.Collections;

public class forEachLoopsed : MonoBehaviour {

	void Start () 
	{
		string[] strings = new string[4];

		strings[0] = "Time's Up";
		strings[1] = "Let's Do this!";
		strings[2] = "Leeroy Jenkins!!!";
		strings[3] = "Stick to the plan!";

		foreach(string item in strings)
		{
			print (item);
		}
	}
}
