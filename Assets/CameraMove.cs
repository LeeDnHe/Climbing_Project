using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;
        Vector3 targetPosition = new Vector3(transform.position.x, player.transform.position.y+3.0f ,transform.position.z);

        transform.position = Vector3.Lerp(currentPosition,targetPosition, 1.0f * Time.deltaTime);
    }
}
