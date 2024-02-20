using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    MechInput MI;
    // Start is called before the first frame update
    void Start()
    {
        MI = new();
    }

    // Update is called once per frame
    void Update()
    {
        Loop();
    }

    void Loop()
    {
        
    }
}
