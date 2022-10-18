using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody _rb;
    private Vector3 _randomPos;
    [SerializeField] private Transform _movePosition;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("x", _rb.velocity.x);
        _animator.SetFloat("y", _rb.velocity.z);
    }
}
