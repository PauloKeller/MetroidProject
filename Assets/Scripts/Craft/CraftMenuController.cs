using UnityEngine;
using TMPro;
using UnityEngine.UI;
using PlasticGui;

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
    [SerializeField]
    Button energyCellButton;
    [SerializeField]
    Button cryogenicCellButton;
    [SerializeField]
    Button nuclearCellButton;
    [SerializeField]
    Button nuclearMissileButton;
    [SerializeField]
    Button energyMissileButton;


    CraftUseCase useCase;

    private AmmoReceipt selectedReceipt = new MetalBulletReceipt(new BaseAmmoReceipt());
    private int amount = 0;

    private void Awake()
    {
        useCase = new CraftUseCase(resourceRepository: new ResourceRepository(), ammoRepository: new AmmoRepository());
    }

    void Start()
    {
        LoadUIData();
        SetupUI();
    }

    public void CraftItem()
    {
        try
        {
            useCase.CraftAmmoReceipt(amount: amount, receipt: selectedReceipt);
            string text = $"{amount} of {selectedReceipt.Name} created";

            UpdateResourcesLabels();
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
        selectedReceipt = new FlammableBulletReceipt(new MetalBulletReceipt(new BaseAmmoReceipt()));
        UpdateReceiptLabel(selectedReceipt.Name);
    }

    public void MetalBulletButtonPressed()
    {
        selectedReceipt = new MetalBulletReceipt(new BaseAmmoReceipt());
        UpdateReceiptLabel(selectedReceipt.Name);
    }

    public void FlammableFuelButtonPressed()
    {
        selectedReceipt = new FlammableFuelReceipt(new BaseAmmoReceipt());
        UpdateReceiptLabel(selectedReceipt.Name);
    }

    public void CryogenicFuelButtonPressed()
    {
        selectedReceipt = new CryogenicFuelReceipt(new FlammableFuelReceipt(new BaseAmmoReceipt()));
        UpdateReceiptLabel(selectedReceipt.Name);
    }
    public void ChemicalFuelButtonPressed()
    {
        selectedReceipt = new ChemicalFuelReceipt(new CryogenicFuelReceipt(new FlammableFuelReceipt(new BaseAmmoReceipt())));
        UpdateReceiptLabel(selectedReceipt.Name);
    }
    public void EnergyCellButtonPressed()
    {
        selectedReceipt = new EnergyCellReceipt(new BaseAmmoReceipt());
        UpdateReceiptLabel(selectedReceipt.Name);
    }
    public void CryogenicCellButtonPressed()
    {
        selectedReceipt = new CryogenicCellReceipt(new EnergyCellReceipt(new BaseAmmoReceipt()));
        UpdateReceiptLabel(selectedReceipt.Name);
    }
    public void NuclearCellButtonPressed()
    {
        selectedReceipt = new NuclearCellReceipt(new CryogenicCellReceipt(new EnergyCellReceipt(new BaseAmmoReceipt())));
        UpdateReceiptLabel(selectedReceipt.Name);
    }
    public void NuclearMissileButtonPressed()
    {
        selectedReceipt = new NuclearMissileReceipt(new BaseAmmoReceipt());
        UpdateReceiptLabel(selectedReceipt.Name);
    }
    public void EnergyMissileButtonPressed()
    {
        selectedReceipt = new EnergyMissileReceipt(new NuclearMissileReceipt(new BaseAmmoReceipt()));
        UpdateReceiptLabel(selectedReceipt.Name);
    }
    public void LoadUIData() 
    {
        UpdateResourcesLabels();
        UpdateReceiptLabel(selectedReceipt.Name);  
    }

    private void SetupUI()
    {
        chemicalFuelButton.onClick.AddListener(ChemicalFuelButtonPressed);
        energyCellButton.onClick.AddListener(EnergyCellButtonPressed);
        cryogenicCellButton.onClick.AddListener(CryogenicCellButtonPressed);
        nuclearCellButton.onClick.AddListener(NuclearCellButtonPressed);
        nuclearMissileButton.onClick.AddListener(NuclearMissileButtonPressed);
        energyMissileButton.onClick.AddListener(EnergyMissileButtonPressed);

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
        if (useCase.ResourceDictionary.ContainsKey(ResourceType.Metal)) 
        {
            metallicAmountLabel.text = useCase.ResourceDictionary[ResourceType.Metal].quantity.ToString();
        }

        if (useCase.ResourceDictionary.ContainsKey(ResourceType.Flammable))
        {
            flammableAmountLabel.text = useCase.ResourceDictionary[ResourceType.Flammable].quantity.ToString();
        }

        if (useCase.ResourceDictionary.ContainsKey(ResourceType.Cryogenic))
        {
            cryogenicAmountLabel.text = useCase.ResourceDictionary[ResourceType.Cryogenic].quantity.ToString();
        }

        if (useCase.ResourceDictionary.ContainsKey(ResourceType.Chemical))
        {
            chemicalAmountLabel.text = useCase.ResourceDictionary[ResourceType.Chemical].quantity.ToString();
        }

        if (useCase.ResourceDictionary.ContainsKey(ResourceType.Energy))
        {
            energyAmountLabel.text = useCase.ResourceDictionary[ResourceType.Energy].quantity.ToString();
        }

        if (useCase.ResourceDictionary.ContainsKey(ResourceType.Nuclear))
        {
            nuclearAmountLabel.text = useCase.ResourceDictionary[ResourceType.Nuclear].quantity.ToString();
        }
    }
}
