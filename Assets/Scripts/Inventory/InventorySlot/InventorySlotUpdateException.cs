using System;

public class InventorySlotUpdateException : Exception
{
    InventorySlotExceptionCode code;

    public InventorySlotExceptionCode Code
    {
        get { return code; }
    }

    public InventorySlotUpdateException(InventorySlotExceptionCode code)
    {
        this.code = code;
    }
}