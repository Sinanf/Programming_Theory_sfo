using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shapes //INHERITANCE
{
    private int _faces = 1;


    // Must override the abstract Properties from base class Shapes.
    public override int Faces //POLYMORHISM
    {
        get => _faces;
        protected set => _faces = value;
    }

    private void Awake()
    {
        Name = "Capsule";
        rotatingSpeed = 100f;

    }
}
