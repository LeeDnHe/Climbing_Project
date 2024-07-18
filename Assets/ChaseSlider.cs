using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChaseSlider : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider gaze;
    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        gaze.transform.position = transform.position + new Vector3(0, -20, 0);
    }
}
