using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarjetCamra2 : MonoBehaviour
{
    public GameObject personaje1;
    private Vector3 posicionRelativa;

    // Use this for initialization
    void Start()
    {

        posicionRelativa = transform.position - personaje1.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = personaje1.transform.position + posicionRelativa;

    }
}
