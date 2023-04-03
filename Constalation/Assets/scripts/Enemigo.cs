using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int vida = 100;
    public string nombre = "tomas";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vida();
        
    }
    public void Vida()
    {
        if (vida >= 100)
        {
            Debug.Log("vida al maximo");
            Debug.Log(nombre);
        }
        else
        {
            Debug.Log("vida restante" + vida);
        }
    
    }
    public virtual void Aves()
    {
        string tipo = "maritima";
        int cantidad = 10;
        Debug.Log("el tipo es  " + tipo + "y su cantidad es " + cantidad);
    }
}
