﻿using System;

namespace DesignPatterns.AbstractFactory
{
    // AbstractProduct   
    public abstract class Guincho
    {
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
        public Porte Porte { get; set; }
    }

    // Produto Concreto
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Pequeno - Modelo " + veiculo.Modelo);
        }
    }

    // Produto Concreto
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Medio - Modelo " + veiculo.Modelo);
        }
    }

    // Produto Concreto
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Grande - Modelo " + veiculo.Modelo);
        }
    }
}