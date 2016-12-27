using UnityEngine;
using System.Collections;
using System;

public class RoomsController: MonoBehaviour {

	public Const.RoomCondition condition;
	public RoomData roomData;
//	public GameObject floor;
	public Transform centerPosition;
	private Vector3 target;
//	private Vector3 centerPosition = GetComponent<Renderer>().bounds.center;
	public Vector3 defaultPosition;

	public void SetDefaultPosition () {
		defaultPosition = transform.position;
	}

	public void SetTargetPosition (Vector3 pos) {
		target = pos;
	}

	public void CancelSelect () {
		target = defaultPosition;
	}

	public void GrabObject (GameObject obj) {
		FixedJoint fj = GetComponent<FixedJoint> ();
		fj.connectedBody = obj.GetComponent<Rigidbody> ();
	}

	public void ChangeCondition (Const.RoomCondition cond) {
		condition = cond;
	}

	public void Update () {
		switch (condition) {
		case Const.RoomCondition.Displayed:
			transform.position = Vector3.Lerp (
				transform.position,
				target,
				Time.deltaTime);
			break;
		case Const.RoomCondition.Selected:
			break;
		case Const.RoomCondition.Canceled:
			break;

		}
	}
}