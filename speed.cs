using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
public float speed = 0.0f;
private Rigidbody2D r2d;
private Animator _animator;
private Vector3 charPos;
[SerializedField] private GameObject _camera;

void Start()
{
    r2d = GetComponent<Rigidbody2D>(); // caching r2d
    _animator = GetComponent<Animator>(); // caching anim
    charPos = transform.position;
}

private void FixedUpdate()
{
    //r2d.velocity = new Vector2(speed, 0f);
    _camera.transform.position= new Vector3 (charPos.x,charPos.y,charPos.z - 1.0f);
}


}

