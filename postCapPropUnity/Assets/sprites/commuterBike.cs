using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class commuterBike : MonoBehaviour {

	private Vector3 point1;
	private Vector3 point2;
	private Vector3 goal;

	public int distance;
	public int speed;

	// Use this for initialization
	void Start () {
		point2 = transform.position;
		point1 = transform.position + new Vector3 (distance,0,0);
		goal = point1;

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position == point1) {
			goal = point2;
			transform.localEulerAngles = new Vector3 (0,180,0);
		} else if (transform.position == point2) {
			goal = point1;
			transform.localEulerAngles = new Vector3 (0,0,0);
		}
		transform.position = Vector3.MoveTowards (transform.position,goal,speed*Time.deltaTime);
	}
}
