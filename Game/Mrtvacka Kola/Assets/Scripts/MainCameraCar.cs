using UnityEngine;
using System.Collections;

public class MainCameraCar : MonoBehaviour
{
    private Vector3 offset;
    public GameObject car;

    

    void Start()
    {
        offset = transform.position - car.transform.position;
    }

    void LateUpdate()
    {
        if(car != null)
            transform.position = car.transform.position + offset;
    }
}
