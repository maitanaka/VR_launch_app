using UnityEngine;
using System.Collections;
using System;

public class RoomController: MonoBehaviour {

	public RoomData roomData;
	public Vector3 defaultPosition;
	private Vector3 target;

	// public Const.RoomCondition condition;
//	public RoomData roomData;
//	public Transform centerPosition;
//	private Vector3 target;
//	public Vector3 defaultPosition;
//
	// public void SetDefaultPosition () {
	// 	defaultPosition = transform.position;
	// }

	// public void SetTargetPosition (Vector3 pos) {
	// 	target = pos;
	// }

	// public void CancelSelect () {
	// 	target = defaultPosition;
	// }

	// public void GrabObject (GameObject obj) {
	// 	FixedJoint fj = GetComponent<FixedJoint> ();
	// 	fj.connectedBody = obj.GetComponent<Rigidbody> ();
	// }

	// public void ChangeCondition (Const.RoomCondition cond) {
	// 	condition = cond;
	// }

	// public void Update () {
	// 	switch (condition) {
	// 	case Const.RoomCondition.Displayed:
	// 		transform.position = Vector3.Lerp (
	// 			transform.position,
	// 			target,
	// 			Time.deltaTime);
	// 		break;
	// 	case Const.RoomCondition.Selected:
	// 		break;
	// 	case Const.RoomCondition.Canceled:
	// 		break;

	// 	}
	// }
}
