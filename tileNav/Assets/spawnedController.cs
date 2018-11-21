using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnedController : MonoBehaviour {

	public float speed = 2.0f;
	public bool isTriggered;
	//private collider
	// Use this for initialization
	void Start () {
		Debug.Log ("Im alive!");
	}
	
	// Update is called once per frame
	void Update () {
		//move me forward
		//transform.offset = transform.forward * speed;

		transform.Translate (Vector3.forward * Time.deltaTime * speed);
		//check for colliisons
	}

	//void OnCollisionEnter(Collider other)
	//{
	//	Debug.Log("ball onCollisionEnter");
	//}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("ball onTriggerEnter");
		isTriggered = true;
		if(other.tag == "redirector")
		{
			//change rotation to match object
			Debug.Log("hitting redirector");
			transform.rotation = other.transform.rotation;
		}
		if(other.tag == "pitfall")
		{
			//change rotation to match object
			Debug.Log("hitting pitfall");
			speed = 0.0f;
			Destroy(gameObject, 1);
		}

	}

	void OnTriggerExit(Collider other)
	{
		isTriggered = false;
	}
}
