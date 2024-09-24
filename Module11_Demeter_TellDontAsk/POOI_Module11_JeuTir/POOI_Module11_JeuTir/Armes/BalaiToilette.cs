using POOI_Module11_JeuTir.Sons;
using System;

namespace POOI_Module11_JeuTir.Armes;

public class BalaiToilette : Arme
{
    public BalaiToilette() : base(new Son() { TexteDuSon = "Chtac" }, new Son() { TexteDuSon = "Chplouf" })
    {
        ;
    }

    protected override double CalculerDegat()
    {
        return (new Random(DateTime.Now.Millisecond)).NextDouble() * 40 + 10;
    }
}
