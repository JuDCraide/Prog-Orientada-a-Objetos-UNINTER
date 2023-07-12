using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControleVida : MonoBehaviour
{

    public UnityEvent eventoMorte;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDisable() { 
        eventoMorte.Invoke();
    }
}
