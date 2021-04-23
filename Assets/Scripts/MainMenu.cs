using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] int money;
    public int totalMoney;
    public Text moneyTxt;
    // Start is called before the first frame update
    private void Start() {
        money = PlayerPrefs.GetInt("money");
        totalMoney = PlayerPrefs.GetInt("totalMoney");
    }
    public void BtnClick(){
        money++;
        totalMoney = money;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("totalMoney", totalMoney);
    }

    public void toAchievments(){
        SceneManager.LoadScene("Achievments");
    }

    // Update is called once per frame
    void Update()
    {
        moneyTxt.text = money.ToString();
    }
}
