using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;

public class AutoFindInteractableAffordance : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<XRInteractorAffordanceStateProvider>().interactorSource = GetComponent<XRBaseInteractable>();
    }
}
