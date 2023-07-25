using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // DISPARO
	public Transform PuntoDisparo;
	public GameObject Bala;
	//
	[SerializeField] float velocidad = 6f;
	public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool isGrounded = true;

	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
		transform.Translate(
			horizontal*velocidad*Time.deltaTime, 0, 0
		);
		
		// Disparo de la bala
		if(Input.GetKeyDown(KeyCode.C))
		{
			Instantiate(Bala, PuntoDisparo.position, Quaternion.identity);
		}
		// Detectar el salto al presionar la tecla "Espacio"
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }
	
	private void OnTriggerEnter2D(Collider2D collision){
		/*Debug.Log("Choque");
		GetComponent<SpriteRenderer>().color = Color.yellow;*/ // Personaje cambia de color con el choque
	}
	private void Jump()
    {
        // Aplicar fuerza vertical para hacer que el jugador salte
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        isGrounded = false;
    }

    // Agregar un detector de colisión para detectar cuándo el jugador está en el suelo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

}
