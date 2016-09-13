using UnityEngine;
using System.Collections;

public class LaserInitialisation : MonoBehaviour {

    [SerializeField]
    private GameObject child1;

    [SerializeField]
    private GameObject child2;

    // Use this for initialization
    void Start () {
        Vector3 pos = gameObject.GetComponent<Transform>().position;
        Vector3 size = gameObject.GetComponent<Transform>().localScale;
        Quaternion rot = gameObject.GetComponent<Transform>().rotation;


        child1.GetComponent<Transform>().position = /*Reloud!!!*/new Vector3();
        child2.GetComponent<Transform>().position = /*Reloud!!!*/new Vector3();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
