using UnityEngine;
using UnityEngine.UI;

public class PrestigeMechanics : MonoBehaviour
{
    [SerializeField] private GameObject prestigePanel;

    [SerializeField] private Text moneyText;

    [SerializeField] private Text expText;
    [SerializeField] private Text maxExpText;
    [SerializeField] private Text lvlText;

    [SerializeField] private Text phoneText;
    [SerializeField] private Text phoneCostText;
    [SerializeField] private Image phoneImage;
    [SerializeField] private Image buyPhoneButtonImage;

    [SerializeField] private Text pcText;
    [SerializeField] private Text pcCostText;
    [SerializeField] private Image pcImage;
    [SerializeField] private Image buyPcButtonImage;

    [SerializeField] private Text flatText;
    [SerializeField] private Text flatCostText;
    [SerializeField] private Image flatImage;
    [SerializeField] private Image buyFlatButtonImage;

    [SerializeField] private Text carText;
    [SerializeField] private Text carCostText;
    [SerializeField] private Image carImage;
    [SerializeField] private Image buyCarButtonImage;

    [SerializeField] private Text mansionText;
    [SerializeField] private Text mansionCostText;
    [SerializeField] private Image mansionImage;
    [SerializeField] private Image buyMansionButtonImage;

    [SerializeField] private Text helicopterText;
    [SerializeField] private Text helicopterCostText;
    [SerializeField] private Image helicopterImage;
    [SerializeField] private Image buyHelicopterButtonImage;

    [SerializeField] private Text yachtText;
    [SerializeField] private Text yachtCostText;
    [SerializeField] private Image yachtImage;
    [SerializeField] private Image buyYachtButtonImage;

    [SerializeField] private Text privatePlaneText;
    [SerializeField] private Text privatePlaneCostText;
    [SerializeField] private Image privatePlaneImage;
    [SerializeField] private Image buyPrivatePlaneButtonImage;

    [SerializeField] private Text rocketText;
    [SerializeField] private Text rocketCostText;
    [SerializeField] private Image rocketImage;
    [SerializeField] private Image buyRocketButtonImage;

    [SerializeField] private Text planetText;
    [SerializeField] private Text planetCostText;
    [SerializeField] private Image planetImage;
    [SerializeField] private Image buyPlanetButtonImage;

    [SerializeField] private MainData mainData;
    [SerializeField] private SpritesData spritesData;

    private void Start()
    {
        prestigePanel.SetActive(false);
        UpdateUI(mainData.phoneData, spritesData.phoneSprites, phoneText, phoneCostText, phoneImage, buyPhoneButtonImage);
        UpdateUI(mainData.PCData, spritesData.pcSprites, pcText, pcCostText, pcImage, buyPcButtonImage);
        UpdateUI(mainData.flatData, spritesData.flatSprites, flatText, flatCostText, flatImage, buyFlatButtonImage);
        UpdateUI(mainData.carData, spritesData.carSprites, carText, carCostText, carImage, buyCarButtonImage);
        UpdateUI(mainData.mansionData, spritesData.mansionSprites, mansionText, mansionCostText, mansionImage, buyMansionButtonImage);
        UpdateUI(mainData.helicopterData, spritesData.helicopterSprites, helicopterText, helicopterCostText, helicopterImage, buyHelicopterButtonImage);
        UpdateUI(mainData.yachtData, spritesData.yachtSprites, yachtText, yachtCostText, yachtImage, buyYachtButtonImage);
        UpdateUI(mainData.privatePlaneData, spritesData.privatePlaneSprites, privatePlaneText, privatePlaneCostText, privatePlaneImage, buyPrivatePlaneButtonImage);
        UpdateUI(mainData.rocketData, spritesData.rocketSprites, rocketText, rocketCostText, rocketImage, buyRocketButtonImage);
        UpdateUI(mainData.planetData, spritesData.planetSprites, planetText, planetCostText, planetImage, buyPlanetButtonImage);
    }

