using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public Color myColor; // Display colour picker in the Inspector
    MeshRenderer myRenderer; // For colouring the platform

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = myColor;

        if (gameObject.tag == "Through") // If this platform is tagged 'Through', then set the colour to X
        {
            myRenderer.material.color = new Color(0, 0, 1, 0); // Set the colour to solid bright green if it's a through platform.
        }
    }

}
