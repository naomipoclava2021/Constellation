using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TriggerEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent miEventoTrigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EstrellaVacia"))
        {
            gameObject.SetActive(false);
            miEventoTrigger.Invoke();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
