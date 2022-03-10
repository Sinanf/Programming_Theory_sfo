using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    private Text _text;
    
    

    private void Awake()
    {
        _text = GameObject.Find("Text").GetComponent<Text>();
        ResetScene();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetClickedText(); // ABSTRACTION
        }
    }
    private void SetDefaultText()
    {
        _text.text = "OOP Theory\n\nCode illustrating Abstraction, " +
            "Inheritance, Polymorphism, and Encapsulation.\n\n" +
            "Click on an shapes for details.";
    }

    // Find all shapes and initialize state
    // Reset text to default
    private void ResetScene()
    {
        
        SetDefaultText();
       
    }

    // ABSTRACTION
    private void SetClickedText()
    {
        {
            // First reset the scene
            ResetScene();

            // Find GameObject the user clicked on by using a Raycast
            // Get variables from parent class of the object the user clicked
            // Update text with appropriate values
            // Make the clicked shapes rotate randomly

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                
                GameObject _target = hit.collider.gameObject;
                var _name = _target.GetComponentInParent<Shapes>().Name;
                int _faces = _target.GetComponentInParent<Shapes>().Faces;

                _text.text = $"Hello, I am a {_name}.\n\n" +
                    $"If you click somewhere and again click I will get faster also I have {_faces} faces.\n\n" +
                    "" +
                    "Until you click elsewhere.";

                _target.GetComponentInParent<Shapes>().StartRotating();


            }
            else
            {
                
                // User clicked empty space, reset scene
                ResetScene();

                
                
            }
        }
    }
}