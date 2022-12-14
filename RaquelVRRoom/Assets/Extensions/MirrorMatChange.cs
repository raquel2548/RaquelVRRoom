using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMatChange : MonoBehaviour
{
    public Material Clear;
    public Material Mirror;

    // Start is called before the first frame update
    void Start()
    {
        //theMat = GetComponent<Renderer>().material;
    }

    public void SetMatClear()
    {
        GetComponent<Renderer>().material = Clear;
    }

    public void SetMatMirror()
    {
        GetComponent<Renderer>().material = Mirror;
    }
}
