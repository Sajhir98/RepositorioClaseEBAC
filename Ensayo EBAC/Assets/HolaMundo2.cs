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
        x = x + 1;
       Debug.Log(x); 
    }
}
