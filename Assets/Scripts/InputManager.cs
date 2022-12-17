using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;

    /// <summary>
    /// Player movefment axis
    /// </summary>
    [SerializeField] private Vector2 movementInput;
    public Vector2 MovementInput { get { return movementInput; } }

    //Mouse Actions

    [SerializeField] private bool primaryAction = false;
    /// <summary>
    /// Left mouse button 
    /// </summary>
    public bool PrimaryAction { get { return primaryAction; } }
    [SerializeField] private bool secondaryAction = false;
    /// <summary>
    /// right mouse button
    /// </summary>
    public bool SecondaryAction { get { return secondaryAction; } }
    [SerializeField] private bool forwardAction = false;
    /// <summary>
    /// forward wheel slider
    /// </summary>
    public bool ForwardAction { get { return forwardAction; } }
    [SerializeField] private bool bacwardAction = false;
    /// <summary>
    /// backward wheel slider
    /// </summary>
    public bool BacwardAction { get { return bacwardAction; } }

    // E , R , I , T , M , F , Shift


    private void OnEnable()
    {
        SetUpInputs();
    }

    private void SetUpInputs()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();

            playerControls.PlayerMouvement.Mouvement.performed += i => movementInput = i.ReadValue<Vector2>();

            playerControls.MouseActions.PrimaryButton.performed += i => primaryAction = true;
            playerControls.MouseActions.SecondaryButton.performed += i => secondaryAction = true;
            playerControls.MouseActions.ForwardButton.performed += i => forwardAction = true;
            playerControls.MouseActions.BackWardButton.performed += i => bacwardAction = true;
        }

        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    private void LateUpdate()
    {
        primaryAction = false;   
        secondaryAction = false;
        forwardAction = false;
        bacwardAction = false;
    }
}
