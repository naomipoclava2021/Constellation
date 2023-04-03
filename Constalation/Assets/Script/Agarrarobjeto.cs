using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agarrarobjeto : MonoBehaviour
{
    public GameObject puntomano;
    private GameObject objetoagarrado;

    void Update()
    {
        if (objetoagarrado != null)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                objetoagarrado.GetComponent<Rigidbody>().useGravity = true;
                objetoagarrado.GetComponent<Rigidbody>().isKinematic = false;
                objetoagarrado.transform.SetParent(null);
                objetoagarrado = null;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Objeto") && objetoagarrado == null)
        {
            if (Input.GetKey(KeyCode.T)) 
            {
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = puntomano.transform.position;
                other.transform.SetParent(puntomano.gameObject.transform);
                objetoagarrado = other.gameObject;
            }
        }
    }
}
