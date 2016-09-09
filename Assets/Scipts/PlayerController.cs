using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float thrust;
	public Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal * thrust, 0.0f, moveVertical * thrust);
		rb.AddForce (movement);
	}

}
