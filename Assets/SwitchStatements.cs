using UnityEngine;
using System.Collections;

public class SwitchStatements : MonoBehaviour {
	public int smarts = 5;


	void Update()
	{
		switch (smarts)
		{
		case 5:
			print ("Well Aren't we a mr. Smarty Pants Today?");
			break;
		case 4:
			print ("Doing quite well today are we?");
			break;
		case 3:
			print ("There Somein you want?");
			break;
		case 2:
			print ("ME WANT COOKIE!");
			break;
		case 1:
			print ("Mmmmurup, BUrp mmmmmm durrrrr");
			break;
		default:
			print ("Yeah No, not happening");
			break;
		}
	}
}
