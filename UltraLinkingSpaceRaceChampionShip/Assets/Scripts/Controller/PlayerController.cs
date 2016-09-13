using UnityEngine;
using System.Collections;

/// <summary>
///     Controller to retrieve the player inputs
///     and send them to the components that need them
///     (e.g. : movement, attack, ...)
/// </summary>
public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float Joystick = 1;

    /// <summary>
    ///     Retrieve the axis translation of the player, and send it to the Move component
    /// </summary>
    void Update () {
        float horizontalTranslation = Input.GetAxis("JoystickHorizontal" + Joystick);
        float verticalTranslation = Input.GetAxis("JoystickVertical" + Joystick);

        gameObject.GetComponent<Movement>().AddMovement(horizontalTranslation, verticalTranslation);
    }
}
