using System;
using System.Collections.Generic;
using UnityEngine;

// TODO: Should handle only the visualization of character stuff
public class InventoryController : MonoBehaviour
{
    private IInventoryUseCase useCase;

    private void Awake()
    {
        List<RawMaterialInventorySlot> rawMaterialSlots = new List<RawMaterialInventorySlot>
        { 
        };
        RawMaterialRepository rawMaterialRepository = new RawMaterialRepository();
        

        UpdateMaterials();
    }

    public void UpdateMaterials() 
    {
    }

    public void OnPutMaterial()
    {
    }
}