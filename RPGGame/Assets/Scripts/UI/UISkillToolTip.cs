using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UISkillToolTip : UIToolTip
{
    [SerializeField] private TextMeshProUGUI skillText;
    [SerializeField] private TextMeshProUGUI skillName;
    [SerializeField] private float defaultNameFontSize;
    [SerializeField] private TextMeshProUGUI skillCost;

    public void ShowToolTip(string _skillDescription,string _skillName,int _price)
    {
        skillName.text = _skillName;
        skillText.text = _skillDescription;
        skillCost.text = "Cost: " + _price;

        AdjustPosition();

        AdjustFontSize(skillName);

        gameObject.SetActive(true);
    }

    public void HideToolTip()
    {
        skillName.fontSize = defaultNameFontSize;
        gameObject.SetActive(false);
    }
}
