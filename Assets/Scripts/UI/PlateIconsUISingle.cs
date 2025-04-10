using UnityEngine;
using UnityEngine.UI;

public class PlateIconsUISingle : MonoBehaviour
{
    [SerializeField] private Image image;

    public void SetKitchenObjectSO(KitchenObjectSO kitchenObjectSo)
    {
        image.sprite = kitchenObjectSo.sprite;
    }
}
