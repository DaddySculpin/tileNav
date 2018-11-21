using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerController : MonoBehaviour {

	public bool isActive = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//void OnCollisionEnter(Collider other)
	//{
	//	Debug.Log("trigger onCollisionEnter");
	//}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("trigger onTriggerEnter");
	}

	void OnTriggerExit(Collider other)
	{
		Debug.Log("trigger onTriggerExit");
	}
}
