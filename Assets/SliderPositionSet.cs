using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderPositionSet : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerPos;
    public GameObject slider;

    public Camera stage01cam;
    void Start()
    {
        slider.transform.position = playerPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        slider.transform.position = stage01cam.WorldToScreenPoint(playerPos.position + new Vector3(0, -1, 0));
    }
}
