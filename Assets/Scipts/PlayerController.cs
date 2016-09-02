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
		Vector3 movement = new Vector3 (moveHorizontal * 3f, 0.0f, moveVertical * 3f);
		rb.AddForce (movement);
	}

}
