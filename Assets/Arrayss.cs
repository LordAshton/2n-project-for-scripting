using UnityEngine;
using System.Collections;

public class Arrayss : MonoBehaviour 
{
	public GameObject[] players;

	void Start ()
	{
		players = GameObject.FindGameObjectsWithTag("Player");

		for(int i = 0; i < players.Length; i++)
		{
			Debug.Log("GameObject "+i+" is named "+players[i].name);
		}
	}
}