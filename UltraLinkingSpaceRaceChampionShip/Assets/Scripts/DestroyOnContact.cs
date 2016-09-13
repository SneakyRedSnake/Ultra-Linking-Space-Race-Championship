using UnityEngine;
using System.Collections;

/// <summary>
///     Destroy every gameobject that enter in contact
///     with the game object that possess this component
/// </summary>
public class DestroyOnContact : MonoBehaviour {

    /// <summary>
    ///     When a gameobject collide with the owner
    ///     of this component, it destroy himself
    /// </summary>
    /// <param name="col">the Collision2D of the gameobject
    /// that hits the owner of this component</param>
    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
    }
}
