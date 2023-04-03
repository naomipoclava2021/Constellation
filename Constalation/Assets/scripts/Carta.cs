using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="nueva carta",menuName ="carta")]
public class Carta : ScriptableObject
{
    public string nombre_carta;
    public string descripcion;
    public string numero;
    public Sprite imagen_carta;

}
