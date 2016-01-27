using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {
	//These are my variviables 
	float officeHotTemp = 45.03f;
	float officeColdTemp = 20.4f;
	float officeRoomTemp = 60.03f;


	// Use this for initialization
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();

		coffeeTemperature -= Time.deltaTime * 5f;
	}


	void TempTest ()
	{
		// If the coffee's temperature is greater than the hottest drinking temperature...
		if(coffeeTemperature > hotLimitTemperature)
		{
			// ... do this.
			print("Coffee is too hot.");
		}
		// If it isn't, but the coffee temperature is less than the coldest drinking temperature...
		else if(coffeeTemperature < coldLimitTemperature)
		{
			// ... do this.
			print("Coffee is too cold.");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("Coffee is just right.");
		}
	}
}
