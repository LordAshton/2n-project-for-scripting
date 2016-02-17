using UnityEngine;
using System.Collections;

public class AllLoops : MonoBehaviour {

	float forLoops = 45.00f;
	float whileLoops = 20.00f;
	float doWhileLoops = 60.03f;
	float foreachloop = 60.03f;
	float variable = 60.03f;



	// Use this for initialization
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TempTest();

		variable -= Time.deltaTime * 5f;
		//Debug.Log (officeTemp);
	}


	void TempTest ()
	{

		// for loop
		if(variable == forLoops)
		{


		}
		// while loops
		else if(variable == whileLoops)
		{


		}

		else if(variable < doWhileLoops)
		{


		}

		//  and for the last one
		else
		{


		}
	}
}
