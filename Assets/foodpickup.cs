using UnityEngine;
using System.Collections;

public class foodpickup : MonoBehaviour {

	private Teacher.ResourceController ResourceController;
	public int AmountOffood = 5;

	void Awake()
	{
		ResourceController = GameObject.Find("ResourceController").GetComponent<Teacher.ResourceController>();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player") // if the hitting object has a player tag
		{
			ResourceController.Food += AmountOffood; // Add wood to resourcecontroller
			Destroy(gameObject);  // Destroy itself after it has been picked up
		}
	}
}
