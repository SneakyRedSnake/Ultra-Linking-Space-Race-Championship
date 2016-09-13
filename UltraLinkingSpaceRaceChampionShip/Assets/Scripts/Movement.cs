using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    
    /// <summary>
    /// horizontalSpeedM
    /// </summary>
    [SerializeField]
    private float horizontalForceMultiplier = 10;

    [SerializeField]
    private float verticalForceMultiplier = 10;

    private Vector2 force;

    // Use this for initialization
    void Start () {
        force = new Vector2(0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Rigidbody2D>().AddForce(force);
        Debug.Log(gameObject.GetComponent<Rigidbody2D>().velocity);
    }

    public void AddMovement(float horiForce, float vertForce) {
        force.x = horiForce * horizontalForceMultiplier;
        force.y = vertForce * verticalForceMultiplier;
    }
}
