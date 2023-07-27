using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Multijugador : MonoBehaviour
{
	[SerializeField] float velocidad = 6f;
	public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool isGrounded = true;

	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
		transform.Translate(
			horizontal*velocidad*Time.deltaTime, 0, 0
		);
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }
	private void Jump()
    {
        // Aplicar fuerza vertical para hacer que el jugador salte
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        isGrounded = false;
    }
}
