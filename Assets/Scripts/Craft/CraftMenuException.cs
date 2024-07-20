using System;

public enum CraftMenuExceptionCode
{
    NotEnoughMaterials,
    NotAbleToCraftReceipt
}

public class CraftMenuException : Exception
{
    public CraftMenuExceptionCode code;

    public CraftMenuException(CraftMenuExceptionCode code)
    {
        this.code = code;
    }
}
