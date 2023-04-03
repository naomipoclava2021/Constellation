using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNave : MonoBehaviour
{

    public float velocidad;
    public AudioSource audioSource;
    public AudioClip naveMovimiento;
    public Rigidbody rb;


    void NaveMotorSoundFxPlay(AudioClip sonido)
    {
        audioSource.clip = sonido;
        audioSource.Play();
    }

    void NaveMotorSoundFxStop(AudioClip sonido)
    {
        audioSource.clip = sonido;
        audioSource.Stop();
    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Move();
        Rotar();
        MoverInput();
    }

    void MoverInput()
    {

        rb.velocity = new Vector3(Input.GetAxis("Vertical") * velocidad * Time.deltaTime, 0f, 0f);

        transform.Translate(Input.GetAxis("Vertical") * velocidad * Time.deltaTime * velocidad * Time.deltaTime, 0, 0);

        //rb.rotation.eulerAngles = new Vector3(0f, Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, 0f);
        /*
                if (Input.GetAxis("Vertical") !=0)
                {

                    transform.Translate(5.0f * velocidad * Time.deltaTime, 0, 0);
                    //NaveMotorSoundFxPlay(naveMovimiento);

                }


                if (Input.GetKey(KeyCode.S))
                {
                    transform.Translate(-5.1f * velocidad * Time.deltaTime, 0, 0);  
                }
        */

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 0, 0.1f * 80 * Time.deltaTime);
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                transform.Translate(0, 0, -0.1f * 70 * Time.deltaTime);
            }

        }
    }

    void Move()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 mover = new Vector3(hor, 0, ver);
        transform.Translate(mover *velocidad* Time.deltaTime) ;
    }

    void Rotar()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, 0.25f*250*Time.deltaTime);
        }
        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, 0, -0.25f*250*Time.deltaTime);
            }
        }
    }
}
