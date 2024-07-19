using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CraftController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI metallicAmountLabel;
    [SerializeField]
    TextMeshProUGUI flammableAmountLabel;
    [SerializeField]
    TextMeshProUGUI cryogenicAmountLabel;
    [SerializeField]
    TextMeshProUGUI chemicalAmountLabel;
    [SerializeField]
    TextMeshProUGUI energyAmountLabel;
    [SerializeField]
    TextMeshProUGUI nuclearAmountLabel;
    [SerializeField]
    TextMeshProUGUI receiptLabel;
    [SerializeField]
    Button chemicalFuelButton;

    CraftUseCase useCase;

    private AmmoReceipt selectedReceipt = new MetalBulletReceipt(new BaseBulletReceipt());
    private int amount = 0;

    private void Awake()
    {
        useCase = new CraftUseCase();
    }

    void Start()
    {
        LoadUIData();
    }

    public void CraftItem()
    {
        try
        {
            BulletAmmoStack ammoStack = useCase.CraftAmmoReceipt(amount: amount, receipt: selectedReceipt);
            string text = $"{ammoStack.amount} of {ammoStack.bullet.GetType()} created";
            UpdateReceiptLabel(text);
        }
        catch (CraftMenuException error)
        {
            string text = "";

            switch (error.code)
            {
                case CraftMenuExceptionCode.NotEnoughMaterials:
                    text = "Not enough materials";
                    break;
                case CraftMenuExceptionCode.NotAbleToCraftReceipt:
                    text = "Not able to craft receipt";
                    break;
            }

            UpdateReceiptLabel(text);
        }
    }

    public void FlameBulletButtonPressed() 
    {
        selectedReceipt = new FlammableBulletReceipt(new MetalBulletReceipt(new BaseBulletReceipt()));
        UpdateReceiptLabel(selectedReceipt.Name);
    }

    public void MetalBulletButtonPressed()
    {
        selectedReceipt = new MetalBulletReceipt(new BaseBulletReceipt());
        UpdateReceiptLabel(selectedReceipt.Name);
    }

    public void FlammableFuelButtonPressed()
    {
        selectedReceipt = new FlammableFuelReceipt(new BaseFuelReceipt());
        UpdateReceiptLabel(selectedReceipt.Name);
    }

    public void CryogenicFuelButtonPressed()
    {
        selectedReceipt = new CryogenicCellReceipt(new FlammableFuelReceipt(new BaseFuelReceipt()));
        UpdateReceiptLabel(selectedReceipt.Name);
    }

    public void ChemicalFuelButtonPressed()
    {
        selectedReceipt = new ChemicalFuelReceipt(new CryogenicCellReceipt(new FlammableFuelReceipt(new BaseFuelReceipt())));
        UpdateReceiptLabel(selectedReceipt.Name);
    }

    public void LoadUIData() 
    {
        UpdateResourcesLabels();
        UpdateReceiptLabel(selectedReceipt.Name);

        chemicalFuelButton.onClick.AddListener(ChemicalFuelButtonPressed);
    }

    public void AmountTextFieldOnValueChanged(string text) 
    {
        amount = int.Parse(text);
    }

    private void UpdateReceiptLabel(string text)
    {
        receiptLabel.text = text;
    }

    private void UpdateResourcesLabels()
    {
        metallicAmountLabel.text = useCase.MetalStack.quantity.ToString();
        flammableAmountLabel.text = useCase.FlammableStack.quantity.ToString();
        cryogenicAmountLabel.text = useCase.CryogenicStack.quantity.ToString();
        chemicalAmountLabel.text = useCase.ChemicalbleStack.quantity.ToString();
        energyAmountLabel.text = useCase.EnergyStack.quantity.ToString();
        nuclearAmountLabel.text = useCase.NuclearStack.quantity.ToString();
    }
}
