using UnityEngine;
using System.Collections;

public class PhysicalLink : MonoBehaviour {
    private GameObject first;               //the first gameobject that will be link to the other
    public GameObject First
    {
        get { return this.first; }
        private set {
            this.first = value;
            this.firstRigidbody = value.GetComponent<Rigidbody2D>();
        }
    }

    private Rigidbody2D firstRigidbody;     //the rigidbody of the first gameobject to be linked

    private GameObject second;              //the second gameobject that will be linked
    public GameObject Second
    {
        get { return this.second; }
        private set {
            this.second = value;
            this.secondRigidbody = value.GetComponent<Rigidbody2D>();
        }
    }
    private Rigidbody2D secondRigidbody;    //the rigidbody of the second gameobject to be linked

    [SerializeField]
    private Vector3 initialScaling;         //the scaling we want for the gameobject that will link the two others


    /// <summary>
    ///     Scale the gameobject and use it to link
    ///     the two gameobject we put in first and second
    ///     variable at each frame.
    /// </summary>
    void Update () {
        Vector2 positionFirst = firstRigidbody.position;
        Vector2 positionSecond = secondRigidbody.position;
        transform.position = (positionFirst + positionSecond) / 2; // place the cube in the middle of A-B
        transform.LookAt(positionSecond); // make it look to ballB position
        // adjust cube length so it will have its ends at the sphere centers
        Vector3 scale = initialScaling;
        scale.z *= Vector3.Distance(positionFirst, positionSecond);
        // stretch it in the direction it's looking
        transform.localScale = scale;
    }

    /// <summary>
    ///     Set a link between the two gameobjects
    ///     in parameters
    /// </summary>
    /// <param name="first">the first gameobject that will be link to the other</param>
    /// <param name="second">the second gameobject that will be link to the other</param>
    public void SetLinkBetween(GameObject first, GameObject second)
    {
        this.First = first;
        this.Second = second;
    }
}
