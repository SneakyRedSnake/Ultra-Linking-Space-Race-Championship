using UnityEngine;
using System.Collections;

public class LaserInitialisation : MonoBehaviour {

    [SerializeField]
    private GameObject child1;

    [SerializeField]
    private GameObject child2;

    private PhysicalLink link;
    
    // Use this for initialization
    void Start () {
        DistanceJoint2D dj2d = child1.AddComponent<DistanceJoint2D>() as DistanceJoint2D;
        dj2d.connectedBody = child2.GetComponent<Rigidbody2D>();

        link = this.GetComponent<PhysicalLink>();
        link.SetLinkBetween(child1, child2);
    }
}
