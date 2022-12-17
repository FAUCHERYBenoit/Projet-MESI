using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;

    public Vector2 movementInput;


    //Mouse Actions
    [SerializeField]
    private InputAction LeftButtonAction;

    [SerializeField]
    private InputAction ForwardButtonAction;

    [SerializeField]
    private InputAction BackButtonAction;

    [SerializeField]
    private InputAction RightButtonAction;

    [SerializeField]
    private InputAction InteractionButtonAction;

    [SerializeField]
    private InputAction ReloadButtonAction;

    [SerializeField]
    private InputAction InventoryButtonAction;

    [SerializeField]
    private InputAction SkillTreeButtonAction;

    [SerializeField]
    private InputAction CarteButtonAction;

    [SerializeField]
    private InputAction UseItemButtonAction;

    [SerializeField]
    private InputAction DashButtonAction;

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();

            playerControls.PlayerMouvement.Mouvement.performed += i => movementInput = i.ReadValue<Vector2>();
        }

        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
}
