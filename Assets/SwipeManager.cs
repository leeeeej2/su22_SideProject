using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwipeManager : MonoBehaviour
{
    private Vector3 firstPostiion;
    private Vector3 lastPosition;
    
    private float dragDistance = 0.25f;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                firstPostiion = touch.position;
                lastPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                lastPosition = touch.position;

                if (Mathf.Abs(lastPosition.x - firstPostiion.x) <= Mathf.Abs(lastPosition.y - firstPostiion.y))
                {
                    if (lastPosition.y > firstPostiion.y)
                    {
                        //up
                        if (!DoNotOut.upMove)
                        {
                            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
                        }
                        else
                        {
                            transform.position = new Vector3(transform.position.x, transform.position.y + dragDistance, transform.position.z);
                        }
                    }
                    else
                    {
                        if (!DoNotOut.downMove)
                        {
                            transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                        }
                        else
                        {
                            transform.position = new Vector3(transform.position.x, transform.position.y - dragDistance, transform.position.z);
                        }
                    }
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                lastPosition = touch.position;
            }
        }
    }
}
