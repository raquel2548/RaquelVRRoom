using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    public GameObject Cover;
    public GameObject Hinge;

    // Start is called before the first frame update
    void Start()
    {
        var Hinge = Cover.GetComponent<HingePoint>();

        Hinge.useMotor = false;
        
    }

    public void OpenSesame()
    {
        Hinge.useMotor = true;
    }
}
