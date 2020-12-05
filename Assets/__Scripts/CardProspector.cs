using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//An enum defines a variable type with a few prenamed values
public enum eCardState
{
    drawpile1=1,
    drawpile2=2,
    drawpile3=3,
    drawpile4=4,
    drawpile5=5,
    drawpile6=6,
    drawpile7=7,
    drawpile8=8,
    drawpile9=9,
    drawpile10=10,
    drawpile11=11,
    drawpile12=12,
    drawpile13=13,
    discardpile1,
    discardpile2,
    discardpile3,
    discardpile4,
    discardpile5,
    discardpile6,
    discardpile7,
    discardpile8,
    discardpile9,
    discardpile10,
    discardpile11,
    discardpile12,
    discardpile13,
    drawpile,
    tableau,
    discard,
    target
}

public class CardProspector : Card {

    [Header("Set Dynamically: CardProspector")]
    // This is how you use the enum eCardState
    public eCardState state = eCardState.drawpile;
    // The hiddenBy list stores which other cards will keep this one face down
    public List<CardProspector> hiddenBy = new List<CardProspector>();
    // The layoutID matches this card to the tableau XML if it's a tableau card
    public int layoutID;
    // The SlotDef class stores information pulled in from the LayoutXML <slot>
    public SlotDef slotDef;

	// This allows the card to react to being clicked
    override public void OnMouseUpAsButton()
    {
        // Call the CardClicked method on the Prospector Singleton
        Prospector.S.CardClicked(this);
        // Also call the base class (Card.cs) version of this method
        base.OnMouseUpAsButton();
    }
}
