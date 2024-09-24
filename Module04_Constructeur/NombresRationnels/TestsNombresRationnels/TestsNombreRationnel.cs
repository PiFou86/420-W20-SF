using System;
using Xunit;
using NombresRationnels;
using FluentAssertions;
using System.Collections.Generic;

namespace TestsNombresRationnels;

public class TestsNombreRationnel
{
    [Fact]
    public void Ctr_CasNormal_ValeursDefiniesDenominateurPositif()
    {
        // Arranger
        int numerateur = 42;
        int denominateur = 42;

        // Agir
        NombreRationnel nr = new NombreRationnel(numerateur, denominateur);

        // Auditer
        nr.Numerateur.Should().Be(numerateur);
        nr.Denominateur.Should().Be(denominateur);
    }

    [Fact]
    public void Ctr_CasDenominateurNeg_ValeursDefiniesDenominateurPositif()
    {
        // Arranger
        int numerateur = 42;
        int denominateur = -42;
        int numerateurAttendu = -42;
        int denominateurAttendu = 42;

        // Agir
        NombreRationnel nr = new NombreRationnel(numerateur, denominateur);

        // Auditer
        nr.Numerateur.Should().Be(numerateurAttendu);
        nr.Denominateur.Should().Be(denominateurAttendu);
    }

    [Fact]
    public void Ctr_CasDenominateurZero_Exception()
    {
        // Arranger
        int numerateur = 42;
        int denominateur = 0;
        Action action = () => { NombreRationnel nr = new NombreRationnel(numerateur, denominateur); };


        // Agir && Auditer
        action.Should().Throw<ArgumentException>();
    }

    [Theory]
    [MemberData(nameof(GetAddOperator_CasGeneraux))]
    public void AddOperator_CasGeneraux_Rationnel(NombreRationnel p_operande1, NombreRationnel p_operande2, NombreRationnel p_resultatAttendu)
    {
        // Arranger (paramètres)

        // Agir
        NombreRationnel nr = p_operande1 + p_operande2;

        // Auditer
        nr.Should().Be(p_resultatAttendu);
    }

    [Theory]
    [MemberData(nameof(GetSubOperator_CasGeneraux))]
    public void SubOperator_CasGeneraux_Rationnel(NombreRationnel p_operande1, NombreRationnel p_operande2, NombreRationnel p_resultatAttendu)
    {
        // Arranger (paramètres)

        // Agir
        NombreRationnel nr = p_operande1 - p_operande2;

        // Auditer
        nr.Should().Be(p_resultatAttendu);
    }

    [Theory]
    [MemberData(nameof(GetNegOperator_CasGeneraux))]
    public void NegOperator_CasGeneraux_Rationnel(NombreRationnel p_operande1, NombreRationnel p_resultatAttendu)
    {
        // Arranger (paramètres)

        // Agir
        NombreRationnel nr = -p_operande1;

        // Auditer
        nr.Should().Be(p_resultatAttendu);
    }

    [Theory]
    [MemberData(nameof(GetMulOperator_CasGeneraux))]
    public void MulOperator_CasGeneraux_Rationnel(NombreRationnel p_operande1, NombreRationnel p_operande2, NombreRationnel p_resultatAttendu)
    {
        // Arranger (paramètres)

        // Agir
        NombreRationnel nr = p_operande1 * p_operande2;

        // Auditer
        nr.Should().Be(p_resultatAttendu);
    }

    public static IEnumerable<object[]> GetAddOperator_CasGeneraux()
    {
        yield return new object[] { new NombreRationnel(1, 3), new NombreRationnel(1, 3), new NombreRationnel(2, 3) };
        yield return new object[] { new NombreRationnel(2, 3), new NombreRationnel(1, 3), new NombreRationnel(1, 1) };
        yield return new object[] { new NombreRationnel(-2, 3), new NombreRationnel(1, 3), new NombreRationnel(-1, 3) };
        yield return new object[] { new NombreRationnel(1, 14), new NombreRationnel(1, 7), new NombreRationnel(3, 14) };
    }

    public static IEnumerable<object[]> GetSubOperator_CasGeneraux()
    {
        yield return new object[] { new NombreRationnel(1, 3), new NombreRationnel(1, 3), new NombreRationnel(0, 1) };
        yield return new object[] { new NombreRationnel(2, 3), new NombreRationnel(1, 3), new NombreRationnel(1, 3) };
        yield return new object[] { new NombreRationnel(-2, 3), new NombreRationnel(1, 3), new NombreRationnel(-1, 1) };
        yield return new object[] { new NombreRationnel(1, 14), new NombreRationnel(1, 7), new NombreRationnel(-1, 14) };
    }

    public static IEnumerable<object[]> GetMulOperator_CasGeneraux()
    {
        yield return new object[] { new NombreRationnel(1, 3), new NombreRationnel(1, 3), new NombreRationnel(1, 9) };
        yield return new object[] { new NombreRationnel(-2, 3), new NombreRationnel(1, 3), new NombreRationnel(-2, 9) };
        yield return new object[] { new NombreRationnel(-2, 3), new NombreRationnel(1, 2), new NombreRationnel(-1, 3) };
        yield return new object[] { new NombreRationnel(1, 14), new NombreRationnel(-2, 7), new NombreRationnel(-1, 49) };
    }

    public static IEnumerable<object[]> GetNegOperator_CasGeneraux()
    {
        yield return new object[] { new NombreRationnel(1, 3), new NombreRationnel(-1, 3) };
        yield return new object[] { new NombreRationnel(-2, 3), new NombreRationnel(2, 3) };
        yield return new object[] { new NombreRationnel(0, 3), new NombreRationnel(0, 1) };
        yield return new object[] { new NombreRationnel(1, 14), new NombreRationnel(-1, 14) };
    }
}
