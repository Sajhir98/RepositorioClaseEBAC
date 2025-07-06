using UnityEngine;

public class HolaMundo2:MonoBehaviour
{

    int x;
    void Start()
    {
        x = 0;
        print("algo paso");
       
        Debug.LogWarning("Algo Salio Medianamente Mal");
        Debug.LogError("Algo Salio Muy Mal");
    }

    // update is called once per frame 
    private void Update()
    {
        //x = x + 1;
        //Debug.Log(x); 

        Debug.Log("Hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde Late update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado)");
    }

    private void OnDisable()
    {
        Debug.LogWarning("El Objeto ha sido inhabilitado)");
    }
}
