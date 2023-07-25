using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
	public int lifes = 3;
	private void OnTriggerEnter2D(Collider2D collision) 
	{
		if (collision.CompareTag("bala"))
		{   
		 lifes -= 1;	  
            if (lifes <= 0)
            {
                Destroy(gameObject);
            }		 
		}
	}
}
