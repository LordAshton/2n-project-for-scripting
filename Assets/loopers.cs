﻿using UnityEngine;
using System.Collections;

public class loopers : MonoBehaviour {
	
	int numberOfStuff = 7;


	void Start ()
	{
		for(int i = 0; i < numberOfStuff; i++)
		{
			Debug.Log("Something of Stuff: " + i);
		}
	}



} 

