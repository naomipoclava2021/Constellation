using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navegacion : MonoBehaviour
{
    // Start is called before the first frame update
    //public Transform nave;

    public GameObject jugador;
    //public GameObject enemigo;
    //public GameObject enemigo2;
    //public float distancia;
    //public float velocidad = 1;
    public NavMeshAgent agente;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //LookQuatenion();
        //LookAtPlayer();
        //MoverEnemigo();
        //MoverEnemigoLerp();
        //distancia = Vector3.Distance(jugador.transform.position, enemigo.transform.position);
        //Debug.Log(distancia);
        //if (distancia <= 2)
        //{
        //    velocidad = 0;
        //}
        //else
        //{
        //    velocidad = 1;
        //}

        SeguirAJugador();
    }

    //void LookQuatenion()
    //{
    //    Quaternion rotarEnemigo = Quaternion.LookRotation(jugador.transform.position - enemigo2.transform.position);
    //    enemigo2.transform.rotation = rotarEnemigo;
    //}

    void LookAtPlayer()
    {
        //enemigo.transform.LookAt(jugador.transform.position);
    }

    //void MoverEnemigo()
    //{
    //    enemigo.transform.position = Vector3.MoveTowards(enemigo.transform.position, jugador.transform.position, velocidad * Time.deltaTime);
    //}

    //void MoverEnemigoLerp()
    //{
    //    enemigo2.transform.position = Vector3.Lerp(enemigo2.transform.position, jugador.transform.position, velocidad * Time.deltaTime);
    //}

    void SeguirAJugador()
    {
        agente.SetDestination(jugador.transform.position);
    }


}
