using UnityEngine;
using System.Collections;

public class scopeAndStuff : MonoBehaviour 

	{
		public int alpha = 5;


		private int beta = 0;
		private int gamma = 5;


	private classesAndStuff myOtherClass;


		void Start ()
		{
			alpha = 29;

		myOtherClass = new classesAndStuff();
			myOtherClass.DrinkMachine(alpha, myOtherClass.coke);
		}


		void Example (int pens, int crayons)
		{
			int answer;
			answer = pens * crayons * alpha;
			Debug.Log(answer);
		}


		void Update ()
		{
			Debug.Log("Alpha is set to: " + alpha);
		}
	}
