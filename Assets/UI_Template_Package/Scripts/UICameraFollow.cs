using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;
using UnityEditor;


public class UICameraFollow : MonoBehaviour
{
    public float distance = 3f;
    public float rotangle = 50;
    [SerializeField] private Vector3 offset;
    [SerializeField] private bool autoHeight;
    Vector3 targetPosition;
    Quaternion targetRotation;


    //private bool Lock;
    //public float Height;
    private Transform PlayerRoot;
    private Transform CameraTransform;
    // Update is called once per frame
    Vector3 lastPlayerPosition;

    private void Awake()
    {
        if (PlayerRoot == null)
            PlayerRoot = GameObject.FindObjectOfType<XROrigin>().transform;
        if (CameraTransform == null)
            CameraTransform = GameObject.FindObjectOfType<AudioListener>().transform;        
    }

    public void Start()
    {
        targetPosition = transform.position;
        targetRotation = transform.rotation;
    }

    public void Update()
    {
        if (PlayerRoot == null)
            PlayerRoot = GameObject.FindObjectOfType<XROrigin>().transform;
        if (CameraTransform == null)
            CameraTransform = GameObject.FindObjectOfType<AudioListener>().transform;
        
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5);
        //transform.rotation = targetRotation;// Quaternion.LookRotation(VectorXZ(CameraTransform.forward));
        transform.LookAt(new Vector3(CameraTransform.position.x, transform.position.y, CameraTransform.position.z));
        transform.rotation *= Quaternion.Euler(0, 180, 0);

        if (Vector3.Angle(VectorXZ(CameraTransform.forward), VectorXZ(transform.position - CameraTransform.position)) > rotangle ||
            Vector3.Distance(targetPosition, CameraTransform.position) > 3 ||
            lastPlayerPosition != PlayerRoot.position ||
            Vector3.Angle(transform.forward, transform.position - CameraTransform.position) > 45)
        {
            resetTargetPosition();
        }

        lastPlayerPosition = PlayerRoot.position;
    }

    void resetTargetPosition()
    {
        if (PlayerRoot == null)
            PlayerRoot = GameObject.FindObjectOfType<XROrigin>().transform;
        if (CameraTransform == null)
            CameraTransform = GameObject.FindObjectOfType<AudioListener>().transform;
        
        Vector3 start = VectorXZ(CameraTransform.position);
        if (autoHeight)
        {
            start = CameraTransform.position;
            offset.y = 0;
        }
        Vector3 camForward = VectorXZ(CameraTransform.forward).normalized;
        Vector3 camRight = VectorXZ(CameraTransform.right).normalized;
        targetPosition = start + (camRight * offset.x) + (Vector3.up * offset.y) + (camForward * distance);
        targetRotation = Quaternion.LookRotation(VectorXZ(CameraTransform.forward));

        
    }

    public Vector3 VectorXZ(Vector3 a)
    {
        return new Vector3(a.x, 0, a.z);
    }
}