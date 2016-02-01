using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {
	//These are my variviables 
	float officeHotTemp = 45.00f;
	float officeColdTemp = 20.00f;
	float officeTemp = 60.03f;



	// Use this for initialization
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TempTest();

		officeTemp -= Time.deltaTime * 5f;

	}


	void TempTest ()
	{
		
		// if the office is hotter than it should be
		if(officeTemp > officeHotTemp)
		{
			
			print("This Office is too dang hot!");
		}
		// If it's colder than ice
		else if(officeTemp < officeColdTemp)
		{
			
			print("EEk! who turned on the A/C?!?!  Guys it's winter right now...");
		}
		//  and for the last one
		else
		{
			
			print("The office temp is just fine");
		}
	}
}
