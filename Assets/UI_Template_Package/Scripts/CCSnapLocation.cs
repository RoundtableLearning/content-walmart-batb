using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CCSnapLocation : MonoBehaviour
{
    public float snapRange = 5f;
    
    private Transform _player;
    private bool _snapped = false;

    private void Start()
    {
        _player = Player.instance.transform;
    }

    private void Update()
    {
        if (!_snapped && Vector3.Distance(transform.position, _player.position) <= snapRange)
        {
            ClosedCaptioning.canvas.transform.position = transform.position;
            _snapped = true;
        }
        else if(_snapped && Vector3.Distance(transform.position, _player.position) > snapRange)
        {
            _snapped = false;
        }
    }
}
