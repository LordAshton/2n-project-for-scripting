using UnityEngine;
using System.Collections;

public class Datastypes : MonoBehaviour {
	void Start () 
	{
		//Value type thing
		Vector3 pos = transform.position;
		pos = new Vector3(3, 2, 5);

		//Reference type thing
		Transform tran = transform;
		tran.position = new Vector3(3, 2, 5);
	}
}