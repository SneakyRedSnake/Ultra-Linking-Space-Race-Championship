using UnityEngine;
using System.Collections;

/// <summary>
///     Controller to retrieve the player inputs
///     and send them to the components that need them
///     (e.g. : movement, attack, ...)
/// </summary>
public class PlayerController : MonoBehaviour {

	/// <summary>
    ///     Retrieve the axis translation of the player, and send it to the Move component
    /// </summary>
	void Update () {
        float verticalTranslation = Input.GetAxis("Vertical");
        float horizontalTranslation = Input.GetAxis("Horizontal");

        //component.move(horizontal, vertical);
    }
}
