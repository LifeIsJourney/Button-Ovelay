using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//simple click log
public class SimpleClickMethod : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Log(Transform me)
    {
        Debug.Log(" my name is " + me.name);
        text.text = " clicked " + me.name;
    }
}
