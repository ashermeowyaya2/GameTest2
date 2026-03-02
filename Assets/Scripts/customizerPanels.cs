using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class customizerPanels : MonoBehaviour
{   
        // Genes Panel Stuff
    public GameObject genesPanel;
    public GameObject panelSkin;
    public GameObject panelBrows;
    public GameObject panelOBrows;
    public GameObject panelEyes;
    public GameObject panelOEyes;
    public GameObject panelMouth;

    public void genesHidePanel(int x){
        genesPanel.SetActive(true);
        acessoriesPanel.SetActive(false);
        switch(x){
            default:
                panelSkin.SetActive(false);
                panelBrows.SetActive(false);
                panelOBrows.SetActive(false);
                panelEyes.SetActive(false);
                panelOEyes.SetActive(false);
                panelMouth.SetActive(false);
                break;
            case 1:
                panelSkin.SetActive(true);
                panelBrows.SetActive(false);
                panelOBrows.SetActive(false);
                panelEyes.SetActive(false);
                panelOEyes.SetActive(false);
                panelMouth.SetActive(false);
                break;
            case 2:
                panelSkin.SetActive(false);
                panelBrows.SetActive(true);
                panelOBrows.SetActive(true);
                panelEyes.SetActive(false);
                panelOEyes.SetActive(false);
                panelMouth.SetActive(false);
                break;
            case 3:
                panelSkin.SetActive(false);
                panelBrows.SetActive(false);
                panelOBrows.SetActive(false);
                panelEyes.SetActive(true);
                panelOEyes.SetActive(true);
                panelMouth.SetActive(false);
                break;
            case 4:
                panelSkin.SetActive(false);
                panelBrows.SetActive(false);
                panelOBrows.SetActive(false);
                panelEyes.SetActive(false);
                panelOEyes.SetActive(false);
                panelMouth.SetActive(true);
                break;
        }
    }

        // Accessories Stuff
    public GameObject acessoriesPanel;
        
    public void accHidePanel(int x){
        genesPanel.SetActive(false);
        acessoriesPanel.SetActive(true);
    }
}