    public void OpenPanel()
    {
        prestigePanel.SetActive(true);
        UpdateUI(mainData.phoneData, spritesData.phoneSprites, phoneText, phoneCostText, phoneImage, buyPhoneButtonImage);
        UpdateUI(mainData.PCData, spritesData.pcSprites, pcText, pcCostText, pcImage, buyPcButtonImage);
        UpdateUI(mainData.flatData, spritesData.flatSprites, flatText, flatCostText, flatImage, buyFlatButtonImage); UpdateUI(mainData.carData, spritesData.carSprites, carText, carCostText, carImage, buyCarButtonImage);
        UpdateUI(mainData.mansionData, spritesData.mansionSprites, mansionText, mansionCostText, mansionImage, buyMansionButtonImage);
        UpdateUI(mainData.helicopterData, spritesData.helicopterSprites, helicopterText, helicopterCostText, helicopterImage, buyHelicopterButtonImage);
        UpdateUI(mainData.yachtData, spritesData.yachtSprites, yachtText, yachtCostText, yachtImage, buyYachtButtonImage);
        UpdateUI(mainData.privatePlaneData, spritesData.privatePlaneSprites, privatePlaneText, privatePlaneCostText, privatePlaneImage, buyPrivatePlaneButtonImage);
        UpdateUI(mainData.rocketData, spritesData.rocketSprites, rocketText, rocketCostText, rocketImage, buyRocketButtonImage);
        UpdateUI(mainData.planetData, spritesData.planetSprites, planetText, planetCostText, planetImage, buyPlanetButtonImage);
    }

    public void ClosePanel()
    {
        prestigePanel.SetActive(false);
    }

    private void UpdateUI(PrestigeData prestigeData, PrestigeSpritesData prestigeSpritesData, Text thingText, 
        Text thingCost, Image thingImage, Image buyThingButtonImage)
    {
        moneyText.text = mainData.otherData.money.ToString("F2");
        lvlText.text = mainData.otherData.lvl.ToString();
        expText.text = mainData.otherData.exp.ToString();
        maxExpText.text = mainData.otherData.maxExp.ToString();

        if (prestigeData.canUpgrade)
        {
            thingText.text = prestigeData.unlockThingText;
            thingCost.text = prestigeData.thingCost.ToString("F2");
            thingImage.sprite = prestigeSpritesData.unlockThingSprite;
            buyThingButtonImage.sprite = prestigeSpritesData.unlockButtonSprite;
        }
        else
        {
            thingText.text = prestigeData.lockThingText;
            thingCost.text = prestigeData.lockThingText;
            thingImage.sprite = prestigeSpritesData.lockThingSprite;
            buyThingButtonImage.sprite = prestigeSpritesData.lockButtonSprite;
        }     
    }

    private void UpgradeThing(PrestigeData prestigeData)
    {
        if(prestigeData.canUpgrade && mainData.otherData.money >= prestigeData.thingCost)
        {
            mainData.otherData.money -= prestigeData.thingCost;

            if (!prestigeData.wasBought)
            {
                mainData.otherData.lastIndex++;
                prestigeData.wasBought = true;
            }

            mainData.otherData.exp += prestigeData.giveExp;

            prestigeData.thingCost *= 1.3f;
        }
    }

    private void CanBuyLogic(PrestigeData prestigeData)
    {
        if(prestigeData.thingID == mainData.otherData.lastIndex + 1) prestigeData.canUpgrade = true;
    }

    private void LevelUpMechanic()
    {
        if(mainData.otherData.exp >= mainData.otherData.maxExp)
        {
            mainData.otherData.exp -= mainData.otherData.maxExp;
            mainData.otherData.maxExp *= 2;
            mainData.otherData.lvl++;
        }
    }

