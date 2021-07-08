using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripsoga : MonoBehaviour
{
    public Vector3 fuerzaprueba;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            transform.GetChild(transform.childCount - 1).GetComponent<Rigidbody2D>().AddForce(fuerzaprueba, ForceMode2D.Impulse);
        }
    }
}
