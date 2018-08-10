using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

    public float speed;

    [SerializeField]
    private GameObject PointObject;
    private Vector3 RotateAroundThis;


	void Start () {
        RotateAroundThis = PointObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(RotateAroundThis, Vector3.right, speed * Time.deltaTime);
        transform.LookAt(RotateAroundThis);
	}
}
