using System;
using System.Collections;
using Unity.Cinemachine;
using UnityEngine;

public class DeliveryCounter : BaseCounter
{
    public static DeliveryCounter Instance { get; private set; }
    [SerializeField] private CinemachineCamera cam2;

    private void Awake()
    {
        Instance = this;
        cam2.gameObject.SetActive(false);
    }

    public override void Interact(Player player)
    {
        if (player.HasKitchenObject())
        {
            if (player.GetKitchenObject().TryGetPlate(out PlateKitchenObject plateKitchenObject))
            {
                // Only accepts Plates
                cam2.gameObject.SetActive(true);
                StartCoroutine(CamSwitch());
                DeliveryManager.Instance.DeliveryRecipe(plateKitchenObject);
                player.GetKitchenObject().DestroySelf();
            }
        }
    }

    IEnumerator CamSwitch()
    {
        yield return new WaitForSeconds(2f);
        cam2.gameObject.SetActive(false);
    }
}
