using UnityEngine;
using System.Collections;

public class classesAndStuff : MonoBehaviour
{
	public int coke;
	public int pepsi;


	private int stapler;
	private int sellotape;


	public void DrinkMachine (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Drink total: " + answer);
	}


	private void OfficeSort (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Office Supplies total: " + answer);
	}
}

