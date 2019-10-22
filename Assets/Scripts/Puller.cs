using UnityEngine;
using System.Collections;

public class Puller : MonoBehaviour
{
    Vector3 thePosition;

    void Update()
    {
        if (Input.GetButtonDown("Pull"))
        {
            thePosition = transform.localPosition;

            Debug.Log(thePosition.x + "PULLING NOW");

            // player.OnPullInputDown();

        }
        if (Input.GetButtonUp("Pull"))
        {
            // reset the localPosition.x to 0
            Debug.Log(thePosition.x + "STOPPED PULLING");

            // player.OnPullInputUp();
        }
    }
}
