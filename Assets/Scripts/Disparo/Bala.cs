using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Rigidbody2D MyRb;
	public float velocidad;
    void Start()
    {
        MyRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MyRb.velocity = new Vector2(+velocidad, 0);
		Destroy(gameObject, 5f);
    }
}
