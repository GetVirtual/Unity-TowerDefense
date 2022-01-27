using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseMove : MonoBehaviour
{
    public float Speed = 1.0f;
    public float RotationSpeed = 60.0f;
    public Vector3 RotationAxis = Vector3.up;
    public float Scale = 10.0f;
    public float YScaleOffset = 10.0f;
    public float ZScaleOffset = 10.0f;
    public float XScaleOffset = 10.0f;

    private Vector3 _initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        _initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float speed = (float)Time.timeAsDouble * Speed;
        transform.position = _initialPosition + (new Vector3(
            Mathf.PerlinNoise(speed * XScaleOffset, speed * YScaleOffset), 
            Mathf.PerlinNoise(speed * YScaleOffset, speed * ZScaleOffset), 
            Mathf.PerlinNoise(speed * ZScaleOffset, speed * XScaleOffset)) * Scale);
        transform.Rotate(RotationAxis, Time.deltaTime * RotationSpeed, Space.Self);


    }
}
