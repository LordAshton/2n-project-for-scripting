using UnityEngine;
using System.Collections;

public class whileLoopsed : MonoBehaviour {

	int donutsinthebox = 12;


	void Start ()
	{
		while(donutsinthebox > 0)
		{
			Debug.Log ("I've eaten a donut!");
			donutsinthebox--;
		}
	}
}
