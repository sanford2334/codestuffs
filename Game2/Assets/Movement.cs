using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public GameObject temp;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	if (Input.anyKeyDown)
		{
			Object.Instantiate(temp);
		}
	}
}
