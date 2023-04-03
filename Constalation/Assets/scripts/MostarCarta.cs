using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostarCarta : MonoBehaviour
{
    public Carta _carta;
    public Text nombre;
    public Text texto_descripcion;
    public Text texto_numero;
    public Image imagen_carta;
    // Start is called before the first frame update
    void Start()
    {
        nombre.text = _carta.nombre_carta;
        texto_descripcion.text = _carta.descripcion;
        texto_numero.text = _carta.numero;
        imagen_carta.sprite = _carta.imagen_carta;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
