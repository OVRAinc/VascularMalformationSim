using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{
	public GameObject malform;

	private bool isInjected;

	private void Start()
	{
		isInjected = false;
		if (malform == null)
		{
			Debug.Log("Error: Malform Object not attached.");
			Application.Quit();
		}
	}

	private void Update()
	{
		if(isInjected)
			malform.transform.localScale *= (1 - 0.1f * Time.deltaTime);
	}

	private void OnTriggerEnter(Collider other)
	{
        Debug.Log("Entered Vessel!");
		isInjected = true;
	}

	private void OnTriggerExit(Collider other)
	{
		Debug.Log("Exited Vessel!");
		isInjected = false;
	}
}
