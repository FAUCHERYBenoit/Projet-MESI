using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using messages;
using UnityEngine.Events;

namespace character
{
    public class InputManager : MonoBehaviour
    {
        PlayerControls playerControls;

        public class ButtonInputEvent : UnityEvent { }
        public class MovementEvent : UnityEvent<Vector2> { }

        [HideInInspector] public ButtonInputEvent onPrimaryAction = new ButtonInputEvent();
        [HideInInspector] public ButtonInputEvent onScondaryAction = new ButtonInputEvent();
        [HideInInspector] public ButtonInputEvent onForwardAction = new ButtonInputEvent();
        [HideInInspector] public ButtonInputEvent onBackwardAction = new ButtonInputEvent();
        [HideInInspector] public ButtonInputEvent onInteractionAction = new ButtonInputEvent();
        [HideInInspector] public ButtonInputEvent onReloadAction = new ButtonInputEvent();
        [HideInInspector] public ButtonInputEvent onInventoryAction = new ButtonInputEvent();
        [HideInInspector] public ButtonInputEvent onSkillTreeAction = new ButtonInputEvent();
        [HideInInspector] public ButtonInputEvent onMapAction = new ButtonInputEvent();
        [HideInInspector] public ButtonInputEvent onUseItemAction = new ButtonInputEvent();

        [HideInInspector] public MovementEvent onDashAction = new MovementEvent();
        [HideInInspector] public MovementEvent onMove = new MovementEvent();

        private void OnEnable()
        {
            SetUpInputs();
        }

        Vector2 direction;

        private void SetUpInputs()
        {
            if (playerControls == null)
            {
                playerControls = new PlayerControls();

                playerControls.PlayerMouvement.Mouvement.performed += i => direction = i.ReadValue<Vector2>();

                playerControls.MouseActions.PrimaryButton.performed += i => onPrimaryAction?.Invoke();
                playerControls.MouseActions.SecondaryButton.performed += i => onScondaryAction?.Invoke();
                playerControls.MouseActions.MouseWheel.performed += i =>
                {
                    if (i.ReadValue<float>() > 0)
                    {
                        onForwardAction?.Invoke();  
                    }
                    else if (i.ReadValue<float>() < 0)
                    {
                        onBackwardAction?.Invoke();
                    }
                };

                playerControls.KeyboardActions.InteractionAction.performed += i => onInteractionAction?.Invoke();
                playerControls.KeyboardActions.RelaodAction.performed += i => onReloadAction?.Invoke();
                playerControls.KeyboardActions.InventoryAction.performed += i => onInventoryAction?.Invoke();
                playerControls.KeyboardActions.SkillTreeAction.performed += i => onSkillTreeAction?.Invoke();
                playerControls.KeyboardActions.MapAction.performed += i => onMapAction?.Invoke();
                playerControls.KeyboardActions.UseItemAction.performed += i => onUseItemAction?.Invoke();
                playerControls.KeyboardActions.DashAction.performed += i => onDashAction?.Invoke(direction);
            }

            playerControls.Enable();
        }

        private void OnDisable()
        {
            playerControls.Disable();
        }

        void FixedUpdate()
        {
            onMove?.Invoke(direction);
        }
    }
}

