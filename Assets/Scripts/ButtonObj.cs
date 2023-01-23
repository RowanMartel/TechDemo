using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ButtonObj : MonoBehaviour
{
    GameObject player;
    public GameObject obj;

    public bool ActivateSetObjActive;
    public bool ActivateSetObjInactive;
    public bool ActivateToggleObjActive;

    public Material ButtonMaterial;
    public Material PressedMaterial;

    private void Start()
    {
        GetComponent<Renderer>().material = ButtonMaterial;
    }

    public void Activate()
    {
        GetComponent<Renderer>().material = PressedMaterial;

        if (ActivateSetObjActive)
            SetObjActive();
        if (ActivateSetObjInactive)
            SetObjInactive();
        if (ActivateToggleObjActive)
            ToggleObjActive();

        StartCoroutine("UnPress");
    }
    private IEnumerator UnPress()
    {
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material = ButtonMaterial;
    }

    public void SetObjInactive()
    {
        obj.gameObject.SetActive(false);
    }
    public void SetObjActive()
    {
        obj.gameObject.SetActive(true);
    }
    public void ToggleObjActive()
    {
        if (obj.activeInHierarchy)
            SetObjInactive();
        else
            SetObjActive();
    }
}