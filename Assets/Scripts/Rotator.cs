using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	void Update () {
		transform.rotation = Quaternion.Euler(new Vector3 (45, 90, 45) * Time.deltaTime/2 + transform.rotation.eulerAngles);
	}
}
