using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    private ClearCounter clearCounter;

    public KitchenObjectSO GetKitchenObjectSo()
    {
        return kitchenObjectSO;
    }

    public void SetClearCounter (ClearCounter clearCounter)
    {
        if (this.clearCounter !=  null)
        {
            this.clearCounter.clearkitchenObject();
        }

        this.clearCounter = clearCounter;

        if (clearCounter.HasKitchenObject())
        {
            Debug.LogError("Counter already has a kitchen on=bject!");

        }

        clearCounter.SetKitchenObject(this);


        transform.parent = clearCounter.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }

    public ClearCounter GetClearCounter()
    {
        return clearCounter;
    } 
}
