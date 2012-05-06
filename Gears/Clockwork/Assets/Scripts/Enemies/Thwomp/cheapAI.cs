using UnityEngine;
using System.Collections;

public class cheapAI : MonoBehaviour {
	
	bool done = false;
	int ran;
	// Use this for initialization
	void Start () 
	{
		gameObject.AddComponent("Rigidbody");
		Rigidbody temp = (Rigidbody)gameObject.GetComponent("Rigidbody");
		temp.freezeRotation = true;
		StartCoroutine("stuff");
		transform.localScale = new Vector3 (transform.localScale.x*0.3f, transform.localScale.y * 0.3f, transform.localScale.z);
	}
	
	void reset()
	{
		StartCoroutine("stuff");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (done)
		{
			done = false;
			ran = Random.Range(-32, 32);
			reset();
		}
	}
	
	public IEnumerator stuff()
	{
		yield return new WaitForSeconds(10);
		transform.position = new Vector3(transform.position.x, transform.position.y + 30 + ran, transform.position.z);
		done = true;
	}
}
