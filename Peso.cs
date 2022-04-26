using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peso : MonoBehaviour
{
    public int Peso;
    public int currentPeso;
    // Start is called before the first frame update
    void Start()
    {
        Peso == 0; 
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePeso();
    }

    public void UpdatePeso(int peso)
    {
        Peso += peso;
        int crntPeso = Peso + 10000;

    }
}
