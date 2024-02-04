using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;

    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
    }

    void Update()
    {
        //Créer un ray au centre de la camera, shooting outwards.
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo; //Variable pour stocker les informations de collision
        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {

        }
    }
}
