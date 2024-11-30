using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class QuestGamepads2020FromActionInputMono : MonoBehaviour {

    public QuestGamepads2020Mono m_target;

    [Header("Analog")]
    public InputActionReference m_joystickLeftHorizontal;
    public InputActionReference m_joystickLeftVertical;
    public InputActionReference m_joystickRightHorizontal;
    public InputActionReference m_joystickRightVertical;
    public InputActionReference m_triggerLeft;
    public InputActionReference m_triggerRight;
    public InputActionReference m_gripLeft;
    public InputActionReference m_gripRight;

    [Header("Buttons")]
    public InputActionReference m_buttonLeftTop;
    public InputActionReference m_buttonRightTop;
    public InputActionReference m_buttonLeftDown;
    public InputActionReference m_buttonRightDown;
    public InputActionReference m_buttonLeftJoystick;
    public InputActionReference m_buttonRightJoystick;
    public InputActionReference m_buttonLeftThumbRest;
    public InputActionReference m_buttonRightThumbRest;
    public InputActionReference m_menuLeft;
    public InputActionReference m_menuRight;



    [Header("Touch")]
    public InputActionReference m_touchLeftTop;
    public InputActionReference m_touchRightTop;
    public InputActionReference m_touchLeftDown;
    public InputActionReference m_touchRightDown;
    public InputActionReference m_touchLeftJoystick;
    public InputActionReference m_touchRightJoystick;
    public InputActionReference m_touchLeftTrigger;
    public InputActionReference m_touchRightTrigger;

    [Header("Extra")]
    public InputActionReference m_isLeftTracked;
    public InputActionReference m_isRightTracked;


    public float m_triggerthresholdForButton = 0.2f;
    public float m_gripThresholdForButton = 0.2f;


    public void EnableAllActionReference() { 
        if (m_joystickLeftHorizontal != null)
            m_joystickLeftHorizontal.action.Enable();
        if (m_joystickRightHorizontal != null)
            m_joystickLeftVertical.action.Enable();
        if (m_joystickRightHorizontal != null)
            m_joystickRightHorizontal.action.Enable();
        if (m_joystickRightVertical != null)
            m_joystickRightVertical.action.Enable();
        if (m_triggerLeft != null)
            m_triggerLeft.action.Enable();
        if (m_triggerRight != null)
            m_triggerRight.action.Enable();
        if (m_gripLeft != null)
            m_gripLeft.action.Enable();
        if (m_gripRight != null)
            m_gripRight.action.Enable();

        if (m_buttonLeftTop != null)
            m_buttonLeftTop.action.Enable();
        if (m_buttonRightTop != null)
            m_buttonRightTop.action.Enable();
        if (m_buttonLeftDown != null)
            m_buttonLeftDown.action.Enable();
        if (m_buttonRightDown != null)
            m_buttonRightDown.action.Enable();
        if (m_buttonLeftJoystick != null)
            m_buttonLeftJoystick.action.Enable();
        if (m_buttonRightJoystick != null)
            m_buttonRightJoystick.action.Enable();
        if (m_buttonLeftThumbRest != null)
            m_buttonLeftThumbRest.action.Enable();
        if (m_buttonRightThumbRest != null)
            m_buttonRightThumbRest.action.Enable();
        if (m_menuLeft != null)
            m_menuLeft.action.Enable();
        if (m_menuRight != null)
            m_menuRight.action.Enable();

        if (m_touchLeftTop != null)
            m_touchLeftTop.action.Enable();
        if (m_touchRightTop != null)
            m_touchRightTop.action.Enable();
        if (m_touchLeftDown != null)
            m_touchLeftDown.action.Enable();
        if (m_touchRightDown != null)
            m_touchRightDown.action.Enable();
        if (m_touchLeftJoystick != null)
            m_touchLeftJoystick.action.Enable();
        if (m_touchRightJoystick != null)
            m_touchRightJoystick.action.Enable();
        if (m_touchLeftTrigger != null)
            m_touchLeftTrigger.action.Enable();
        if (m_touchRightTrigger != null)
            m_touchRightTrigger.action.Enable();
        if (m_isLeftTracked != null)
            m_isLeftTracked.action.Enable();
        if (m_isRightTracked != null)
            m_isRightTracked.action.Enable();

    
    }

    public void OnEnable()
    {
        if (m_joystickLeftHorizontal != null)
            m_joystickLeftHorizontal.action.performed += OnJoystickLeftHorizontal;
        if (m_joystickRightHorizontal != null)
            m_joystickLeftVertical.action.performed += OnJoystickLeftVertical;
        if (m_joystickRightHorizontal != null)
            m_joystickRightHorizontal.action.performed += OnJoystickRightHorizontal;
        if (m_joystickRightVertical != null)
            m_joystickRightVertical.action.performed += OnJoystickRightVertical;
        if (m_triggerLeft != null)
            m_triggerLeft.action.performed += OnTriggerLeftFloatValue;
        if (m_triggerRight != null)
            m_triggerRight.action.performed += OnTriggerRightFloatValue;
        if (m_gripLeft != null)
            m_gripLeft.action.performed += OnGripLeftFloatValue;
        if (m_gripRight != null)
            m_gripRight.action.performed += OnGripRightFloatValue;

        if (m_buttonLeftTop != null)
            m_buttonLeftTop.action.performed += OnButtonLeftTop;
        if (m_buttonRightTop != null)
            m_buttonRightTop.action.performed += OnButtonRightTop;
        if (m_buttonLeftDown != null)
            m_buttonLeftDown.action.performed += OnButtonLeftDown;
        if (m_buttonRightDown != null)
            m_buttonRightDown.action.performed += OnButtonRightDown;
        if (m_buttonLeftJoystick != null)
            m_buttonLeftJoystick.action.performed += OnButtonLeftJoystick;
        if (m_buttonRightJoystick != null)
            m_buttonRightJoystick.action.performed += OnButtonRightJoystick;
        if (m_buttonLeftThumbRest != null)
            m_buttonLeftThumbRest.action.performed += OnButtonLeftThumbRest;
        if (m_buttonRightThumbRest != null)
            m_buttonRightThumbRest.action.performed += OnButtonRightThumbRest;

        if (m_menuLeft != null)
            m_menuLeft.action.performed += OnMenuLeft;
        if (m_menuRight != null)
            m_menuRight.action.performed += OnMenuRight;

        if (m_buttonLeftJoystick != null)
            m_touchLeftTop.action.performed += OnTouchLeftTop;
        if (m_touchRightTop != null)
            m_touchRightTop.action.performed += OnTouchRightTop;

        if (m_touchLeftDown != null)
            m_touchLeftDown.action.performed += OnTouchLeftDown;
        if (m_touchRightDown != null)
            m_touchRightDown.action.performed += OnTouchRightDown;
        if (m_touchLeftJoystick != null)
            m_touchLeftJoystick.action.performed += OnTouchLeftJoystick;
        if (m_touchRightJoystick != null)
            m_touchRightJoystick.action.performed += OnTouchRightJoystick;
        if (m_buttonLeftJoystick != null)
            m_touchLeftTrigger.action.performed += OnTouchLeftTrigger;
        if (m_touchRightTrigger != null)
            m_touchRightTrigger.action.performed += OnTouchRightTrigger;
        if (m_isLeftTracked != null)
            m_isLeftTracked.action.performed += OnIsLeftTracked;
        if (m_isRightTracked != null)
            m_isRightTracked.action.performed += OnIsRightTracked;

    }

    public void OnDisable()
    {

        if (m_joystickLeftHorizontal != null)
            m_joystickLeftHorizontal.action.performed -= OnJoystickLeftHorizontal;
        if (m_joystickRightHorizontal != null)
            m_joystickLeftVertical.action.performed -= OnJoystickLeftVertical;
        if (m_joystickRightHorizontal != null)
            m_joystickRightHorizontal.action.performed -= OnJoystickRightHorizontal;
        if (m_joystickRightVertical != null)
            m_joystickRightVertical.action.performed -= OnJoystickRightVertical;
        if (m_triggerLeft != null)
            m_triggerLeft.action.performed -= OnTriggerLeftFloatValue;
        if (m_triggerRight != null)
            m_triggerRight.action.performed -= OnTriggerRightFloatValue;
        if (m_gripLeft != null)
            m_gripLeft.action.performed -= OnGripLeftFloatValue;
        if (m_gripRight != null)
            m_gripRight.action.performed -= OnGripRightFloatValue;

        if (m_buttonLeftTop != null)
            m_buttonLeftTop.action.performed -= OnButtonLeftTop;
        if (m_buttonRightTop != null)
            m_buttonRightTop.action.performed -= OnButtonRightTop;
        if (m_buttonLeftDown != null)
            m_buttonLeftDown.action.performed -= OnButtonLeftDown;
        if (m_buttonRightDown != null)
            m_buttonRightDown.action.performed -= OnButtonRightDown;
        if (m_buttonLeftJoystick != null)
            m_buttonLeftJoystick.action.performed -= OnButtonLeftJoystick;
        if (m_buttonRightJoystick != null)
            m_buttonRightJoystick.action.performed -= OnButtonRightJoystick;
        if (m_buttonLeftThumbRest != null)
            m_buttonLeftThumbRest.action.performed -= OnButtonLeftThumbRest;
        if (m_buttonRightThumbRest != null)
            m_buttonRightThumbRest.action.performed -= OnButtonRightThumbRest;
        if (m_menuLeft != null)
            m_menuLeft.action.performed -= OnMenuLeft;
        if (m_menuRight != null)
            m_menuRight.action.performed -= OnMenuRight;
        if (m_buttonLeftJoystick != null)
            m_touchLeftTop.action.performed -= OnTouchLeftTop;
        if (m_touchRightTop != null)
            m_touchRightTop.action.performed -= OnTouchRightTop;
        if (m_touchLeftDown != null)
            m_touchLeftDown.action.performed -= OnTouchLeftDown;
        if (m_touchRightDown != null)
            m_touchRightDown.action.performed -= OnTouchRightDown;
        if (m_touchLeftJoystick != null)
            m_touchLeftJoystick.action.performed -= OnTouchLeftJoystick;
        if (m_touchRightJoystick != null)
            m_touchRightJoystick.action.performed -= OnTouchRightJoystick;
        if (m_buttonLeftJoystick != null)
            m_touchLeftTrigger.action.performed -= OnTouchLeftTrigger;
        if (m_touchRightTrigger != null)
            m_touchRightTrigger.action.performed -= OnTouchRightTrigger;
        if (m_isLeftTracked != null)
            m_isLeftTracked.action.performed -= OnIsLeftTracked;
        if (m_isRightTracked != null)
            m_isRightTracked.action.performed -= OnIsRightTracked;
    }



    private void OnIsRightTracked(InputAction.CallbackContext context)
    {

        m_target.SetIsRightTracked(context.ReadValue<float>() > 0.5f);
    }

    private void OnIsLeftTracked(InputAction.CallbackContext context)
    {
        m_target.SetIsLeftTracked(context.ReadValue<float>() > 0.5f);
    }

    private void OnTouchRightTrigger(InputAction.CallbackContext context)
    {
        m_target.SetTriggerRightTouch(context.ReadValue<float>() > 0.5f);
    }

    private void OnTouchLeftTrigger(InputAction.CallbackContext context)
    {
        m_target.SetTriggerLeftTouch(context.ReadValue<float>() > 0.5f);
    }

    private void OnTouchRightJoystick(InputAction.CallbackContext context)
    {
        m_target.SetJoystickRightTouch(context.ReadValue<float>() > 0.5f);
    }

    private void OnTouchLeftJoystick(InputAction.CallbackContext context)
    {
        m_target.SetJoystickLeftTouch(context.ReadValue<float>() > 0.5f);
    }

    private void OnTouchRightDown(InputAction.CallbackContext context)
    {
        m_target.SetDownRightTouch(context.ReadValue<float>() > 0.5f);
    }

    private void OnTouchLeftDown(InputAction.CallbackContext context)
    {
        m_target.SetDownLeftTouch(context.ReadValue<float>() > 0.5f);
    }

    private void OnTouchRightTop(InputAction.CallbackContext context)
    {
        m_target.SetTopRightTouch(context.ReadValue<float>() > 0.5f);   
    }

    private void OnTouchLeftTop(InputAction.CallbackContext context)
    {
        m_target.SetTopLeftTouch(context.ReadValue<float>() > 0.5f);
    }

    private void OnMenuRight(InputAction.CallbackContext context)
    {
        m_target.SetMenuRight(context.ReadValue<float>() > 0.5f);
    }

    private void OnMenuLeft(InputAction.CallbackContext context)
    {
        m_target.SetMenuLeft(context.ReadValue<float>() > 0.5f);
    }

    private void OnButtonRightThumbRest(InputAction.CallbackContext context)
    {
        m_target.SetThumbRestRight(context.ReadValue<float>() > 0.5f);
    }

    private void OnButtonLeftThumbRest(InputAction.CallbackContext context)
    {
        m_target.SetThumbRestLeft(context.ReadValue<float>() > 0.5f);
    }

    private void OnButtonRightJoystick(InputAction.CallbackContext context)
    {
        m_target.SetJoystickRight(context.ReadValue<float>() > 0.5f);
    }

    private void OnButtonLeftJoystick(InputAction.CallbackContext context)
    {
        m_target.SetJoystickLeft(context.ReadValue<float>() > 0.5f);
    }

    private void OnButtonRightDown(InputAction.CallbackContext context)
    {
        m_target.SetDownRight(context.ReadValue<float>() > 0.5f);
    }

    private void OnButtonLeftDown(InputAction.CallbackContext context)
    {
        m_target.SetDownLeft(context.ReadValue<float>() > 0.5f);
    }

    private void OnButtonRightTop(InputAction.CallbackContext context)
    {
        m_target.SetTopRight(context.ReadValue<float>() > 0.5f);
    }

    private void OnButtonLeftTop(InputAction.CallbackContext context)
    {
        m_target.SetTopLeft(context.ReadValue<float>() > 0.5f);
    }

    private void OnGripRightFloatValue(InputAction.CallbackContext context)
    {
        m_target.SetGripRight(context.ReadValue<float>() );
        m_target.SetIsGripRightPressing(context.ReadValue<float>() > m_gripThresholdForButton);
    }

    private void OnGripLeftFloatValue(InputAction.CallbackContext context)
    {
        m_target.SetGripLeft(context.ReadValue<float>());
        m_target.SetIsGripLeftPressing(context.ReadValue<float>() > m_gripThresholdForButton);
    }

    private void OnTriggerRightFloatValue(InputAction.CallbackContext context)
    {
        m_target.SetTriggerRight(context.ReadValue<float>());
        m_target.SetIsTriggerRightPressing(context.ReadValue<float>() > m_triggerthresholdForButton);
    }

    private void OnTriggerLeftFloatValue(InputAction.CallbackContext context)
    {
        m_target.SetTriggerLeft(context.ReadValue<float>());
        m_target.SetIsTriggerLeftPressing(context.ReadValue<float>() > m_triggerthresholdForButton);
    }

    private void OnJoystickRightVertical(InputAction.CallbackContext context)
    {
        m_target.SetLeftHorizontal(context.ReadValue<float>());
    }

    private void OnJoystickRightHorizontal(InputAction.CallbackContext context)
    {
        m_target.SetLeftVertical(context.ReadValue<float>());
    }

    private void OnJoystickLeftVertical(InputAction.CallbackContext context)
    {
        m_target.SetRightHorizontal(context.ReadValue<float>());
    }

    private void OnJoystickLeftHorizontal(InputAction.CallbackContext context)
    {
        m_target.SetRightVertical(context.ReadValue<float>());
    }


}