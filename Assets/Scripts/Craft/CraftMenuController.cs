using UnityEngine;
using TMPro;
using UnityEngine.Localization.Tables;

public class CraftController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI metallicAmountLabel;
    [SerializeField]
    TextMeshProUGUI flammableAmountLabel;
    [SerializeField]
    TextMeshProUGUI chemicalAmountLabel;
    [SerializeField]
    TextMeshProUGUI energyAmountLabel;
    [SerializeField]
    TextMeshProUGUI nuclearAmountLabel;
    [SerializeField]
    TextMeshProUGUI receiptLabel;

    CraftUseCase useCase;

    private BulletReceipt selectedBulletReceipt = new MetalBulletReceipt(new BaseBulletReceipt());
    private int amount = 0;

    private void Awake()
    {
        useCase = new CraftUseCase();
    }

    // Start is called before the first frame update
    void Start()
    {
        LoadUIData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CraftItem()
    {
        try
        {
            BulletAmmoStack ammoStack = useCase.CraftBullet(amount: amount, selectedBulletReceipt);
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
        selectedBulletReceipt = new FlammableBulletReceipt(new BaseBulletReceipt());
        UpdateReceiptLabel(selectedBulletReceipt.Name);
    }

    public void MetalBulletButtonPressed()
    {
        selectedBulletReceipt = new MetalBulletReceipt(new BaseBulletReceipt());
        UpdateReceiptLabel(selectedBulletReceipt.Name);
    }

    public void LoadUIData() 
    {
        UpdateResourcesLabels();
        UpdateReceiptLabel(selectedBulletReceipt.Name);
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
        metallicAmountLabel.text = useCase.MetalStack.amount.ToString();
        flammableAmountLabel.text = useCase.FlammableStack.amount.ToString();
        chemicalAmountLabel.text = useCase.ChemicalbleStack.amount.ToString();
        energyAmountLabel.text = useCase.EnergyStack.amount.ToString();
        nuclearAmountLabel.text = useCase.NuclearStack.amount.ToString();
    }
}
