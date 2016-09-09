using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float thrust;
	public Rigidbody rb;
    private int count;
    public Text countText;
    public Text winText;

	void Start()
	{
        count = 0;
        setCountText();
        winText.text = "";
        rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal * thrust, 0.0f, moveVertical * thrust);
		rb.AddForce (movement);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pickups")
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
    }
    void setCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count>=9)
        {
            winText.text = "You win!";
        }
    }
}
