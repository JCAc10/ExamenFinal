using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
	[SerializeField] private float VelocidadParallax;
    private Transform camaraTransform;
    private Vector3 posicionPrevia;

    // Start is called before the first frame update
    void Start()
    {
        camaraTransform = Camera.main.transform;
        posicionPrevia = camaraTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float posicion = (camaraTransform.position.x - posicionPrevia.x) * VelocidadParallax;
        transform.Translate(new Vector3(posicion, 0, 0));
        posicionPrevia = camaraTransform.position;
    }
}
