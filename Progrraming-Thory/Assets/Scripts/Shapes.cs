using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract public class Shapes : MonoBehaviour //INHERITANCE
{
    public Rigidbody shape_rb;
    //Serialized fields for Editor
    [SerializeField] private string _name = "Shapes";
    [SerializeField] private float _rotatingSpeed = 5f;
    [SerializeField] private bool _isRotating = false;

    public abstract int Faces { get; protected set; } //ENCAPSULATION

    public float rotatingSpeed
    {
        get => _rotatingSpeed;
        protected set => _rotatingSpeed = value;
               
    }

    public string Name
    {
        get => _name;
        protected set => _name = value;
    }

    public bool isRotating
    {
        get => _isRotating;
        protected set => _isRotating = value;
    }

    public void StartRotating()
    {
        Vector3 coordinate = new Vector3(Random.Range(0, 5), Random.Range(0, 5), Random.Range(0, 5));
        _isRotating = true;
        shape_rb.AddRelativeTorque(coordinate);
    }

    public void StopRotating()
    {
        _isRotating = false;
        _rotatingSpeed = 0f;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
