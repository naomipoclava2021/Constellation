using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hijoenemigo : Enemigo
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vida();
    }
    public override void Aves()
    {
        base.Aves();
        Debug.Log("estas son aves del pacifico");
    }
}
