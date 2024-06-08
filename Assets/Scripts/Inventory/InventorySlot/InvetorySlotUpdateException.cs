using System;

public class InvetorySlotUpdateException : Exception
{
    InventorySlotExceptionCode code;

    public InventorySlotExceptionCode Code
    {
        get { return code; }
    }

    public InvetorySlotUpdateException(InventorySlotExceptionCode code)
    {
        this.code = code;
    }
}