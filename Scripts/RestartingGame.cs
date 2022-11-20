using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartingGame : MonoBehaviour
{
    private PlayButton button;

    private InputMaster controls;

    private void Awake()
    {
        controls = new InputMaster();
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
    void Start()
    {
        controls.PlayerInput.UIButton.performed += _ => UIButton();
        button = FindObjectOfType<PlayButton>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void UIButton()
    {
        button.StartingGamesd();
    }

}
