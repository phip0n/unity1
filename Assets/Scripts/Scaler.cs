using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _currentScale = new Vector3(1, 1, 1);
    private Vector3 _scaleChange;

    // Start is called before the first frame update
    private void Start()
    {
        _scaleChange = new Vector3(1, 1, 1) * _speed;
    }

    // Update is called once per frame
    private void Update()
    {
        IncreaseSize();
    }

    private void IncreaseSize()
    {
        _currentScale += _scaleChange;
        transform.localScale = _currentScale;
    }
}
