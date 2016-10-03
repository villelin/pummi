﻿using UnityEngine;
using System.Collections;

public class Inspector : NPC
{
    private DialogPage page1;

    public Inspector() : base("Lipuntarkastaja")
    {
        page1 = new DialogPage(DialogPageImage.Inspector);

        page1.SetText("A WILD INSPECTOR APPEARS!\n\nHemmetin pummi. Nyt saat keppiä!");
        page1.SetLast("APUAAAA");
        page1.SetGameOver();

        AdvanceDialog(page1);
    }
}
