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

    [SerializeField] private bool interactionAction = false;
    /// <summary>
    /// Key E
    /// </summary>
    public bool InteractionAction { get { return interactionAction; } }
    [SerializeField] private bool reloadAction = false;
    /// <summary>
    /// Key R
    /// </summary>
    public bool ReloadAction { get { return reloadAction; } }
    [SerializeField] private bool inventoryAction = false;
    /// <summary>
    /// Key I
    /// </summary>
    public bool InventoryAction { get { return inventoryAction; } }
    [SerializeField] private bool skillTreeAction = false;
    /// <summary>
    /// Key T
    /// </summary>
    public bool SkillTreeAction { get { return skillTreeAction; } }
    [SerializeField] private bool mapAction = false;
    /// <summary>
    /// Key M
    /// </summary>
    public bool MapAction { get { return mapAction; } }
    [SerializeField] private bool useItemAction = false;
    /// <summary>
    /// Key F
    /// </summary>
    public bool UseItemAction { get { return useItemAction; } }
    [SerializeField] private bool dashAction = false;
    /// <summary>
    /// Key Shift
    /// </summary>
    public bool DashAction { get { return dashAction; } }

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
            //Assigning events to MouseActions
            playerControls.MouseActions.PrimaryButton.performed += i => primaryAction = true;
            playerControls.MouseActions.SecondaryButton.performed += i => secondaryAction = true;
            playerControls.MouseActions.ForwardButton.performed += i => forwardAction = true;
            playerControls.MouseActions.BackWardButton.performed += i => bacwardAction = true;

            //Assigning events to keyBoardActions
            playerControls.KeyboardActions.InteractionAction.performed += i => interactionAction = true;
            playerControls.KeyboardActions.RelaodAction.performed += i => reloadAction = true;
            playerControls.KeyboardActions.InteractionAction.performed += i => inventoryAction = true;
            playerControls.KeyboardActions.SkillTreeAction.performed += i => skillTreeAction = true;
            playerControls.KeyboardActions.MapAction.performed += i => mapAction = true;
            playerControls.KeyboardActions.UseItemAction.performed += i => useItemAction = true;
            playerControls.KeyboardActions.DashAction.performed += i => dashAction = true;
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

        interactionAction = false;
        reloadAction = false;
        inventoryAction = false;
        skillTreeAction = false;
        mapAction = false;
        useItemAction = false;
        dashAction = false;
    }
}
