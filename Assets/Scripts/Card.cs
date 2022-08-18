using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    private int number_;
    public int number { get => number_; }

    private Symbol symbol_;
    public Symbol symbol { get => symbol_; }
    
    public Card(int _number, Symbol _symbol)
    {
        number_ = _number;
        symbol_ = _symbol;
    }
}
