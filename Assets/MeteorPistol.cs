using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class MeteorPistol : MonoBehaviour
{
    public ParticleSystem particles;

    public LayerMask layerMask;
    public Transform shootSource;
    public float distance = 10;

    private bool rayActive = false;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartShoot());
        grabInteractable.deactivated.AddListener(x => StopShoot());
    }
    public void StartShoot()
    {
        AudioManager.instance.Play("Pistol");
        particles.Play();
        rayActive = true;
    }

    public void StopShoot()
    {
        AudioManager.instance.Stop("Pistol");
        particles.Stop(true,ParticleSystemStopBehavior.StopEmittingAndClear);
        rayActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(rayActive)
            RaycastCheck();
    }
    void RaycastCheck()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(shootSource.position, shootSource.forward,
            out hit, distance, layerMask);

        if (hasHit)
        {
            hit.transform.gameObject.SendMessage("Break", SendMessageOptions.DontRequireReceiver);
        }
    }
}
