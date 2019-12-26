﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private Rigidbody body;

	private float speed = 10f;

	private void Start()
	{
		body = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		float x = Input.GetAxis("Horizontal");
		float y = body.velocity.y;
		float z = Input.GetAxis("Vertical");

		Vector3 velocity = new Vector3(x, 0, z) * speed;
		velocity.y = y;

		body.velocity = velocity;
	}
}
