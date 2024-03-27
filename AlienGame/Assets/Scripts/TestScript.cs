using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        Out("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Out(i.ToString());
        Warning("Warning");
        Error("Error");
    }

    void Out(string message) => Debug.Log(message);
    void Warning(string message) => Debug.LogWarning(message);
    void Error(string message) => Debug.LogError(message);
}
