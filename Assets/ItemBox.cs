using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
	private Renderer renderer;

	public Color originalColor;
	public Color changedColor;

	private void Start()
	{
		renderer = GetComponent<Renderer>();
		originalColor = renderer.material.color;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "EndPoint")
		{
			renderer.material.color = changedColor;
		}
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "EndPoint")
		{
			renderer.material.color = changedColor;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "EndPoint")
		{
			renderer.material.color = originalColor;
		}
	}
}
