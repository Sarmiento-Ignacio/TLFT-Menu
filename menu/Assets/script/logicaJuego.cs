using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class logicaJuego : MonoBehaviour
{
    public ControladorOpciones panelOpciones;
    // Start is called before the first frame update
    void Start()
    {
        panelOpciones = GameObject.FindGameObjectWithTag("opciones").GetComponent<ControladorOpciones>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarEscena()
    {
        SceneManager.LoadScene(1);
    }
}