    private void Update()
    {
        CanBuyLogic(mainData.phoneData);
        CanBuyLogic(mainData.PCData);
        CanBuyLogic(mainData.flatData);
        CanBuyLogic(mainData.carData);
        CanBuyLogic(mainData.mansionData);
        CanBuyLogic(mainData.helicopterData);
        CanBuyLogic(mainData.yachtData);
        CanBuyLogic(mainData.privatePlaneData);
        CanBuyLogic(mainData.rocketData);
        CanBuyLogic(mainData.planetData);
        UpdateUI(mainData.phoneData, spritesData.phoneSprites, phoneText, phoneCostText, phoneImage, buyPhoneButtonImage);
        UpdateUI(mainData.PCData, spritesData.pcSprites, pcText, pcCostText, pcImage, buyPcButtonImage);
        UpdateUI(mainData.flatData, spritesData.flatSprites, flatText, flatCostText, flatImage, buyFlatButtonImage);
        UpdateUI(mainData.carData, spritesData.carSprites, carText, carCostText, carImage, buyCarButtonImage);
        UpdateUI(mainData.mansionData, spritesData.mansionSprites, mansionText, mansionCostText, mansionImage, buyMansionButtonImage);
        UpdateUI(mainData.helicopterData, spritesData.helicopterSprites, helicopterText, helicopterCostText, helicopterImage, buyHelicopterButtonImage);
        UpdateUI(mainData.yachtData, spritesData.yachtSprites, yachtText, yachtCostText, yachtImage, buyYachtButtonImage);
        UpdateUI(mainData.privatePlaneData, spritesData.privatePlaneSprites, privatePlaneText, privatePlaneCostText, privatePlaneImage, buyPrivatePlaneButtonImage);
        UpdateUI(mainData.rocketData, spritesData.rocketSprites, rocketText, rocketCostText, rocketImage, buyRocketButtonImage);
        UpdateUI(mainData.planetData, spritesData.planetSprites, planetText, planetCostText, planetImage, buyPlanetButtonImage);
        LevelUpMechanic();
    }

    public void UpgradePhone()
    {
        //CanBuyLogic(mainData.phoneData);
        UpgradeThing(mainData.phoneData);
        UpdateUI(mainData.phoneData, spritesData.phoneSprites, phoneText, phoneCostText, phoneImage, buyPhoneButtonImage);
    }

    public void UpgradePC()
    {
        CanBuyLogic(mainData.PCData);
        UpgradeThing(mainData.PCData);
        UpdateUI(mainData.PCData, spritesData.pcSprites, pcText, pcCostText, pcImage, buyPcButtonImage);
    }

    public void UpgradeFlat()
    {
        CanBuyLogic(mainData.flatData);
        UpgradeThing(mainData.flatData);
        UpdateUI(mainData.flatData, spritesData.flatSprites, flatText, flatCostText, flatImage, buyFlatButtonImage);
    }

    public void UpgradeCar()
    {
        CanBuyLogic(mainData.carData);
        UpgradeThing(mainData.carData);
        UpdateUI(mainData.carData, spritesData.carSprites, carText, carCostText, carImage, buyCarButtonImage);
    }

    public void UpgradeMansion()
    {
        CanBuyLogic(mainData.mansionData);
        UpgradeThing(mainData.mansionData);
        UpdateUI(mainData.mansionData, spritesData.mansionSprites, mansionText, mansionCostText, mansionImage, buyMansionButtonImage);
    }

    public void UpgradeHelicopter()
    {
        CanBuyLogic(mainData.helicopterData);
        UpgradeThing(mainData.helicopterData);
        UpdateUI(mainData.helicopterData, spritesData.helicopterSprites, helicopterText, helicopterCostText, helicopterImage, buyHelicopterButtonImage);
    }

    public void UpgradeYacht()
    {
        CanBuyLogic(mainData.yachtData);
        UpgradeThing(mainData.yachtData);
        UpdateUI(mainData.yachtData, spritesData.yachtSprites, yachtText, yachtCostText, yachtImage, buyYachtButtonImage);
    }

    public void UpgradePrivatePlane()
    {
        CanBuyLogic(mainData.privatePlaneData);
        UpgradeThing(mainData.privatePlaneData);
        UpdateUI(mainData.privatePlaneData, spritesData.privatePlaneSprites, privatePlaneText, privatePlaneCostText, privatePlaneImage, buyPrivatePlaneButtonImage);
    }

    public void UpgradeRocket()
    {
        CanBuyLogic(mainData.rocketData);
        UpgradeThing(mainData.rocketData);
        UpdateUI(mainData.rocketData, spritesData.rocketSprites, rocketText, rocketCostText, rocketImage, buyRocketButtonImage);
    }

    public void UpgradePlanet()
    {
        CanBuyLogic(mainData.planetData);
        UpgradeThing(mainData.planetData);
        UpdateUI(mainData.planetData, spritesData.planetSprites, planetText, planetCostText, planetImage, buyPlanetButtonImage);
    }
}