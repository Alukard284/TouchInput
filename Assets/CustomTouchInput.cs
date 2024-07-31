using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomTouchInput : MonoBehaviour
{
    [SerializeField] float startTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            /*Vector3 direction = new Vector3(touch.deltaPosition.x, 0f, touch.deltaPosition.y);
            sphereRB.AddForce(direction * speed);*/


            if (touch.phase == TouchPhase.Began)
            {
                startTimer = Time.time;
                Debug.Log("Tap");
            }
            if (touch.phase == TouchPhase.Ended && Time.time - startTimer > 2f)
            {
                Debug.Log("Long Tap");
            }
        }
    }
}
