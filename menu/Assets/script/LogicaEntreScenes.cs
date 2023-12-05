using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEntreScenes : MonoBehaviour
{
    private void Awake()
    {
        var noDestrirEntreScenes = FindObjectsOfType<LogicaEntreScenes>(); 
        if (noDestrirEntreScenes.Length > 1)
        {
            Destroy(gameObject);
            return;
        }
        
        
            DontDestroyOnLoad(gameObject);
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
