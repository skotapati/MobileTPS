﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class AimController : MonoBehaviour {
	public float upAim;
	public float rightAim;
	public float direction;
	public bool shooting;
	public float shootThreshold;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		upAim = CrossPlatformInputManager.GetAxis ("Up");
		rightAim = CrossPlatformInputManager.GetAxis ("Right");
		if (Mathf.Pow (upAim, 2) + Mathf.Pow (rightAim, 2) >= shootThreshold) {
			shooting = true;
		} else {
			shooting = false;
		}
		direction = Vector2.Angle (new Vector2 (0,1), new Vector2 (upAim, rightAim));
		if (upAim < 0) {
			direction = -direction;
		}
	}
}
