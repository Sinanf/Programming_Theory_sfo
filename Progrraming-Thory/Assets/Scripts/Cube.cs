using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shapes //INHERITANCE
{
    private int _faces = 6;
    

    // Must override the abstract Properties from base class Shapes.
    public override int Faces //POLYMORHISM
    {
        get => _faces;
        protected set => _faces = value;
    }

    private void Awake()
    {
        Name = "Cube";
        rotatingSpeed = 5f;
        
    }
}
