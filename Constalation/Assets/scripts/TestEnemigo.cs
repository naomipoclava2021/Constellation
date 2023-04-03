using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemigo cerdito = new Enemigo();
        cerdito.vida = 79;
        cerdito.nombre = "babe";
        Hijoenemigo aves = new Hijoenemigo();
        aves.Aves();
        Enemigo raton = new Enemigo();
        raton.vida = 30;
        raton.nombre = "roquefort";
        Debug.Log("la vida del cerdito es  " + cerdito.vida + "y se llama  "+cerdito.nombre );
        Debug.Log("la vida del raton es  " + raton.vida + "y se llama  " + raton.nombre);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
