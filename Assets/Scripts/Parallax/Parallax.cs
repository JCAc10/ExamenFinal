using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Transform camaraTransform;
	private Vector3 posicionPrevia;
    void Start()
    {
        camaraTransform = Camera.main.transform;
		posicionPrevia = camaraTransform.position;
    }

    void Update()
    {
        float posicion = (camaraTransform.position.x - posicionPrevia.x) * 0.9f;
		transform.Translate(new Vector3(posicion, 0, 0));
		posicionPrevia = camaraTransform.position;
    }
}
