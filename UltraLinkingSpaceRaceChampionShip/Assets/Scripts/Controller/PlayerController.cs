using UnityEngine;
using System.Collections;

/// <summary>
///     Controller to retrieve the player inputs
///     and send them to the components that need them
///     (e.g. : movement, attack, ...)
/// </summary>
public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float joystick = 1;

    [SerializeField]
    private GameObject ship;

    private Movement moveComponent;

    void Start() {
        moveComponent = ship.GetComponent<Movement>();
    }

    /// <summary>
    ///     Retrieve the axis translation of the player, and send it to the Move component
    /// </summary>
    void Update () {
        float horizontalTranslation = Input.GetAxis("JoystickHorizontal" + joystick);
        float verticalTranslation = Input.GetAxis("JoystickVertical" + joystick);

        moveComponent.AddMovement(horizontalTranslation, verticalTranslation);
    }
}
