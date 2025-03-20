using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] KitchenObjectSO kitchenObjectSo;
    
    [SerializeField] Transform counterTopPoint;
    public void Interact()
    {
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSo.prefab, counterTopPoint);
        kitchenObjectTransform.localPosition = Vector3.zero;

        Debug.Log(kitchenObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }
}
