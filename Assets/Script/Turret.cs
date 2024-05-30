using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using static UnityEngine.GraphicsBuffer;

public class Turret : MonoBehaviour,IGrabbable
{
    Turret prefab;
    private void Awake()
    {
        prefab = GetComponent<Turret>();
    }
    private void OnDrawGizmos()
    {        
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(this.transform.position,2f);
        Gizmos.color= Color.red;
        //Gizmos.DrawRay(Input.mousePosition,Vector3.one);
    }


    private void OnEnable()
    {
        Hand.GrabItem += IsGrabbed;
    }
    private IEnumerator ObjectOnCursor(Turret turret)
    {
        while (Input.GetMouseButtonDown(0) == false)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 50, Color.red, 5);
            RaycastHit hit;
            Physics.Raycast(ray, out hit, 50);
            prefab.transform.position = hit.transform.position;
            yield return null;
        }
    }

    public void IsGrabbed()
    {
        Vector3 mousePosition = Input.mousePosition;
        prefab.gameObject.transform.position = mousePosition;   
        prefab.gameObject.SetActive(true);
        StartCoroutine(ObjectOnCursor(this));
    }


}
