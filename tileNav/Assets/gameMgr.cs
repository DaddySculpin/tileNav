using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMgr : MonoBehaviour {

	public Transform emitterOb;
	public GameObject prefab;
	public int spawnNum = 0;

	// Use this for initialization
	void Start () {
		//InvokeRepeating("spawnIt", 2.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void spawnIt()
	{
		//create new object from prefab
		//passive rigidBody motion or active transform on update?
		spawnNum++;
		//Instantiate(prefab, new Vector3(x, y, 0), Quaternion.identity);

		GameObject spawnInstance;
		spawnInstance = Instantiate(prefab, emitterOb.position, emitterOb.rotation);
		//spawnInstance.AddForce(emitterOb.forward * 250);

	}
}
