using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public Text txtVida;
    public int vidas = 3;
    public Text txtMonedas;
    public int monedas = 0;
	public Text txtDiamantes;
    public int diamantes = 0;
	public Text txtTotal;
    public int total = 0;
	
    void Start()
    {
        
    }

    void Update()
    {
        txtVida.text = vidas.ToString();
		txtMonedas.text = monedas.ToString();
		txtDiamantes.text = diamantes.ToString();
		txtTotal.text = total.ToString();
    }
	private void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.CompareTag("corazon"))
        {
            vidas += 1;
            txtVida.text = vidas.ToString();
			total += vidas;
			txtTotal.text = total.ToString();
            Debug.Log(gameObject.tag);
        }
		if (other.gameObject.CompareTag("moneda"))
        {
            monedas += 1;
            txtMonedas.text = monedas.ToString();
			total += monedas;
			txtTotal.text = total.ToString();
            Debug.Log(gameObject.tag);
        }
		if (other.gameObject.CompareTag("diamante"))
        {
            diamantes += 1;
            txtDiamantes.text = diamantes.ToString();
			total += diamantes;
			txtTotal.text = total.ToString();
            Debug.Log(gameObject.tag);
        }
		 if (other.gameObject.CompareTag("enemigo"))
        {
            vidas -= 1;
            if (vidas <= 0)
            {
				Debug.Log("Usted acaba de perder");
				GetComponent<SpriteRenderer>().color = Color.red;
                //SceneManager.LoadScene(0);
            }
        }
		
	}
}
